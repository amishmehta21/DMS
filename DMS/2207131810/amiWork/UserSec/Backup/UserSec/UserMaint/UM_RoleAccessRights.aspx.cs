using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserSecBAL;
using System.Data;
using UserSecBE;

namespace UserSec
{
    public partial class UM_RoleAccessRights : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindRoleIdDDL();
                btnSave.Visible = false;
            }
        }

        public void bindRoleIdDDL()
        {
            RoleAccessRightsBAL roleAccessBAL = new RoleAccessRightsBAL();
            DataTable dt = new DataTable();
            if (roleAccessBAL.GetAllRoleId(ref dt))
            {
                ddlRoleId.DataSource = dt;
                ddlRoleId.DataTextField = "RoleShortDesc";
                ddlRoleId.DataValueField = "RoleId";
                ddlRoleId.DataBind();
                ddlRoleId.Items.Insert(0, new ListItem("-Select-", "-Select-"));

            }

        }

        protected void ddlRoleId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlRoleId.SelectedItem.Value == "-Select-")
            {
                btnSave.Visible = false;
                lvRoleAccessRight.Visible = false;
                RoleAccessRightDataPager.Visible = false;
            }
            else
            {

                RoleAccessRightsBE RACCBE = new RoleAccessRightsBE();
                RoleAccessRightsBAL roleAccessBAL = new RoleAccessRightsBAL();
                DataTable dt = new DataTable();

                RACCBE.RoleID = Convert.ToInt32(ddlRoleId.SelectedItem.Value);
                hdnRoleId.Value = RACCBE.RoleID.ToString();

                bindListView();
            }
        }

        private void bindListView()
        {

            RoleMemberBE roleMember = new RoleMemberBE();
            RoleAccessRightsBAL roleAccessBAL = new RoleAccessRightsBAL();
            DataTable dt = new DataTable();
            roleMember.RoleId = Convert.ToInt32(hdnRoleId.Value.ToString());
            if (roleAccessBAL.GetAllRoleAccessRightDetails(ref dt, ref roleMember))
            {
                this.lvRoleAccessRight.DataSource = dt;
                lvRoleAccessRight.Visible = true;
                RoleAccessRightDataPager.Visible = true;
                btnSave.Visible = true;
                lvRoleAccessRight.DataBind();
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful", false);
            }

        }

        protected void lvRoleAccessRight_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            lvRoleAccessRight.EditIndex = -1;
            this.RoleAccessRightDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            bindListView();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            RoleAccessRightDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
             RoleAccessRightDataPager.PageSize, true);
            bindListView();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            RoleAccessRightsBAL roleAccessBAL = new RoleAccessRightsBAL();
            RoleAccessRightsBE roleAccessBE = new RoleAccessRightsBE();

            // roleAccessBE = loadRoleAccessRightsBE(roleAccessBE);
            roleAccessBE.RoleID = Convert.ToInt32(ddlRoleId.SelectedValue);
            roleAccessBE.LastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;
            loadRoleAccessRightsBE(roleAccessBE);

        }


        private void loadRoleAccessRightsBE(RoleAccessRightsBE roleAccessBE)
        {
            int a = 0;
            int count = 0;
            RoleAccessRightsBAL RACBAL = new RoleAccessRightsBAL();

            for (int iRow = 0; iRow < lvRoleAccessRight.Items.Count; iRow++)
            {
                for (int iCell = 5; iCell < lvRoleAccessRight.Items[0].Controls.Count - 1; iCell += 2)
                {
                    roleAccessBE.PRAId = Convert.ToInt32(lvRoleAccessRight.DataKeys[iRow].Value.ToString());
                    if (((CheckBox)lvRoleAccessRight.Items[iRow].Controls[iCell]).Checked)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 0;
                    }
                    AssignValueRoleAccessRightsBE(iCell, ref roleAccessBE, a);

                }

                if (RACBAL.SaveRoleAccessRightDetails(roleAccessBE))
                {
                    count = count + 1;
                    if (count == lvRoleAccessRight.Items.Count)
                    {

                        LoggedIn master = (LoggedIn)this.Master;
                        master.ShowMessage("Role Successfully Updated.", true);
                    }
               
                }
                else
                {
                     count = count + 1;
                     if (count == lvRoleAccessRight.Items.Count)
                     {
                         LoggedIn master = (LoggedIn)this.Master;
                         master.ShowMessage("Unsuccessful", false);
                     }
                }

            }

        }


        public void AssignValueRoleAccessRightsBE(int iCell, ref RoleAccessRightsBE roleAccessBE, int Value)
        {
            switch (iCell)
            {
                case 5:
                    roleAccessBE.AddRec = Value;
                    break;
                case 7:
                    roleAccessBE.DeleteRec = Value;
                    break;
                case 9:
                    roleAccessBE.ModifyRec = Value;
                    break;
                case 11:
                    roleAccessBE.ViewRec = Value;
                    break;
                case 13:
                    roleAccessBE.PrintRec = Value;
                    break;
                case 15:
                    roleAccessBE.Search = Value;
                    break;
                case 17:
                    roleAccessBE.Approve = Value;
                    break;
            }

        }
    }
}