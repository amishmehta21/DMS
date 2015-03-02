using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserSecDAL;
using UserSecBE;
using System.Data;
using System.Text.RegularExpressions;
using System.Net.Mail;

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
            string fromEmail = "Nazimniit@gmail.com";
            string toEmail = "nmansoori700@gmail.com";
            MailMessage message = new MailMessage(fromEmail, toEmail);
          //  message.Subject = txtSubject.Text;
          //  message.Body = txtBody.Text;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "sarahvsathe@gmail.com",
                Password = "jesus"
            };
            smtp.EnableSsl = true;
            smtp.Send(message);
           // Label1.Text = "Mail sent successfully";
        
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

        public bool UserAccessRight(UserBE user, ref DataTable dt)
        {
            UserDAL userDAL = new UserDAL();
            if(userDAL.UserAccessRight(user,ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Methods
    }
}
