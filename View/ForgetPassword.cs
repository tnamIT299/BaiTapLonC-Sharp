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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            Hide();
        }

        private void txt_otp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_newpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cfpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_otp_Click(object sender, EventArgs e)
        {

        }
    }
}
