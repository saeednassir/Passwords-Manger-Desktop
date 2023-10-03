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
    public partial class ucDeletePassword : UserControl
    {
        public ucDeletePassword()
        {
            InitializeComponent();
        }

        private clsPasswordManger App;

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAppName.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم التطبيق !", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            App = clsPasswordManger.Find(txtAppName.Text.Trim());

            if (App == null)
            {
                MessageBox.Show("التطبيق غير موجود !", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPassword.Visible = false;
                lblValuePassword.Visible = false;
                btnDelete.Visible = false;
                return;
            }

            lblValuePassword.Text = App.GetAppPassword();

            lblPassword.Visible = true;
            lblValuePassword.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            App.Delete();

            MessageBox.Show("تم الحدف بنجاح !", "تم الحدف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblPassword.Visible = false;
            lblValuePassword.Visible = false;
            btnDelete.Visible = false;
            txtAppName.Clear();
            txtAppName.Focus();
        }
    }
}
