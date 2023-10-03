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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAppPassword.Text))
            {
                MessageBox.Show("الرجاء إدخال كلمة المرور !", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPasswordManger MyApp = clsPasswordManger.Find("MASTER");

            if (MyApp == null)
            {
                clsPasswordManger Master = new clsPasswordManger("MASTER", txtAppPassword.Text);

                Master.AddOrChangePass();

                Form frm = new Form1();

                frm.Show();
                this.Hide();
            }
            else
            {
                if (MyApp.GetAppPassword() == txtAppPassword.Text)
                {
                    Form frm = new Form1();

                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("كلمة المرور خاطئة !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAppPassword.Clear();
                    txtAppPassword.Focus();
                }
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
