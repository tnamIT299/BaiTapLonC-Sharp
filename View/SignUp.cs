using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_demo.View
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_password.Text == "" && txt_email.Text == "")
            {
                MessageBox.Show("Please fill ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                HomeManage homeManage = new HomeManage();
                homeManage.Show();
                Hide();
            }
        }
    }
}
