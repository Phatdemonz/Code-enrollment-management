using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DOAN_QLTUYENSINHDH
{
    public partial class FrmHenGio : Office2007Form
    {
        public FrmHenGio()
        {
            InitializeComponent();
        }

        private void FrmHenGio_Load(object sender, EventArgs e)
        {

        }
        int soGiayTatMay;
        private void buttonX1_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(txtnhap.Text.Trim(), out soGiayTatMay))
            {
                buttonX1.Enabled = false;
                timer1.Interval = 1000;
                timer1.Enabled = true;
                soGiayTatMay = Math.Abs(soGiayTatMay) * 60;
                
            }
            
            else
            {
                MessageBox.Show("Hãy nhập vào số phút cần hẹn.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (soGiayTatMay > 0)
            {
                lblht.Text = "Sẽ tắt máy sau " + soGiayTatMay + " giây.";
                soGiayTatMay = soGiayTatMay - 1;
            }
            else
            {
               System.Diagnostics.Process.Start("shutdown", "/s /f /t 0");
                
                Application.Exit();
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = false;
            
            this.Close();
        }

        private void lblht_Click(object sender, EventArgs e)
        {

        }

        private void txtnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}