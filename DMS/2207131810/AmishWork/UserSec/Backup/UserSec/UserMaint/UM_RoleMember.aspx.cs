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
    public partial class UM_RoleMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindRoleIdDDL();
            

        }
        protected void lvRoleMember_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            Button btnAdd;
            Button btnRemove;
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                btnAdd = (Button)e.Item.FindControl("btnAdd");
                btnRemove = (Button)e.Item.FindControl("btnRemove");
                System.Data.DataRowView rowView = e.Item.DataItem as System.Data.DataRowView;
                string IsMember = rowView["IsMember"].ToString();
                if (IsMember == "false")
                {
                    btnRemove.Visible = false;
                }
                if (IsMember == "true")
                {
                    btnAdd.Visible = false;
                }
            }
        }
        protected void ddlRoleId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlRoleId.SelectedItem.Value == "-Select-")
            {
                lvRoleMember.Visible = false;
                RoleMemberDataPager.Visible = false;
            }
            else
            {

                RoleMemberBE roleMember = new RoleMemberBE();
                RoleMemberBAL roleMemberBAL = new RoleMemberBAL();
                DataTable dt = new DataTable();

                roleMember.RoleId = Convert.ToInt32(ddlRoleId.SelectedItem.Value);
                hdnRoleId.Value = roleMember.RoleId.ToString();

               
                bindlvRoleMember();
            }
        }
        public void BindRoleIdDDL()
        {
            RoleMemberBAL roleMemberBAL = new RoleMemberBAL();
            DataTable dt = new DataTable();
            if (roleMemberBAL.GetAllRoleId(ref dt))
            {
                ddlRoleId.DataSource = dt;
                ddlRoleId.DataTextField = "RoleShortDesc";
                ddlRoleId.DataValueField = "RoleId";
                ddlRoleId.DataBind();
                ddlRoleId.Items.Insert(0, new ListItem("-Select-", "-Select-"));
                
            }
        }
        private void bindlvRoleMember()
        {

            RoleMemberBE roleMember = new RoleMemberBE();
            RoleMemberBAL roleMemberBAL = new RoleMemberBAL();
            DataTable dt = new DataTable();
            roleMember.RoleId =Convert.ToInt32(hdnRoleId.Value.ToString());
            if (roleMemberBAL.GetAllRoleMembers(ref dt,ref roleMember))
            {
                this.lvRoleMember.DataSource = dt;
                lvRoleMember.Visible = true;
                RoleMemberDataPager.Visible = true;
                lvRoleMember.DataBind();
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful",false);
            }

        }
        protected void lvRoleMember_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            lvRoleMember.EditIndex = -1;
            this.RoleMemberDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            bindlvRoleMember();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            RoleMemberDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
             RoleMemberDataPager.PageSize, true);
            bindlvRoleMember();
        }

        protected void lvRoleMember_OnItemCommand(object sender, ListViewCommandEventArgs e)
        {
            
            RoleMemberBAL roleMemberBAL= new RoleMemberBAL();
            RoleMemberBE roleMember = new RoleMemberBE();
            roleMember.LastModifiedBy= ((UserBE)Session["LoggedInUser"]).UserId;

            if (String.Equals(e.CommandName, "Add"))
            {
                string[] arg = new string[2];
                arg = e.CommandArgument.ToString().Split(',');
                roleMember.UserId = Convert.ToInt32(arg[0]);
                roleMember.RoleId = Convert.ToInt32(arg[1]);
                if (roleMemberBAL.AddRoleMember(roleMember))
                {
                    bindlvRoleMember();
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Successfully Added.", true);
                }
                else
                {
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Unsuccessful.", false);
                }
                lvRoleMember.EditIndex = -1;
            }
            else if (String.Equals(e.CommandName, "Remove"))
            {
                string[] arg = new string[2];
                arg = e.CommandArgument.ToString().Split(',');
                roleMember.UserId = Convert.ToInt32(arg[0]);
                roleMember.RoleId = Convert.ToInt32(arg[1]);
                if (roleMemberBAL.DeleteRoleMember(roleMember))
                {
                    bindlvRoleMember();
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Successfully Removed.", true);
                }
                else
                {
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Unsuccessful.", false);
                }
                lvRoleMember.EditIndex = -1;
            }
        }
    }
}
