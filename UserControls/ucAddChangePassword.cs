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
    public partial class ucAddChangePassword : UserControl
    {
        public ucAddChangePassword()
        {
            InitializeComponent();
        }

        private void btnAddOrChange_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAppName.Text) || string.IsNullOrWhiteSpace(txtAppPassword.Text))
            {
                MessageBox.Show("الرجاء ادخال الحقول !", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPasswordManger PasswordManger = new clsPasswordManger(txtAppName.Text.Trim(),txtAppPassword.Text.Trim());

            PasswordManger.AddOrChangePass();

            MessageBox.Show("تم بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAppName.Clear();
            txtAppPassword.Clear();
            txtAppName.Focus();

        }

        
    }
}
