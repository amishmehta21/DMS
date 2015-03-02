using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserSecBE;
using UserSecBAL;
using System.Data;

namespace UserSec
{
    public partial class UM_RoleList : System.Web.UI.Page
    {
        CommonBAL commonBAL = new CommonBAL();
        UserBE LoggedInUser = new UserBE();
        LoggedIn LIPg = new LoggedIn();
        string thisPageName = "UM_RoleList.aspx"; 
        protected void Page_Load(object sender, EventArgs e)
        {
            LoggedInUser = (UserBE)Session["LoggedInUser"];

            if (LoggedInUser == null)
            {
                // return to login page because user has not loggedin or session has timedout...
                Server.Transfer("~/Login.aspx");
            }

            if (!commonBAL.isPageAccessibleToUser(LoggedInUser.UserId, thisPageName))
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("You are not authorised to access this page. Please contact system administrator.", false);
                Server.Transfer("UM_BlankPage.aspx"); //?? Message through Query String
                return;
              
            }
            else
            {
                if (!IsPostBack)
                    bind();
                recalcNoOfPages();
            }

        }
        private void recalcNoOfPages()
        {
            int currentPage = (RoleDataPager.StartRowIndex / RoleDataPager.PageSize) + 1;
            int TotalPages = (int)Math.Ceiling(Convert.ToDecimal(RoleDataPager.TotalRowCount) / Convert.ToDecimal(RoleDataPager.PageSize));

            DropDownList ddlpageJump = (DropDownList)(RoleDataPager.Controls[0].FindControl("ddlPageJump"));

            ddlpageJump.Items.Clear();

            //Add a list item for each page
            for (int iPageNo = 1; iPageNo <= TotalPages; iPageNo++)
            {
                ddlpageJump.Items.Add(iPageNo.ToString());
            }

            //Set the DDL to the appropriate page value
            ddlpageJump.Items.FindByValue(currentPage.ToString()).Selected = true;

        }

        protected void PageJump_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DropDownList PageJumpDDL = (DropDownList)sender;
            int pageNo = Convert.ToInt32(PageJumpDDL.SelectedValue);

            int startRowIndex = (pageNo - 1) * RoleDataPager.PageSize;

            RoleDataPager.SetPageProperties(startRowIndex, RoleDataPager.PageSize, true);
            recalcNoOfPages();

        }
        private void bind()
        {
            RoleBAL roleBAL = new RoleBAL();
            RoleBE roleDetails = new RoleBE();
            DataTable dt = new DataTable();
            if (roleBAL.GetAllRoleDetails(ref dt))
            {
                this.lvItems.DataSource = dt;
                lvItems.DataBind();

            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful", false);
            }

        }
        protected void ListView1_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {

            lvItems.EditIndex = -1;
            this.RoleDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            bind();
            recalcNoOfPages();
        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            RoleDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
                RoleDataPager.PageSize, true);
            bind();
            recalcNoOfPages();
        }



        protected void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void lvItems_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {
            if (!commonBAL.isUserAuthorisedForPageFunc(LoggedInUser.UserId, thisPageName, "DeleteRec"))
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("You are not authorised to perform this function. Please contact system administrator.", false);
                return;
            }
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {
                RoleBE role = new RoleBE();
                RoleBAL roleBAL = new RoleBAL();
                string RoleId = lvItems.DataKeys[e.ItemIndex].Value.ToString();
                role.RoleId = Convert.ToInt32(RoleId);
                if (roleBAL.DeleteRole(role))
                {
                    lvItems.EditIndex = -1;
                    bind();
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Record Successfully deleted.", true);
                }
                else
                {
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Unsuccessful",false);
                }
            }
            else
            {

            }
            recalcNoOfPages();

        }

        protected void lvItems_Canceling(object sender, ListViewCancelEventArgs e)
        {
           
            lvItems.EditIndex = -1;
            bind();
            recalcNoOfPages();
        }

        protected void lvItems_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            //Check if user has access right to perform the update/modify function 
            if (!commonBAL.isUserAuthorisedForPageFunc(LoggedInUser.UserId, thisPageName, "ModifyRec"))
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("You are not authorised to perform this function. Please contact system administrator.", false);

            }
            else
            {

                lvItems.EditIndex = e.NewEditIndex;
                bind();
                recalcNoOfPages();
            }
        }

        protected void lvItems_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            if (!commonBAL.isUserAuthorisedForPageFunc(LoggedInUser.UserId, thisPageName, "ModifyRec"))
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("You are not authorised to perform this function. Please contact system administrator.", false);
                return;
            }

            RoleBE role = new RoleBE();
            RoleBAL roleBAL = new RoleBAL();

            string RoleId = lvItems.DataKeys[e.ItemIndex].Value.ToString();
            TextBox RoleShortDesc = lvItems.Items[e.ItemIndex].FindControl("txtRoleShortDesc") as TextBox;
            TextBox RoleLongDesc = lvItems.Items[e.ItemIndex].FindControl("txtRoleLongDesc") as TextBox;
            role.RoleId = Convert.ToInt32(RoleId);
            role.RoleShortDesc = RoleShortDesc.Text;
            role.RoleLongDesc = RoleLongDesc.Text;
            role.LastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;
            if (roleBAL.ModifyRole(role))
            {
                lvItems.EditIndex = -1;
                bind();
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Record Successfully Updated.", true);
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful",false);
            }
            recalcNoOfPages();
        }
        protected void lvItemRowCommand(object sender, ListViewCommandEventArgs e)
        {
        }

        protected void OnPageSizeChange(object sender, EventArgs e)
        {
            if (ddlPageSize.SelectedValue == "-Select-")
            {
            }
            else
            {
                RoleDataPager.PageSize = Convert.ToInt32(ddlPageSize.SelectedValue);
                bind();
            }
            recalcNoOfPages();
        }
    }
}