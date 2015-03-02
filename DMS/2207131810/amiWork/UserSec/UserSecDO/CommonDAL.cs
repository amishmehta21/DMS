using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace UserSecDAL
{
   public class CommonDAL
    {

       public SqlConnection Connection()
       {
           SqlConnection con = new SqlConnection("data source =kalyani\\SQLEXPRESS; initial catalog=UserMgmt; integrated security=true");
           return con;

       }

       public string Encrypt(string toEncrypt, bool useHashing)
       {
           byte[] keyArray;
           byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

           // System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
           // Get the key from config file
           //   string key = (string)settingsReader.GetValue("rakhicrypto", typeof(String));
           string key = "1234567890123456";
           //System.Windows.Forms.MessageBox.Show(key);
           if (useHashing)
           {
               MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
               keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
               hashmd5.Clear();
           }
           else
               keyArray = UTF8Encoding.UTF8.GetBytes(key);

           TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
           tdes.Key = keyArray;
           tdes.Mode = CipherMode.ECB;
           tdes.Padding = PaddingMode.PKCS7;

           ICryptoTransform cTransform = tdes.CreateEncryptor();
           byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
           tdes.Clear();
           return Convert.ToBase64String(resultArray, 0, resultArray.Length);
       }
       /// <summary>
       /// DeCrypt a string using dual encryption method. Return a DeCrypted clear string
       /// </summary>
       /// <param name="cipherString">encrypted string</param>
       /// <param name="useHashing">Did you use hashing to encrypt this data? pass true is yes</param>
       /// <returns></returns>
       public string Decrypt(string cipherString, bool useHashing)
       {
           byte[] keyArray;
           byte[] toEncryptArray = Convert.FromBase64String(cipherString);

           // System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
           //Get your key from config file to open the lock!
           //string key = (string)settingsReader.GetValue("rakhicrypto", typeof(String));
           string key = "1234567890123456";
           if (useHashing)
           {
               MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
               keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
               hashmd5.Clear();
           }
           else
               keyArray = UTF8Encoding.UTF8.GetBytes(key);

           TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
           tdes.Key = keyArray;
           tdes.Mode = CipherMode.ECB;
           tdes.Padding = PaddingMode.PKCS7;

           ICryptoTransform cTransform = tdes.CreateDecryptor();
           byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

           tdes.Clear();
           return UTF8Encoding.UTF8.GetString(resultArray);
       }

    }
}
