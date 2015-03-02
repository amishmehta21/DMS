using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMSBAL;
using DMSBE;
using System.Data;

namespace UserSec.DMS
{
    public partial class SubCategoryAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindCategoryId();
            }

        }

        private void BindCategoryId()
        {
            SubCategoryBAL SubCatBAL = new SubCategoryBAL();
            DataTable dt = new DataTable();
            if (SubCatBAL.ShowDdlCategory(ref dt))
            {
                this.ddlCategory.DataSource = dt;
                ddlCategory.DataTextField = "CatId";
                ddlCategory.DataValueField = "CatId";
                ddlCategory.DataBind();
                ddlCategory.Items.Insert(0, new ListItem("--Select--", "0"));

            }
        }
        protected void btnCancelSubCategory_Click(object sender, EventArgs e)
        {
            //ddlCategory.Text = "";
            txtSubCatLongDesc.Text = "";
            txtSubCatShortDesc.Text = "";
        }
        protected void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            if (!validData())
            {

            }
            else
            {
                SubCategoryBAL SubCatBal = new SubCategoryBAL();
                SubCategoryBE SubCatBe = new SubCategoryBE();
                //SubCategoryDAL SubCatDal = new SubCategoryDAL();
                SubCatBe.CatId2 = Convert.ToInt32(ddlCategory.Text);
                SubCatBe.SubCatShortDesc = txtSubCatShortDesc.Text;
                SubCatBe.SubCatLongDesc = txtSubCatLongDesc.Text;

                if (SubCatBal.AddSubCategory(SubCatBe))
                {

                    //???????Message to be displayed on master page message bar
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Record successfully added.", true);
                }
                else
                {
                    //???????Message to be displayed on master page message bar
                    LoggedIn master = (LoggedIn)this.Master;
                    master.ShowMessage("Unsuccessful", false);
                }


                txtSubCatLongDesc.Text = "";
                txtSubCatShortDesc.Text = "";

            }
        }


        //function for validating page controls

        private bool validData()
        {
            if (txtSubCatLongDesc.Text == "" || txtSubCatShortDesc.Text == "" || ddlCategory.Text == "")
            {

                //?????????Message to be displayed on master page message bar
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