using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserSecBE;
using UserSecBAL;
using System.Data;

namespace UserSec.UserMaint
{
    public partial class UM_UserList : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bindLVUser();

        }
        private void bindLVUser()
        {

            UserBE user = new UserBE();
            UserBAL userBAL = new UserBAL();
            DataTable dt = new DataTable();
            if (userBAL.GetAllUserDetails(ref dt))
            {
                this.lvUserList.DataSource = dt;
                lvUserList.DataBind();

            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful",false);
            }

        }
        protected void lvUserList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            lvUserList.EditIndex = -1;
            this.EmployeesDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            bindLVUser();

        }

        protected void CurrentRowTextBox_OnTextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            //DataPager pager =(DataPager)lvUserList.FindControl("EmployeesDataPager");
            //pager.SetPageProperties(Convert.ToInt32(t.Text) - 1,pager.PageSize, true);

            EmployeesDataPager.SetPageProperties(Convert.ToInt32(t.Text) - 1,
                EmployeesDataPager.PageSize, true);
            bindLVUser();
        }

        protected void lvUserList_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {
             string confirmValue = Request.Form["confirm_value"];
             if (confirmValue == "Yes")
             {

                 UserBE user = new UserBE();
                 UserBAL userBAL = new UserBAL();
                 string UserId = lvUserList.DataKeys[e.ItemIndex].Value.ToString();
                 user.UserId = Convert.ToInt32(UserId);
                 if (userBAL.Delete(user))
                 {
                     lvUserList.EditIndex = -1;
                     bindLVUser();
                 }
                 else
                 {
                 }
             }
             else
             {
             }

        }

        protected void lvUserList_Canceling(object sender, ListViewCancelEventArgs e)
        {
            lvUserList.EditIndex = -1;
            bindLVUser();
        }

        protected void lvUserList_ItemEditing(object sender, ListViewEditEventArgs e)
        {

            lvUserList.EditIndex = e.NewEditIndex;
            bindLVUser();
        }

        protected void lvUserList_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            
            UserBE user = new UserBE();
            UserBAL userBAL = new UserBAL();
            CommonBAL commonBAL = new CommonBAL();
            user.LastModifiedBy = ((UserBE)Session["LoggedInUser"]).UserId;
            
            string UserId = lvUserList.DataKeys[e.ItemIndex].Value.ToString();//
            Label userName = lvUserList.Items[e.ItemIndex].FindControl("lbUserName") as Label;//
            TextBox firstName = lvUserList.Items[e.ItemIndex].FindControl("txtFName") as TextBox;
            TextBox middleName = lvUserList.Items[e.ItemIndex].FindControl("txtMName") as TextBox;
            TextBox lastName = lvUserList.Items[e.ItemIndex].FindControl("txtLName") as TextBox;
            TextBox primaryEmailId = lvUserList.Items[e.ItemIndex].FindControl("txtPREmailId") as TextBox;
            TextBox secondaryEmailId = lvUserList.Items[e.ItemIndex].FindControl("txtSCEmailId") as TextBox;
            TextBox mobileNo = lvUserList.Items[e.ItemIndex].FindControl("txtMobileNo") as TextBox;
            TextBox address1 = lvUserList.Items[e.ItemIndex].FindControl("txtAddress1") as TextBox;
            TextBox address2 = lvUserList.Items[e.ItemIndex].FindControl("txtAddress2") as TextBox;
            TextBox street = lvUserList.Items[e.ItemIndex].FindControl("txtStreet") as TextBox;
            TextBox city = lvUserList.Items[e.ItemIndex].FindControl("txtCity") as TextBox;
            TextBox state1 = lvUserList.Items[e.ItemIndex].FindControl("txtState1") as TextBox;
            TextBox country = lvUserList.Items[e.ItemIndex].FindControl("txtCountry") as TextBox;
            TextBox secretQuest = lvUserList.Items[e.ItemIndex].FindControl("txtSecretQuest") as TextBox;//?
            TextBox secretAns = lvUserList.Items[e.ItemIndex].FindControl("txtSecretAns") as TextBox;
            TextBox Pass = lvUserList.Items[e.ItemIndex].FindControl("txtPass") as TextBox;//?
            
           
            
            user.UserId = Convert.ToInt32(UserId);
            user.UserName = userName.Text;
            user.FirstName = firstName.Text;
            user.MiddleName = middleName.Text;
            user.LastName = lastName.Text;
            user.PrimaryEmailId = primaryEmailId.Text;
            user.SecondaryEmailId = secondaryEmailId.Text;
            user.MobileNo = mobileNo.Text;
            user.Address1 = address1.Text;
            user.Address2 = address2.Text;
            user.Street = street.Text;
            user.City = city.Text;
            user.State1 = state1.Text;
            user.Country = country.Text;
            user.SecretQuest = secretQuest.Text;
            user.SecretAns = secretAns.Text;
            user.EncPass = commonBAL.Encrypt( Pass.Text,false);
            
            if (userBAL.Modify(user))
            {
                lvUserList.EditIndex = -1;
                bindLVUser();
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Record Successfully Updated.", true);
            }
            else
            {
                LoggedIn master = (LoggedIn)this.Master;
                master.ShowMessage("Unsuccessful",false);
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
                bindLVUser();
            }
        }
       
    }
}