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
    public partial class HomeManage : Form
    {
       
        public HomeManage()
        {
            InitializeComponent();
           
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pane_HomeManage.Controls.Add(childForm);
            pane_HomeManage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pane_DashBoard_Paint(object sender, PaintEventArgs e)
        {
            openChildForm(new DashBoard());
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
           openChildForm(new DashBoard());
        }

        private void btn_Prodcut_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff());
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            openChildForm(new Customer());
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            Hide();
        }
    }
}
