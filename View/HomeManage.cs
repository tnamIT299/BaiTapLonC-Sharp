using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BTL_demo.View
{
    public partial class HomeManage : Form
    {
        private Timer timer;

        public HomeManage()
        {
            InitializeComponent();
            // Khởi tạo Timer và cài đặt thời gian là 1 giây
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            // Bắt đầu chạy Timer
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Hiển thị thời gian trong Label hoặc TextBox (vd: lblClock.Text = currentTime.ToString("HH:mm:ss");)
            // Ví dụ: hiển thị thời gian dạng "Giờ:Phút:Giây"
            lbClock.Text = currentTime.ToString("dddd,HH:mm:ss");
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

        private void lbClock_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
       
        
    }
}
