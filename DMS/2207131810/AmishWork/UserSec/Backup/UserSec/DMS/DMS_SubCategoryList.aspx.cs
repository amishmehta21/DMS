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

namespace UserSec.DMS
{
    public partial class SubCategoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSubCatList();
                recalcNoOfPages();
            }
        }
        private void BindSubCatList()
        {
            SubCategoryBAL SubCatBAL = new SubCategoryBAL();
            SubCategoryBE SubCatBE = new SubCategoryBE();
            DataTable dt = new DataTable();
            if (SubCatBAL.ShowSubCategory(ref dt))
            {
                this.LvSubCategoryItems.DataSource = dt;
                LvSubCategoryItems.DataBind();

            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful", false);
            }

        }
        protected void ListViewSubCategory_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            LvSubCategoryItems.EditIndex = -1;
            this.SubCategoryDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            BindSubCatList();
            recalcNoOfPages();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox txtRowNo = (TextBox)sender;

            SubCategoryDataPager.SetPageProperties(Convert.ToInt32(txtRowNo.Text) - 1,
                SubCategoryDataPager.PageSize, true);
            BindSubCatList();
            recalcNoOfPages();
        }

     

        private void recalcNoOfPages()
        {
            int currentPage = (SubCategoryDataPager.StartRowIndex / SubCategoryDataPager.PageSize) + 1;
            int TotalPages = (int) Math.Ceiling(Convert.ToDecimal(SubCategoryDataPager.TotalRowCount) / Convert.ToDecimal(SubCategoryDataPager.PageSize));
           
            DropDownList ddlpageJump = (DropDownList)(SubCategoryDataPager.Controls[0].FindControl("ddlPageJump"));

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

            int startRowIndex = (pageNo - 1) * SubCategoryDataPager.PageSize;

            SubCategoryDataPager.SetPageProperties(startRowIndex, SubCategoryDataPager.PageSize, true);
            recalcNoOfPages();

        }
        protected void LvSubCategoryItems_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {

            string SubCatId = LvSubCategoryItems.DataKeys[e.ItemIndex].Value.ToString();

            SubCategoryBE SubCatBE = new SubCategoryBE();
            SubCategoryBAL SubCatBal = new SubCategoryBAL();
            SubCatBE.SubCatId1 = Convert.ToInt32(SubCatId);


            if (SubCatBal.DeleteSubCategory(SubCatBE))
            {
                LvSubCategoryItems.EditIndex = -1;
                BindSubCatList();
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Record successfully deleted.", true);
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Sorry You cannot delete subCategory id because its already in use", false);
            }
            recalcNoOfPages();
        }

        protected void LvSubCategoryItems_Canceling(object sender, ListViewCancelEventArgs e)
        {
            LvSubCategoryItems.EditIndex = -1;
            BindSubCatList();
            recalcNoOfPages();
        }

        protected void LvSubCategoryItems_ItemEditing(object sender, ListViewEditEventArgs e)
        {

            LvSubCategoryItems.EditIndex = e.NewEditIndex;
            BindSubCatList();
            recalcNoOfPages();
        }

        protected void LvSubCategoryItems_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            string SubCatId = LvSubCategoryItems.DataKeys[e.ItemIndex].Value.ToString();

            TextBox ShortDesc = LvSubCategoryItems.Items[e.ItemIndex].FindControl("txtShortDesc") as TextBox;
            TextBox LongDesc = LvSubCategoryItems.Items[e.ItemIndex].FindControl("txtLongDesc") as TextBox;
            TextBox LastModifiedAt = LvSubCategoryItems.Items[e.ItemIndex].FindControl("txtLastModifiedAt") as TextBox;
            TextBox LastModifiedBy = LvSubCategoryItems.Items[e.ItemIndex].FindControl("txtLastModifiedBy") as TextBox;
            SubCategoryBE SubCatBE = new SubCategoryBE();
            SubCategoryBAL SubCatBAL = new SubCategoryBAL();
            SubCatBE.SubCatId1 = Convert.ToInt32(SubCatId);
            SubCatBE.SubCatShortDesc = ShortDesc.Text;
            SubCatBE.SubCatLongDesc = LongDesc.Text;
            SubCatBE.SubCatLastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;
            if (SubCatBAL.ModifySubCategory(SubCatBE))
            {
                LvSubCategoryItems.EditIndex = -1;
                BindSubCatList();
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

        protected void lvItemRowCommand(object sender, ListViewCommandEventArgs e)
        {
        }

        protected void OnPageSizeChange(object sender, EventArgs e)
        {
            if (ddlPageSize.SelectedValue == "-Select-")
            {
            }
            else
            {
                SubCategoryDataPager.PageSize = Convert.ToInt32(ddlPageSize.SelectedValue);
                BindSubCatList();
            }

            recalcNoOfPages();
        }
    }
}