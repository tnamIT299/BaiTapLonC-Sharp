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
    }
}
