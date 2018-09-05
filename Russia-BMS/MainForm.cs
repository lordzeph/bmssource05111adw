using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Russia_BMS
{
    public partial class MainForm : Form
    {
        bool maxstat = false;
        bool mouseDown = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuGauge1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maxstat = false;
            btnUsers.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnPanel.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnOperation.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnClients.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnPartners.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnUsers.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnCashRegister.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnReports.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnBalance.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnInsurance.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnNotification.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnPrices.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            btnBackup.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            
            Home_Admin myForm = new Home_Admin();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.LoadingPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Left = this.Left + e.X;
                this.Top = this.Top + e.Y;
            }
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LoadingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_Admin myForm = new Home_Admin();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.LoadingPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation myForm = new Operation();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.LoadingPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void panel7_DoubleClick(object sender, EventArgs e)
        {
            if (maxstat)
            {
                this.WindowState = FormWindowState.Normal;
                maxstat = false;
            }
            else if (maxstat == false)
            {
                this.WindowState = FormWindowState.Maximized;
                maxstat = true;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            LoadingPanel.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Home_Seller myForm = new Home_Seller();
            //myForm.TopLevel = false;
            //myForm.AutoScroll = true;
            //this.LoadingPanel.Controls.Add(myForm);
            //myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Partner myForm = new Partner();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.LoadingPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow lw = new LoginWindow();
            lw.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Partner myForm = new Partner();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.LoadingPanel.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
