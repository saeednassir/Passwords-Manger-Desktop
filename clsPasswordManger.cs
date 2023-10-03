using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsManager_Desktop
{
    public class clsPasswordManger
    {

        private string _AppName;

        private string _AppPassword;

        public clsPasswordManger(string AppName, string Password)
        {
            _AppName = AppName;
            _AppPassword = Password;
        }

        public string GetAppName()
        {
            return _AppName;
        }

        public void SetAppName(string AppName)
        {
            _AppName = AppName;
        }

        public string GetAppPassword()
        {
            return _AppPassword;
        }

        public void SetAppPassword(string Password)
        {
            _AppPassword = Password;
        }

        private string _ConvertObjectToLine(clsPasswordManger passwordManger, string Seperator = "#//#")
        {
            string RecourdLine = "";

            RecourdLine += passwordManger.GetAppName() + Seperator;
            RecourdLine += clsUtilty.Encrypt(passwordManger.GetAppPassword());

            return RecourdLine;
        }

        private void _Add()
        {
            StreamWriter writer = new StreamWriter("Passwords.txt", true, Encoding.UTF8);

            writer.WriteLine(_ConvertObjectToLine(this));

            writer.Close();

        }

        private void _Update()
        {
            List<clsPasswordManger> ListPass = ListPasswords();

            foreach (clsPasswordManger Pass in ListPass)
            {
                if (Pass.GetAppName() == _AppName)
                {
                    Pass.SetAppPassword(_AppPassword);
                    break;
                }
            }

            _Save(ListPass);

        }

        private static clsPasswordManger _ConvertLineToObject(string Line, string Seperator = "#//#")
        {
            string[] sep = new string[1];

            sep[0] = Seperator;

            string[] AppData = Line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            clsPasswordManger App = new clsPasswordManger(AppData[0], clsUtilty.Decrypt(AppData[1]));

            return App;
        }

        private void _Save(List<clsPasswordManger> ListPasswords)
        {
            StreamWriter writer = new StreamWriter("Passwords.txt", false, Encoding.UTF8);

            foreach (clsPasswordManger pass in ListPasswords)
            {
                writer.WriteLine(_ConvertObjectToLine(pass));
            }

            writer.Close();
        }

        public static bool IsExist(string AppName)
        {
            if (Find(AppName) == null)
                return false;
            else
                return true;
        }

        public static List<clsPasswordManger> ListPasswords()
        {
            List<clsPasswordManger> ListPass = new List<clsPasswordManger>();

            StreamReader reader = new StreamReader("Passwords.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {
                ListPass.Add(_ConvertLineToObject(Line));
            }

            reader.Close();

            return ListPass;
        }
        public void AddOrChangePass()
        {
            if (IsExist(_AppName))
                _Update();
            else
                _Add();
        }

        public static clsPasswordManger Find(string AppName)
        {
            StreamReader reader = new StreamReader("Passwords.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {
                clsPasswordManger App = _ConvertLineToObject(Line);

                if (App.GetAppName().ToLower() == AppName.ToLower())
                {
                    reader.Close();
                    return App;
                }

            }
            reader.Close();
            return null;
        }

        public bool Delete()
        {
            int counter = 0;

            List<clsPasswordManger> ListPass = ListPasswords();

            foreach (clsPasswordManger Pass in ListPass)
            {
                if (_AppName == Pass.GetAppName())
                {
                    ListPass.RemoveAt(counter);
                    break;
                }

                counter++;
            }

            _Save(ListPass);

            return true;

        }

    }
}
