using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// thư viện thêm
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using DOAN_QLTUYENSINHDH.Class_HeThong;

namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    public partial class FrmKhuVuc : Office2007Form
    {
        public FrmKhuVuc()
        {
            InitializeComponent();
        }
        // khai báo 
        KetNoi kn = new KetNoi();

        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        // lấy csdl vào gridview
        private void loadcsdl()
        {try{
            con = kn.laykn();
            con.Open();
            da = new SqlDataAdapter("select * from khuvuc", con);
            da.Fill(dt);

            dgvHienThi.DataSource = dt;

            // Ràng buộc dữ liệu vào BindingSource 
            bs.DataSource = dt;

            // Gán nguồn dữ liệu cho DataGridView 
            dgvHienThi.DataSource = bs;
            // gán nguồn dữ liệu cho bindingsource
            bdndieukhien.BindingSource = bs;
        }
        catch { }
        }
        private void FrmKhuVuc_Load(object sender, EventArgs e)
        {
            loadcsdl();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn lưu lại những thông tin vừa thay đổi?", "Question ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dgvHienThi.DataSource = dt;
                    dt = (DataTable)dgvHienThi.DataSource;
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(dt);

                    MessageBoxEx.Show("Lưu Lại thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Cannot insert duplicate key"))
                {
                    MessageBoxEx.Show("Mã khu vực đã tồn tại!", "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("Cannot insert the value NULL"))
                {
                    MessageBoxEx.Show("Mã khu vực không được bỏ trống!", "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBoxEx.Show("Lỗi : " + ex.Message, "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = bs;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = bs;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = bs;
            bdndieukhien.BindingSource.AddNew();
        }

        private void buttonItem29_Click(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = bs;
            bdndieukhien.BindingSource.RemoveCurrent();
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHienThi.DataSource = dt;
                dt = (DataTable)dgvHienThi.DataSource;
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(dt);

                MessageBoxEx.Show("Lưu Lại thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Cannot insert duplicate key"))
                {
                    MessageBoxEx.Show("Mã khu vực đã tồn tại!", "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("Cannot insert the value NULL"))
                {
                    MessageBoxEx.Show("Mã khu vực không được bỏ trống!", "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBoxEx.Show("Lỗi : " + ex.Message, "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void buttonItem32_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void dgvHienThi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBoxEx.Show("Vui lòng xem lại giá trị nhập vào", " Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
        }

        private void dgvHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}