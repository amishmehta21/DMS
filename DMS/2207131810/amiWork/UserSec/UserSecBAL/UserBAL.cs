using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserSecDAL;
using UserSecBE;
using System.Data;
using System.Text.RegularExpressions;

namespace UserSecBAL
{
    public class UserBAL
    {

        #region Methods

        public bool GetAllUserDetails(ref DataTable dt)
        {
            UserDAL userDAL = new UserDAL();

            if (userDAL.GetAllUserDetails(ref dt))
                return true;
            else
                return false;
        }
        public bool Delete(UserBE user)
        {
            UserDAL userDAL = new UserDAL();
            if (userDAL.Delete(user))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modify(UserBE user)
        {
            UserDAL userDAL = new UserDAL();
            if (userDAL.Modify(user))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ViewUser(UserBE viewuser)
        {
            UserDAL userDAL = new UserDAL();
            if (userDAL.ViewUser(viewuser))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PasswordChange()
        {
        }
        public void PasswordForgot()
        {
        }
        public bool Validate(ref UserBE user)
        {
            UserDAL userDAL = new UserDAL();

            if (userDAL.Validate(ref user))
                return true;
            else
                return false;
        }


        public bool AddUser(UserBE addUserBE)
        {
            UserDAL userDAL = new UserDAL();
            if (userDAL.AddUser(addUserBE))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateData(UserBE user)
        {
            //Check required fields 
            // Check specific field wise check - email, phone, country,...

            Regex re = new Regex("^[0-9]{10}");

            if (re.IsMatch(user.MobileNo.Trim()) == false || user.MobileNo.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }

            Regex rex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (rex.IsMatch(user.PrimaryEmailId.Trim()) == false || user.PrimaryEmailId.Length > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion Methods
    }
}
