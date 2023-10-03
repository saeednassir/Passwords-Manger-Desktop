using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsManager_Desktop
{
    public partial class ucListPasswords : UserControl
    {

        private int Counter = 0;


        public ucListPasswords()
        {
            InitializeComponent();
        }

        private void ucListPasswords_Load(object sender, EventArgs e)
        {
            List<clsPasswordManger> list = new List<clsPasswordManger>();

            list = clsPasswordManger.ListPasswords();

            Counter = list.Count;
            lblCount.Text = Counter.ToString();

            if (list.Count > 0)
            {
                DataGridViewApp.Rows.Add(list.Count);



                for (int i = 0; i < list.Count; i++)
                {

                    DataGridViewApp.Rows[i].Cells[0].Value = list[i].GetAppName();
                    DataGridViewApp.Rows[i].Cells[1].Value = list[i].GetAppPassword();

                }
            }

        }
    }
}
