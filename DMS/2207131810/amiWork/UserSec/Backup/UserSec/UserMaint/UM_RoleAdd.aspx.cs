﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserSecBAL;
using UserSecBE;
using UserSecDAL;

namespace UserSec
{
    public partial class UM_RoleAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        private bool ValidData()
        {
            if (txtRoleShortDesc.Text == "" || txtRoleLongDesc.Text == "")
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Every Field must be filled.", false);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void btnAddRole_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {

            }
            else
            {
                UserBE user = (UserBE)Session["LoggedInUser"];
                RoleBE addRoleBE = new RoleBE();
                RoleDAL addRoleDal = new RoleDAL();
                RoleBAL addRoleBal = new RoleBAL();

                addRoleBE.RoleShortDesc = txtRoleShortDesc.Text;
                addRoleBE.RoleLongDesc = txtRoleLongDesc.Text;
                addRoleBE.LastModifiedBy = user.UserId;

                if (addRoleBal.AddRole(addRoleBE))
                {
                    txtRoleShortDesc.Text = "";
                    txtRoleLongDesc.Text = "";
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Record Inserted Successfully.", true);

                }
                else
                {
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Unsuccessful.", false);
                }
            }
        }
    }
}