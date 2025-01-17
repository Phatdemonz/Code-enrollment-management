using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DOAN_QLTUYENSINHDH.Class_HeThong;
using System.Data.SqlClient;
using Microsoft.Office.Interop;
using System.Data.OleDb;


namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    public partial class FrmNamThi_Cu : Office2007Form
    {
       
        public FrmNamThi_Cu()
        {
            InitializeComponent();
        }

        NamThi ac = new NamThi();
     
        
        private void FrmNamThi_Load(object sender, EventArgs e)
        {
            ac.HienThi(dgvNamHoc, bdndieukhien);
           
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvNamHoc.Rows)
            {
                if (row.Cells[cell].Value != null)
                {
                    String str = row.Cells[cell].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Giá trị ô không được rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private void bdluulai_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("ma") == true && KiemTraTruocKhiLuu("namthi") == true)
            {
              

                ac.Them(dgvNamHoc);
               
                ac.HienThi(dgvNamHoc, bdndieukhien);


            }
        }
       

        private void btnxoa_Click(object sender, EventArgs e)
        {

            int dong = dgvNamHoc.SelectedRows.Count;
            if (dgvNamHoc.RowCount == 0)
                btnxoa.Enabled = false;
            else if (dong == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn dòng cần xóa", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    ac.Xoa(dgvNamHoc);

                ac.HienThi(dgvNamHoc, bdndieukhien);
            }

        }

        private void bdload_Click(object sender, EventArgs e)
        {
            ac.CapNhat(dgvNamHoc);
         
           ac.HienThi(dgvNamHoc, bdndieukhien);

        }

        private void dgvNamHoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBoxEx.Show("Dữ liệu nhập vào phải là số nguyên\nĐộ dài 4 kí tự", " Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bdthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy dữ liệu lên các điều khiển textbox , combobox
           //tebox.text= dgvNamHoc.CurrentRow.Cells[0].Value.ToString();

            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    txtName.Text = Convert.ToString(dgvDeparts.CurrentRow.Cells["clName"].Value);
            //    txtDescription.Text = Convert.ToString(dgvDeparts.CurrentRow.Cells["clDescription"].Value);
            //}
           
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
           
            int dong = dgvNamHoc.SelectedRows.Count;
            if (dgvNamHoc.RowCount == 0)
                btnxoa.Enabled = false;
            else if (dong == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn dòng cần xóa", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                ac.Xoa(dgvNamHoc);
                  
                ac.HienThi(dgvNamHoc, bdndieukhien);
            }

            // xóa nhiều dòng
            //int dong = dgvNamHoc.SelectedRows.Count;
            //if (dong == 0)
            //{
            //    MessageBoxEx.Show("Bạn phải chọn dòng cần xóa", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //else
            //{
            //    foreach (DataGridViewRow row in dgvNamHoc.SelectedRows)
            //    {
            //        if (!row.IsNewRow)
            //        {
            //           dgvNamHoc.Rows.Remove(row);
                       
            //        }
            //    }
            //}

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {

              bdndieukhien.BindingSource.AddNew();
                dgvNamHoc.Rows[dgvNamHoc.Rows.Count - 1].Cells[0].Value = ac.MaTieptheo(dgvNamHoc);
               
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

            
            if (KiemTraTruocKhiLuu("ma") == true && KiemTraTruocKhiLuu("namthi") == true)
            {


                ac.Them(dgvNamHoc);

                ac.HienThi(dgvNamHoc, bdndieukhien);


            }
        }

        private void bdnthem_Click(object sender, EventArgs e)
        {
            dgvNamHoc.Rows[dgvNamHoc.Rows.Count - 1].Cells[0].Value = ac.MaTieptheo(dgvNamHoc);
           
        }


      
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            KetNoi kn = new KetNoi();
           
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
          
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ac.Excel_Nhap(dlg.FileName);
               // kn.Excel_Nhap(dlg.FileName, "ma", "insert into namthi values(
            }
        
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            ac.CapNhat(dgvNamHoc);
           
            ac.HienThi(dgvNamHoc, bdndieukhien);
            
        }

      

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                ac.Excel_Xuat(save.FileName.ToString(), dgvNamHoc);
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}