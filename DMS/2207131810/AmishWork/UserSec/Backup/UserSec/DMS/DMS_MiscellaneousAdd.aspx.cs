using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMSBAL;
using DMSBE;
using UserSecBE;

namespace UserSec.DMS
{
    public partial class MiscellaneousAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAddMiscellaneous_Click(object sender, EventArgs e)
        {
            if (!ValidData())
            {

            }
            else
            {
                MiscellaneousMasterBAL MiscBAL = new MiscellaneousMasterBAL();
                MiscellaneousMasterBE MiscBE = new MiscellaneousMasterBE();
             
                MiscBE.FieldName1 = txtFieldName1.Text;
                MiscBE.FieldName2 = txtFieldName2.Text;
                MiscBE.FieldName3 = txtFieldName3.Text;
                MiscBE.FieldName4 = txtFieldName4.Text;
                MiscBE.FieldName5 = txtFieldName5.Text;
                MiscBE.FieldName6 = txtFieldName6.Text;
                MiscBE.FieldName7 = txtFieldName7.Text;
                MiscBE.FieldName8 = txtFieldName8.Text;
                MiscBE.FieldName9 = txtFieldName9.Text;
                MiscBE.FieldName10 = txtFieldName10.Text;
                MiscBE.FieldName11 = txtFieldName11.Text;
                MiscBE.FieldName12 = txtFieldName12.Text;
                MiscBE.FieldName13 = txtFieldName13.Text;
                MiscBE.FieldName14 = txtFieldName14.Text;
                MiscBE.FieldName15 = txtFieldName15.Text;
                MiscBE.LastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;

                if (MiscBAL.AddMiscellaneous(MiscBE))
                {
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Record successfully added.",true);
                }

                else
                {
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Unsuccessful", false);
                }

                
                txtFieldName1.Text = "";
                txtFieldName2.Text = "";
                txtFieldName3.Text = "";
                txtFieldName4.Text = "";
                txtFieldName5.Text = "";
                txtFieldName6.Text = "";
                txtFieldName7.Text = "";
                txtFieldName8.Text = "";
                txtFieldName9.Text = "";
                txtFieldName10.Text = "";
                txtFieldName11.Text = "";
                txtFieldName12.Text = "";
                txtFieldName13.Text = "";
                txtFieldName14.Text = "";
                txtFieldName15.Text = "";
            }
        }
        protected void btnCancelCategory_Click(object sender, EventArgs e)
        {
           
            txtFieldName1.Text = "";
            txtFieldName2.Text = "";
            txtFieldName3.Text = "";
            txtFieldName4.Text = "";
            txtFieldName5.Text = "";
            txtFieldName6.Text = "";
            txtFieldName7.Text = "";
            txtFieldName8.Text = "";
            txtFieldName9.Text = "";
            txtFieldName10.Text = "";
            txtFieldName11.Text = "";
            txtFieldName12.Text = "";
            txtFieldName13.Text = "";
            txtFieldName14.Text = "";
            txtFieldName15.Text = "";
        }

        private bool ValidData()
        {
            if ( txtFieldName1.Text == "" && txtFieldName2.Text == "" && txtFieldName3.Text == ""

                && txtFieldName4.Text == "" && txtFieldName5.Text == "" && txtFieldName6.Text == "" && txtFieldName7.Text == "" && txtFieldName8.Text == ""

                && txtFieldName9.Text == "" && txtFieldName10.Text == "" && txtFieldName11.Text == "" && txtFieldName12.Text == ""

                && txtFieldName13.Text == "" && txtFieldName14.Text == "" && txtFieldName15.Text == "")
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Every Field must be filled.", false);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}