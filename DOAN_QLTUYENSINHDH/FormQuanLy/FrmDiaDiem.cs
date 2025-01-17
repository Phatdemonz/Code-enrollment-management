using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DOAN_QLTUYENSINHDH.Class_HeThong;
using System.Data.SqlClient;

namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    public partial class FrmDiaDiem : Office2007Form
    
    {
        public FrmDiaDiem()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        ThiSinh ts = new ThiSinh();
        private void loadcsdl()
        {
            kn.HienThiLuoi("select madd,tendd,phong,namthi from diadiem where namthi='"+cmbnam.Text+"'",dgvHienThi,bdndieukhien);
        }
        public void hienthiphong()
        {

            string sql = "select distinct sophongthi as phong from phongthi where namthi='" + cmbnam.Text + "'";
            cmbphong.DataSource = kn.Laycsdl(sql);
            cmbphong.DisplayMember = "phong";
        }
        public void hienthinam()
        {

            string sql = "select  distinct namthi as nam from phongthi";
            cmbnam.DataSource = kn.Laycsdl(sql);
            cmbnam.DisplayMember = "nam";

        }
        private void FrmDiaDiem_Load(object sender, EventArgs e)
        {
            hienthinam();
            hienthiphong();
            loadcsdl();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienthiphong();
            loadcsdl();
        }

        

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txttenphong.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa tên phòng");
                txttenphong.Focus();

            }
            else if(kiemtratontai())
            {
             MessageBoxEx.Show("Đã tồn tại phòng thi này ");
            }
            else
            {
                try
                {
                    // thêm
                    ts.Them_dd(dgvHienThi,txttenphong.Text ,cmbnam.Text , cmbphong.Text );
                    loadcsdl();
                    MessageBoxEx.Show("Thêm thành công !", "Successfully ....", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {                   
                        MessageBoxEx.Show("Lỗi : " + ex.Message, "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }            

        }
        public bool kiemtratontai()
        {
            SqlConnection conn = kn.laykn();
            bool kt = true;
            string sql ="select * from diadiem where namthi='"+cmbnam.Text+"' and phong='"+cmbphong.Text+"'";
            SqlDataAdapter ad = new SqlDataAdapter (sql,conn);
            DataTable dt = new DataTable ();
            ad.Fill(dt);
            if(dt.Rows.Count >0)
             {
             kt= true;
            }
            else
            {kt= false;
            }
            return kt;
        }
    
        private void dgvHienThi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                label1.Text = dgvHienThi.Rows[dong].Cells["madd"].Value.ToString();
                cmbnam.Text = dgvHienThi.Rows[dong].Cells["namthi"].Value.ToString();

                txttenphong.Text = dgvHienThi.Rows[dong].Cells["tendd"].Value.ToString();

                cmbphong.Text = dgvHienThi.Rows[dong].Cells["sophong"].Value.ToString();
            }
            catch
            { }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (txttenphong.Text == "")
            {
                MessageBoxEx.Show("chưa nhập tên phòng");
                txttenphong.Focus();
            }
            //else if (kiemtratontai())
            //{
            //    MessageBoxEx.Show("Đã tồn tại phòng thi này ");
            //}
            else
            {
                try
                {
                    ts.Capnhat_dd(dgvHienThi, txttenphong.Text, cmbnam.Text, cmbphong.Text, label1.Text);
                    loadcsdl();
                    MessageBoxEx.Show("Cập nhật thành công !", "Successfully ....", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {

                    MessageBoxEx.Show("Lỗi :" + ex.ToString(), "Đã có lỗi ....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn thực sự muốn xóa ?", "Question ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ts.Xoa_dd(dgvHienThi, label1.Text);
                    loadcsdl();
                    MessageBoxEx.Show("Xóa thành công !", "Successfully ....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Lỗi : " + ex.ToString(), "Đã có lỗi ....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}