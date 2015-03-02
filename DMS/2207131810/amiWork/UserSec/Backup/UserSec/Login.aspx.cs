using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserSecBE;
using UserSecDAL;
using UserSecBAL;

namespace UserSec
{
    public partial class General1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string RealPass = txtPass.Text;
            if (ValidData())
            {

            }
            else
            {
                UserBE LoggedInUser = new UserBE();
                CommonBAL combal = new CommonBAL();
                UserBAL userBAL = new UserBAL();

                // Using screen inputs create UserBE;
                LoggedInUser.UserName = txtName.Text;
                LoggedInUser.EncPass = combal.Encrypt(txtPass.Text, false);

                if (userBAL.Validate(ref LoggedInUser))
                {
                    Session["LoggedInUser"] = LoggedInUser;

                    Response.Redirect(@"~\UserMaint\LoggedIn.aspx");
                }
                else
                {
                    General master = (General)this.Master;
                    master.ShowMessage("Incorrect Email or Password.", false);
                }

            }

        }

        private bool ValidData()
        {
            if (txtName.Text == "" || txtPass.Text == "")
            {
                  General master = (General)this.Master;
                 master.ShowMessage("Every field must be filled.", false);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}