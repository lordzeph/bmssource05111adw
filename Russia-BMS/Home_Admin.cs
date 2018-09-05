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
    public partial class Home_Admin : Form
    {
        public Home_Admin()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Admin_Load(object sender, EventArgs e)
        {
            Dinero.Font = new Font("DINPro-Bold", 12, FontStyle.Regular);

            label4.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            label5.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            label6.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
            label7.Font = new Font("DINPro-Bold", 10, FontStyle.Regular);
        }
    }
}
