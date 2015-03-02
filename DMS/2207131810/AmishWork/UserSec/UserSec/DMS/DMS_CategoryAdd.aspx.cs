using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DMSBE;
using DMSBAL;
using UserSecBE;

namespace UserSec
{
    public partial class CategoryAdd : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnCancelCategory_Click(object sender, EventArgs e)
        {

            txtCatShortDesc.Text = "";
            txtCatLongDesc.Text = "";
        }
        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!validData())
            {

            }
            else
            {
                CategoryBAL CatBAL = new CategoryBAL();
                CategoryBE CatBE = new CategoryBE();


                CatBE.CatShortDesc = txtCatShortDesc.Text;
                CatBE.CatLongDesc = txtCatLongDesc.Text;
                CatBE.CatLastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;

                if (CatBAL.AddCategory(CatBE))
                {
                    //????? Message to be displayed on master page message bar
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Record successfully added.", true);
                }
                else
                {
                    //????? Message to be displayed on master page message bar 
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Unsuccessful", false);
                }


                txtCatLongDesc.Text = "";
                txtCatShortDesc.Text = "";
            }


        }
        private bool validData()
        {
            if (txtCatLongDesc.Text == "" || txtCatShortDesc.Text == "")
            {
                //????? Message to be displayed on master page message bar
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