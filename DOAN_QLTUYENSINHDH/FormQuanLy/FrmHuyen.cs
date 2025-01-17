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
using DevComponents.DotNetBar.Controls;

namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    public partial class FrmHuyen : Office2007Form
    {
        public FrmHuyen()
        {
            InitializeComponent();
        }
        // khai báo 
        KetNoi kn = new KetNoi();
        HT_Combobox cmb = new HT_Combobox();
        SqlConnection con;
        DataTable dt = new DataTable();
        SqlDataAdapter ad;
        BindingSource bs = new BindingSource();
        public DataTable HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            con = kn.laykn();
            DataTable dt = new DataTable();
             ad = new SqlDataAdapter("select * from huyen where matinh='" + cmbtinh.SelectedValue.ToString() + "' order by matinh", con);

            try
            {
                ad.Fill(dt);
                // Ràng buộc dữ liệu vào BindingSource
                bs.DataSource = dt;
                // Gán nguồn dữ liệu cho BindingSource
                bn.BindingSource = bs;
                // Gán nguồn dữ liệu cho DataGridView
                dgv.DataSource = bs;
            }
            catch
            {
                // MessageBoxEx.Show("Không thể truy vấn dữ liệu ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        
        private void FrmHuyen_Load(object sender, EventArgs e)
        {
            
            
            cmb.HienthiCBTinh(cmbtinh);
            
           HienThi(dgvHienThi, bdndieukhien);
        }

        private void cmbtinh_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            HienThi(dgvHienThi, bdndieukhien);
            

        }

        
       
        private bool kt = false;
        private void cmbtinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Escape)//Nếu người dùng bấm phím Backspace
            {
                cmbtinh.SelectedIndex = -1;
                cmbtinh.Text = "";
                kt = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                kt = true;
            }
            else kt = false;
        }

        private void cmbtinh_TextChanged(object sender, EventArgs e)
        {
            if (cmbtinh.Text != "" && !kt)
            {
                string s = cmbtinh.Text;
                int Index = cmbtinh.FindString(s);
                if (Index != -1)
                {
                    cmbtinh.SelectedIndex = Index;
                }
                // Chọn (bôi đen) phần text vừa thêm vào để
                // nó có thể được thay thế nếu người dùng kiếp tục gõ
                cmbtinh.SelectionStart = s.Length; //Vị trí bắt đầu bôi đen
                cmbtinh.SelectionLength = cmbtinh.Text.Length - cmbtinh.SelectionStart;// Độ dài phần bôi đen
            }
        }

        private void dgvHienThi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblid.Text = dgvHienThi.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtmahuyen.Text = dgvHienThi.Rows[e.RowIndex].Cells["mahuyen"].Value.ToString();
                txttenhuyen.Text = dgvHienThi.Rows[e.RowIndex].Cells["tenhuyen"].Value.ToString();

            }
            catch 
            {
                
                
            }
          
        }
        public bool kiemtratontai()
        {
            SqlConnection conn = kn.laykn();
            bool kt = true;
            string sql = "select * from huyen where matinh='" + cmbtinh.SelectedValue.ToString() + "' and mahuyen='" + txtmahuyen.Text + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                kt = true;
            }
            else
            {
                kt = false;
            }
            return kt;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmahuyen.Text == "")
                { MessageBoxEx.Show("Chưa nhập mã huyện"); }
                else if (txtmahuyen.Text == "")
                { MessageBoxEx.Show("Chưa nhập tên huyện"); }
                else if (kiemtratontai())
                {
                    MessageBoxEx.Show("Đã nhập mã huyện này");
                }
                else
                {

                    kn.thucthi("INSERT into huyen(matinh,mahuyen,tenhuyen) values ('" + cmbtinh.SelectedValue.ToString() + "' , '" + txtmahuyen.Text + "' , N'" + txttenhuyen.Text + "')");
                    MessageBoxEx.Show("Lưu Lại thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(dgvHienThi, bdndieukhien);

                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Lỗi : " + ex.Message, "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn thực sự muốn xóa ?", "Question ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    kn.thucthi("Delete from huyen where id='" + lblid.Text + "'");
                    MessageBoxEx.Show("Xóa thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(dgvHienThi, bdndieukhien);
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Lỗi : " + ex.Message, "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmahuyen.Text == "")
                { MessageBoxEx.Show("Chưa nhập mã huyện"); }
                else if (txtmahuyen.Text == "")
                { MessageBoxEx.Show("Chưa nhập tên huyện"); }
                else if (kiemtratontai())
                {
                    MessageBoxEx.Show("Đã nhập mã huyện này");
                }
                else
                {
                    kn.thucthi("Update  huyen set  tenhuyen= N'" + txttenhuyen.Text + "' where id ='" + lblid.Text + "'");
                    MessageBoxEx.Show("Cập nhật thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(dgvHienThi, bdndieukhien);
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show("Lỗi : " + ex.Message, "Có lỗi xảy ra... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            
            txtmahuyen.Text = "";
            txttenhuyen.Text = "";
            txtmahuyen.Focus();
        }
    }
}