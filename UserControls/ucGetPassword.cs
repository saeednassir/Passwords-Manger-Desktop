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
    public partial class ucGetPassword : UserControl
    {
        public ucGetPassword()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAppName.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم التطبيق !","الحقل فارغ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsPasswordManger App = clsPasswordManger.Find(txtAppName.Text.Trim());

            if (App == null)
            {
                MessageBox.Show("التطبيق غير موجود !", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPassword.Visible = false;
                lblValuePassword.Visible = false;
                return;
            }

            lblValuePassword.Text = App.GetAppPassword();

            lblPassword.Visible = true;
            lblValuePassword.Visible = true;

        }
    }
}
