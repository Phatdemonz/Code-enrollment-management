using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// thư viện thêm
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Data.SqlClient;
using DOAN_QLTUYENSINHDH.Class_HeThong;

namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    public partial class FrmDanToc : Office2007Form
    {
        public FrmDanToc()
        {
            InitializeComponent();
        } 
        // khai báo 
        KetNoi kn = new KetNoi();

        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
      

        private void FrmDanToc_Load(object sender, EventArgs e)
        {
            con = kn.laykn();
            con.Open();
            da = new SqlDataAdapter("select * from dantoc", con);
            da.Fill(dt);

            dgvDanToc.DataSource = dt;

            // Ràng buộc dữ liệu vào BindingSource 
            bs.DataSource = dt;

            // Gán nguồn dữ liệu cho DataGridView 
            dgvDanToc.DataSource = bs;
            // gán nguồn dữ liệu cho bindingsource
            bdndieukhien.BindingSource = bs;
          


        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn lưu lại những thông tin vừa thay đổi?", "Question ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dgvDanToc.DataSource = dt;
                    dt = (DataTable)dgvDanToc.DataSource;
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(dt);
                    MessageBoxEx.Show("Lưu Lại thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Lỗi : "+ ex.Message, "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            dgvDanToc.DataSource = bs;

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            dgvDanToc.DataSource = bs;

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            dgvDanToc.DataSource = bs;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            dgvDanToc.DataSource = bs;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dgvDanToc.DataSource = bs;
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            dgvDanToc.DataSource = bs;
            // xóa nhiều dòng

            foreach (DataGridViewRow row in dgvDanToc.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dgvDanToc.Rows.Remove(row);

                }
            }
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            bdndieukhien.BindingSource.AddNew();
            dgvDanToc.DataSource = bs;

        }

        private void buttonItem29_Click(object sender, EventArgs e)
        {
            dgvDanToc.DataSource = bs;
            // xóa nhiều dòng

            foreach (DataGridViewRow row in dgvDanToc.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dgvDanToc.Rows.Remove(row);

                }
            }
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn lưu lại những thông tin vừa thay đổi?", "Question ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dgvDanToc.DataSource = dt;
                    dt = (DataTable)dgvDanToc.DataSource;
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(dt);
                    MessageBoxEx.Show("Lưu Lại thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Lỗi : " + ex.Message, "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void buttonItem32_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        

        
    }
}