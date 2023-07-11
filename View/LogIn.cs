using BTL_demo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_demo
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.txt_username.SelectAll();
            this.txt_password.SelectAll();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            txt_username.SelectAll();

        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.SelectAll();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            if (txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Please fill username and password!","Error", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
              
            }
            else
            {
                HomeManage homeManage = new HomeManage();
                homeManage.Show();
                Hide();
            }
        }

      

        private void cb_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = cb_show_pass.Checked ? '\0' : '*';
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e){}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            Hide();
        }

        private void btn_forgetPass_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
            Hide();
        }
    }
}
