using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DOAN_QLTUYENSINHDH.Class_HeThong;
using DevComponents.DotNetBar;

namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    public partial class FrmDanhSBD : DevComponents.DotNetBar.Office2007Form
    {
        public FrmDanhSBD()
        {
            InitializeComponent();
        }
        ThiSinh ac = new ThiSinh();
        KetNoi kn = new KetNoi();
        private void laycmb()
        {
        string sql ="select distinct namthi from thisinh";
            cmbnam.DataSource = kn.Laycsdl(sql);
            cmbnam.DisplayMember = "namthi";
        }
        private void FrmDanhSBD_Load(object sender, EventArgs e)
        {
            laycmb();

            string sql = "SELECT id  ,'SDK'+'A' + replace(str(row_number() over(order by tents),4),' ','0') as sbd ,hots ,tents ,ngaysinh , namthi from thisinh";
            gridhienthi.DataSource = kn.Laycsdl(sql);
        }

       

        private void btndanhsbd_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Lưu ý sau khi thực hiện chức năng này số báo danh sẽ bị thay đổi \n Bạn thực sự muốn thực hiện??", "Kiểm tra lại thông tin trước khi đánh SBD", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // sắp xếp trước theo tên thí sinh - và chọn năm tuyển sinh
                string sql = "SELECT id,'SDKA' + replace(str(row_number() over(order by tents),4),' ','0') as sbd ,hots ,tents ,ngaysinh , namthi from thisinh where namthi ='" + cmbnam.Text + "'";
                gridhienthi.DataSource = kn.Laycsdl(sql);
                // kiểm tra năm thi đã có chưa
                //int id = gridhienthi.Rows.Count;
                //if (id == 0)
                //{
                //    MessageBoxEx.Show("Năm thi này chưa có thí sinh dự thi!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                    // sau đó đánh số báo danh

                    ac.Danhsobd(gridhienthi , cmbnam.Text);
            }
        }
    }
} 