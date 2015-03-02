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
                BindSubCatList();
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
            this.EmployeesDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            BindSubCatList();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            EmployeesDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
                EmployeesDataPager.PageSize, true);
            BindSubCatList();
        }



        protected void LvSubCategoryItems_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }

        protected void LvSubCategoryItems_Canceling(object sender, ListViewCancelEventArgs e)
        {
            LvSubCategoryItems.EditIndex = -1;
            BindSubCatList();
        }

        protected void LvSubCategoryItems_ItemEditing(object sender, ListViewEditEventArgs e)
        {

            LvSubCategoryItems.EditIndex = e.NewEditIndex;
            BindSubCatList();
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
                EmployeesDataPager.PageSize = Convert.ToInt32(ddlPageSize.SelectedValue);
                BindSubCatList();
            }
        }
    }
}