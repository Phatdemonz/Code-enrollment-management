/*
 * Quản lý các chức năng về người dùng trong hệ thống
 */
using System;
using System.Collections.Generic;
using System.Text;
// khai báo thêm thư viện 
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace DOAN_QLTUYENSINHDH.Class_HeThong
{
    class QuyenNSD
    { 
        //khai báo 
        KetNoi kn = new KetNoi();
        SqlConnection conn;

        public void Themnsd(DataGridViewX dgv, string taikhoan, string matkhau, string quyen, string quenmk)
        {
           
            conn = kn.laykn();

            SqlCommand cmd = new SqlCommand("Insert into dangnhap(taikhoan,matkhau,quyen,quenmk) values(@taikhoan ,@matkhau , @quyen,@quenmk )", conn);
            cmd.Parameters.Add("taikhoan", SqlDbType.NVarChar).Value = taikhoan ;
            cmd.Parameters.Add("matkhau", SqlDbType.NVarChar).Value = matkhau;
            cmd.Parameters.Add("quyen", SqlDbType.NVarChar).Value = quyen ;
            cmd.Parameters.Add("quenmk",SqlDbType.NVarChar).Value = quenmk;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd.ExecuteNonQuery();
            conn.Close();
            
        }
        public void Capnhatnsd(DataGridViewX dgv, string taikhoan, string matkhau, string quyen, string quenmk)
        {
            conn = kn.laykn();
             SqlCommand cmd = new SqlCommand("Update dangnhap set matkhau =@matkhau ,quyen = @quyen , quenmk = @quenmk where taikhoan =@taikhoan", conn);
             cmd.Parameters.Add("taikhoan", SqlDbType.NVarChar).Value = taikhoan;
             cmd.Parameters.Add("matkhau", SqlDbType.NVarChar).Value = matkhau;
             cmd.Parameters.Add("quyen", SqlDbType.NVarChar).Value = quyen;
             cmd.Parameters.Add("quenmk", SqlDbType.NVarChar).Value = quenmk;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd.ExecuteNonQuery();
            
            conn.Close(); 
        }
        public void Xoansd(DataGridViewX dgv, string  taikhoan)
        {
            conn = kn.laykn();

           SqlCommand cmd = new SqlCommand("Delete from dangnhap  where taikhoan =@taikhoan", conn);
           cmd.Parameters.Add("taikhoan", SqlDbType.NVarChar).Value = taikhoan;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd.ExecuteNonQuery();

            conn.Close();

        }
    }
}
