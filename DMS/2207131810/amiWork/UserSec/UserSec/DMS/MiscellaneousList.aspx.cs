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
    public partial class MiscellaneousList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindMiscellaneousList();
            }
        }

        private void BindMiscellaneousList()
        {
            MiscellaneousMasterBAL MiscBAL = new MiscellaneousMasterBAL();
            MiscellaneousMasterBE MiscBE = new MiscellaneousMasterBE();
            DataTable dt = new DataTable();
            if (MiscBAL.ShowMiscellaneous(ref dt))
            {
                this.LvMiscellaneousItems.DataSource = dt;
                LvMiscellaneousItems.DataBind();
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful", false);
            }
        }

        protected void ListviewvMiscellaneous_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            LvMiscellaneousItems.EditIndex = -1;
            this.MiscellaneousDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            BindMiscellaneousList();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            MiscellaneousDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
                MiscellaneousDataPager.PageSize, true);
            BindMiscellaneousList();
        }


        protected void LvMiscellaneousItems_Canceling(object sender, ListViewCancelEventArgs e)
        {
            LvMiscellaneousItems.EditIndex = -1;
            BindMiscellaneousList();
        }

        protected void LvMiscellaneousItems_ItemEditing(object sender, ListViewEditEventArgs e)
        {

            LvMiscellaneousItems.EditIndex = e.NewEditIndex;
            BindMiscellaneousList();
        }


        protected void LvMiscellaneousItems_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {


            string MiscId = LvMiscellaneousItems.DataKeys[e.ItemIndex].Value.ToString();

            TextBox FieldName1 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName1") as TextBox;
            TextBox FieldName2 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName2") as TextBox;
            TextBox FieldName3 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName3") as TextBox;
            TextBox FieldName4 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName4") as TextBox;
            TextBox FieldName5 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName5") as TextBox;
            TextBox FieldName6 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName6") as TextBox;
            TextBox FieldName7 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName7") as TextBox;
            TextBox FieldName8 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName8") as TextBox;
            TextBox FieldName9 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName9") as TextBox;
            TextBox FieldName10 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName10") as TextBox;
            TextBox FieldName11 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName11") as TextBox;
            TextBox FieldName12 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName12") as TextBox;
            TextBox FieldName13 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName13") as TextBox;
            TextBox FieldName14 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName14") as TextBox;
            TextBox FieldName15 = LvMiscellaneousItems.Items[e.ItemIndex].FindControl("txtFieldName15") as TextBox;


            MiscellaneousMasterBE MiscBE = new MiscellaneousMasterBE();
            MiscellaneousMasterBAL MiscBAL = new MiscellaneousMasterBAL();
            MiscBE.MiscId = Convert.ToInt32(MiscId);
           
            MiscBE.FieldName1 = FieldName1.Text;
            MiscBE.FieldName2 = FieldName2.Text;
            MiscBE.FieldName3 = FieldName3.Text;
            MiscBE.FieldName4 = FieldName4.Text;
            MiscBE.FieldName5 = FieldName5.Text;
            MiscBE.FieldName6 = FieldName6.Text;
            MiscBE.FieldName7 = FieldName7.Text;
            MiscBE.FieldName8 = FieldName8.Text;
            MiscBE.FieldName9 = FieldName9.Text;
            MiscBE.FieldName10 = FieldName10.Text;
            MiscBE.FieldName11 = FieldName11.Text;
            MiscBE.FieldName12 = FieldName12.Text;
            MiscBE.FieldName13 = FieldName13.Text;
            MiscBE.FieldName14 = FieldName14.Text;
            MiscBE.FieldName15 = FieldName15.Text;
            MiscBE.LastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;


            if (MiscBAL.ModifyMiscellaneous(MiscBE))
            {

                LvMiscellaneousItems.EditIndex = -1;
                BindMiscellaneousList();
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
                MiscellaneousDataPager.PageSize = Convert.ToInt32(ddlPageSize.SelectedValue);
                BindMiscellaneousList();
            }
        }
    }
}