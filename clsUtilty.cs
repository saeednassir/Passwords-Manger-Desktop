using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordsManager_Desktop
{
    public class clsUtilty
    {
        private static readonly string _orignalChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#$";
        private static readonly string _altChars     = "F@2bDHi4YVQu7TUxhKfsq6tkX$Wl10ZNy9BnSAPIvjgmw3CrzR#eLEdJ5caO8MGop";

        public static string Encrypt(string Password)
        {
            string str = "";

            foreach(char ch in Password)
            {
                str += _altChars[_orignalChars.IndexOf(ch)];
            }

            return str;
        }

        public static string Decrypt(string Password)
        {
            string str = "";

            foreach(char ch in Password)
            {
                str += _orignalChars[_altChars.IndexOf(ch)];
            }

            return str;
        }

    }
}
