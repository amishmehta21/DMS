using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMSBE;
using DMSBAL;
using System.Data;

namespace UserSec.DMS
{
    public partial class SearchDocument : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected bool ValidData()
        {
            if (txtSearch.Text == "")
            {
                LvDocumentItems.Visible = false;
                EmployeesDataPager.Visible = false;
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Please enter the text which you want to search.", false);
                return true;
            }
            else
            {
                return false;
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
           hdnSearchField.Value = txtSearch.Text;
            if (ValidData())
            {
            }
            else
            {
                bindListView();

            }
        }
        private void bindListView()
        {

            DocumentBE DocBE = new DocumentBE();
            DocumentBAL DocBAL = new DocumentBAL();
            DataTable dt = new DataTable();
            DocBE.SearchField = hdnSearchField.Value.ToString();
            if (DocBAL.SearchDoc(DocBE, ref dt))
            {
                LvDocumentItems.Visible = true;
                EmployeesDataPager.Visible = true;
                this.LvDocumentItems.DataSource = dt;
                LvDocumentItems.DataBind();
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("", false);
            }
            else
            {
                LvDocumentItems.Visible = false;
                EmployeesDataPager.Visible = false;
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("No records were found.", false);

            }

        }
        protected void ListViewDocument_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {

            LvDocumentItems.EditIndex = -1;
            this.EmployeesDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            bindListView();

        }
        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            EmployeesDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
                EmployeesDataPager.PageSize, true);
            bindListView();
        }
    }
}