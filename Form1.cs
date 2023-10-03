using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsManager_Desktop
{
    public partial class Form1 : Form
    {

        

        ucAddChangePassword ucAddChangePassword = new ucAddChangePassword();

        ucGetPassword ucGetPassword = new ucGetPassword();

        ucDeletePassword ucDeletePassword = new ucDeletePassword();

        public Form1()
        {
            InitializeComponent();

            ucListPasswords ucListPasswords = new ucListPasswords();

            addUserControl(ucListPasswords);
        }

        void addUserControl(UserControl userControl)
        {
            if(userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(userControl);
                userControl.BringToFront();
            }
        }

        private void btnListPasswords_Click(object sender, EventArgs e)
        {
            ucListPasswords ucListPasswords = new ucListPasswords();

            addUserControl(ucListPasswords);
        }

        private void btnAddChangePassword_Click(object sender, EventArgs e)
        {
            addUserControl(ucAddChangePassword);
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            addUserControl(ucGetPassword);
        }

        private void btnDeletePassword_Click(object sender, EventArgs e)
        {
            addUserControl(ucDeletePassword);
        }

        private void pcMinemum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
