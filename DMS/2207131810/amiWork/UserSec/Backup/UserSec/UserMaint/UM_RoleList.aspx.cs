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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bind();

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
            this.EmployeesDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            bind();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            EmployeesDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
                EmployeesDataPager.PageSize, true);
            bind();
        }



        protected void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void lvItems_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {
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

        }

        protected void lvItems_Canceling(object sender, ListViewCancelEventArgs e)
        {
            lvItems.EditIndex = -1;
            bind();
        }

        protected void lvItems_ItemEditing(object sender, ListViewEditEventArgs e)
        {

            lvItems.EditIndex = e.NewEditIndex;
            bind();
        }

        protected void lvItems_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
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
                EmployeesDataPager.PageSize = Convert.ToInt32(ddlPageSize.SelectedValue);
                bind();
            }
        }
    }
}