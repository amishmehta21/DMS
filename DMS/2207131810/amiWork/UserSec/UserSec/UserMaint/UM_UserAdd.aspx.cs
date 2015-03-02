using System;
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
    public partial class UM_AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

         private bool ValidData()
        {
            if (txtUserName.Text == "" || txtFName.Text == "" ||txtLName.Text == "" || txtPREmailId.Text == "" || txtSecretAns.Text == "" || txtPass.Text == "")
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Fields which are marked as (*) are mandatory.", false);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {

            }
            else
            {
                CommonBAL combal = new CommonBAL();
                UserBE addUserBE = new UserBE();
                UserDAL addUserdAL = new UserDAL();
                UserBAL addUserBal = new UserBAL();
                addUserBE.LastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;

                addUserBE.UserName = txtUserName.Text;
                addUserBE.FirstName = txtFName.Text;
                addUserBE.MiddleName = txtMName.Text;
                addUserBE.LastName = txtLName.Text;
                addUserBE.PrimaryEmailId = txtPREmailId.Text;
                addUserBE.SecondaryEmailId = txtSCEmailId.Text;
                addUserBE.MobileNo = txtMobileNo.Text;
                addUserBE.Address1 = txtAddress1.Text;
                addUserBE.Address2 = txtAddress2.Text;
                addUserBE.Street = txtStreet.Text;
                addUserBE.City = txtCity.Text;
                addUserBE.State1 = txtState.Text;
                addUserBE.Country = txtCountry.Text;
                addUserBE.SecretQuest = ddSecretQuest.SelectedValue;
                addUserBE.SecretAns = txtSecretAns.Text;
                addUserBE.EncPass = combal.Encrypt(txtPass.Text, false);

                if (addUserBal.AddUser(addUserBE))
                {
                    txtUserName.Text = "";
                    txtFName.Text = "";
                    txtMName.Text = "";
                    txtLName.Text = "";
                    txtPREmailId.Text = "";
                    txtSCEmailId.Text = "";
                    txtMobileNo.Text = "";
                    txtAddress1.Text = "";
                    txtAddress2.Text = "";
                    txtStreet.Text = "";
                    txtCity.Text = "";
                    txtState.Text = "";
                    txtCountry.Text = "";
                    ddSecretQuest.Text = "-Select-";
                    txtSecretAns.Text = "";
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Record Inserted Successfully.", true);
                }
                else
                {
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Unsuccessful",false);
                }
            }

           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtFName.Text = "";
            txtMName.Text = "";
            txtLName.Text = "";
            txtPREmailId.Text = "";
            txtSCEmailId.Text = "";
            txtMobileNo.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtCountry.Text = "";
            ddSecretQuest.Text = "-Select-";
            txtSecretAns.Text = "";
        }
    }
    }
