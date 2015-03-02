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
            {
             
                BindCategoryList();
                string a = "";
                a = CategoryDataPager.PageSize.ToString();
                ddlPageSize.Items.Insert(0, new ListItem(a,a));
                recalcNoOfPages();
            }

        }
        private void recalcNoOfPages()
        {
            int currentPage = (CategoryDataPager.StartRowIndex / CategoryDataPager.PageSize) + 1;
            int TotalPages = (int)Math.Ceiling(Convert.ToDecimal(CategoryDataPager.TotalRowCount) / Convert.ToDecimal(CategoryDataPager.PageSize));

            DropDownList ddlpageJump = (DropDownList)(CategoryDataPager.Controls[0].FindControl("ddlPageJump"));

            ddlpageJump.Items.Clear();

            //Add a list item for each page
            for (int iPageNo = 1; iPageNo <= TotalPages; iPageNo++)
            {
                ddlpageJump.Items.Add(iPageNo.ToString());
            }

            //Set the DDL to the appropriate page value
            ddlpageJump.Items.FindByValue(currentPage.ToString()).Selected = true;

        }
        protected void PageJump_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DropDownList PageJumpDDL = (DropDownList)sender;
            int pageNo = Convert.ToInt32(PageJumpDDL.SelectedValue);

            int startRowIndex = (pageNo - 1) * CategoryDataPager.PageSize;

            CategoryDataPager.SetPageProperties(startRowIndex, CategoryDataPager.PageSize, true);
            recalcNoOfPages();

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
            this.CategoryDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            BindCategoryList();
            recalcNoOfPages();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            CategoryDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
                CategoryDataPager.PageSize, true);
            BindCategoryList();
            recalcNoOfPages();
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
            recalcNoOfPages();
        }

        protected void LvCategoryItems_Canceling(object sender, ListViewCancelEventArgs e)
        {
            LvCategoryItems.EditIndex = -1;
            BindCategoryList();
            recalcNoOfPages();
        }

        protected void LvCategoryItems_ItemEditing(object sender, ListViewEditEventArgs e)
        {

            LvCategoryItems.EditIndex = e.NewEditIndex;
            BindCategoryList();
            recalcNoOfPages();
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
            recalcNoOfPages();
        }

        protected void OnPageSizeChange(object sender, EventArgs e)
        {
            if (ddlPageSize.SelectedValue == "-Select-")
            {
            }
            else
            {
                CategoryDataPager.PageSize = Convert.ToInt32(ddlPageSize.SelectedValue);
                BindCategoryList();
            }
            recalcNoOfPages();
        }
    }
}