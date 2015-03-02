using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserSecBE;
using System.Drawing;

namespace UserSec
{
    public partial class LoggedIn : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInUser"] ==null)
            {
                Response.Redirect("Login.aspx");
            }
            UserBE user = (UserBE)Session["LoggedInUser"];
            lblUserName.Text = user.FirstName +' '+ user.LastName ;
        }

        #region ShowMessage
        //Usage:
        //   General master = (General)this.Master;
        //   master.ShowMessage("Every field must be filled.", false);
        public void ShowMessage(string Message, bool SuccessMsg)
        {
            string msg = "";

            Label lblMsg = new Label();

            if (SuccessMsg)
            {
                msg = "<label style='color:green'><b>" + Message + "</b></label>";
                lblMsg.ForeColor = Color.Green;
            }
            else
            {
                msg = "<label style='color:red'><b>" + Message + "</b></label>";
                lblMsg.ForeColor = Color.Red;
            }


            divMessageL1.InnerHtml = msg;
            //lblMsg.Text = Message;
            //divGenMessage.InnerHtml.Insert = lblMsg.Text;

        }

        #endregion ShowMessage
    }
}