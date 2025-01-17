using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DOAN_QLTUYENSINHDH.Class_HeThong;

namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    public partial class FrmTkDiem : DevComponents.DotNetBar.Office2007Form
    {
        public FrmTkDiem()
        {
            InitializeComponent();
        }
        KetNoi ac = new KetNoi();
        public void hienthinam()
        {

            string sql = "select  distinct namthi as nam from phongthi";
            cmbnam.DataSource = ac.Laycsdl(sql);
            cmbnam.DisplayMember = "nam";

        }
        public void htcsdl()
        {
            string sql = "select sobd , hovaten, tendt, gioitinh,  ngaysinh,toan, ly, hoa, tongdiem,tongdiemcong from view_tongdiem_cong where namthi='" + cmbnam.Text + "' ORDER BY sobd";
            ac.HienThiLuoi(sql, gridhienthi, bdndieukhien);
        }
        private void FrmTkDiem_Load(object sender, EventArgs e)
        {
            hienthinam();
            htcsdl();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtnhap.Text == "")
            {
                htcsdl();
            }
            else
            {
                string sql = "select sobd , hovaten, tendt, gioitinh, ngaysinh, toan, ly, hoa, tongdiem,tongdiemcong from view_tongdiem_cong where (hovaten like N'%" + txtnhap.Text + "%' and namthi ='" + cmbnam.Text + "') or (sobd ='" + txtnhap.Text + "' and namthi ='" + cmbnam.Text + "') ";
                ac.HienThiLuoi(sql, gridhienthi, bdndieukhien);
            }
        }

        private void cmbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            htcsdl();
        }

        private void txtnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonX1.PerformClick();
            }
        }
        
    }
}