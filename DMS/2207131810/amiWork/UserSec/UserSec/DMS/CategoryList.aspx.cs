using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMSBE;
using DMSBAL;
using System.Data;
using UserSecBE;

namespace UserSec
{
    public partial class CategoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindCategoryList();

        }
        private void BindCategoryList()
        {

            CategoryBAL CatBAL = new CategoryBAL();
            DataTable dt = new DataTable();
            if (CatBAL.ShowCategory(ref dt))
            {
                this.LvCategoryItems.DataSource = dt;
                LvCategoryItems.DataBind();
                // Response.Write("Successful");
            }
            else
            {
                //Response.Write("Unsuccessfull");
            }



        }
        protected void ListViewCategory_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            LvCategoryItems.EditIndex = -1;
            this.EmployeesDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            BindCategoryList();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            EmployeesDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
                EmployeesDataPager.PageSize, true);
            BindCategoryList();
        }




        protected void LvCategoryItems_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {


            string CatId = LvCategoryItems.DataKeys[e.ItemIndex].Value.ToString();

            CategoryBE CatBE = new CategoryBE();
            CategoryBAL CatBAL = new CategoryBAL();
            CatBE.CatId1 = Convert.ToInt32(CatId);

            if (CatBAL.DeleteCategory(CatBE))
            {
                LvCategoryItems.EditIndex = -1;
                BindCategoryList();
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Record successfully deleted.", true);
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Sorry you cannot delete category Id because its already in use", false);
            }

        }

        protected void LvCategoryItems_Canceling(object sender, ListViewCancelEventArgs e)
        {
            LvCategoryItems.EditIndex = -1;
            BindCategoryList();
        }

        protected void LvCategoryItems_ItemEditing(object sender, ListViewEditEventArgs e)
        {

            LvCategoryItems.EditIndex = e.NewEditIndex;
            BindCategoryList();
        }

        protected void LvCategoryItems_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            string CatId = LvCategoryItems.DataKeys[e.ItemIndex].Value.ToString();

            TextBox ShortDesc = LvCategoryItems.Items[e.ItemIndex].FindControl("txtShortDesc") as TextBox;
            TextBox LongDesc = LvCategoryItems.Items[e.ItemIndex].FindControl("txtLongDesc") as TextBox;

            CategoryBE CatBE = new CategoryBE();
            CategoryBAL CatBal = new CategoryBAL();
            CatBE.CatId1 = Convert.ToInt32(CatId);
            CatBE.CatShortDesc = ShortDesc.Text;
            CatBE.CatLongDesc = LongDesc.Text;
            CatBE.CatLastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;

            if (CatBal.ModifyCategory(CatBE))
            {

                LvCategoryItems.EditIndex = -1;
                BindCategoryList();
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Record successfully updated.", true);
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful", false);
            }
        }

        protected void OnPageSizeChange(object sender, EventArgs e)
        {
            if (ddlPageSize.SelectedValue == "-Select-")
            {
            }
            else
            {
                EmployeesDataPager.PageSize = Convert.ToInt32(ddlPageSize.SelectedValue);
                BindCategoryList();
            }
        }
    }
}