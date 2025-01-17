namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    partial class FrmChiTietTS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietTS));
            this.gridhienthi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.mahoso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hokhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_ut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuvuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganhdk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcbaotin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridhienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // gridhienthi
            // 
            this.gridhienthi.AllowUserToAddRows = false;
            this.gridhienthi.AllowUserToDeleteRows = false;
            this.gridhienthi.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.gridhienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridhienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoso,
            this.sobd,
            this.hovaten,
            this.ngaysinh,
            this.gioitinh,
            this.matinh,
            this.mahuyen,
            this.cmt,
            this.hokhau,
            this.dantoc,
            this.dt_ut,
            this.khuvuc,
            this.nganhdk,
            this.namthi,
            this.dcbaotin,
            this.namtn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridhienthi.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridhienthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridhienthi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridhienthi.Location = new System.Drawing.Point(0, 0);
            this.gridhienthi.Name = "gridhienthi";
            this.gridhienthi.ReadOnly = true;
            this.gridhienthi.Size = new System.Drawing.Size(1054, 96);
            this.gridhienthi.TabIndex = 1;
            // 
            // mahoso
            // 
            this.mahoso.DataPropertyName = "mahoso";
            this.mahoso.HeaderText = "Mã Hồ Sơ";
            this.mahoso.Name = "mahoso";
            this.mahoso.ReadOnly = true;
            // 
            // sobd
            // 
            this.sobd.DataPropertyName = "sobd";
            this.sobd.HeaderText = "Số BD";
            this.sobd.Name = "sobd";
            this.sobd.ReadOnly = true;
            // 
            // hovaten
            // 
            this.hovaten.DataPropertyName = "hovaten";
            this.hovaten.HeaderText = "Họ và Tên";
            this.hovaten.Name = "hovaten";
            this.hovaten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // matinh
            // 
            this.matinh.DataPropertyName = "matinh";
            this.matinh.HeaderText = "Mã tỉnh";
            this.matinh.Name = "matinh";
            this.matinh.ReadOnly = true;
            // 
            // mahuyen
            // 
            this.mahuyen.DataPropertyName = "mahuyen";
            this.mahuyen.HeaderText = "Mã huyện";
            this.mahuyen.Name = "mahuyen";
            this.mahuyen.ReadOnly = true;
            // 
            // cmt
            // 
            this.cmt.DataPropertyName = "cmt";
            this.cmt.HeaderText = "Số CMT";
            this.cmt.Name = "cmt";
            this.cmt.ReadOnly = true;
            // 
            // hokhau
            // 
            this.hokhau.DataPropertyName = "hokhau";
            this.hokhau.HeaderText = "Hộ khẩu";
            this.hokhau.Name = "hokhau";
            this.hokhau.ReadOnly = true;
            // 
            // dantoc
            // 
            this.dantoc.DataPropertyName = "dantoc";
            this.dantoc.HeaderText = "Dân Tộc";
            this.dantoc.Name = "dantoc";
            this.dantoc.ReadOnly = true;
            // 
            // dt_ut
            // 
            this.dt_ut.DataPropertyName = "dt_ut";
            this.dt_ut.HeaderText = "Đối tượng UT";
            this.dt_ut.Name = "dt_ut";
            this.dt_ut.ReadOnly = true;
            // 
            // khuvuc
            // 
            this.khuvuc.DataPropertyName = "khuvuc";
            this.khuvuc.HeaderText = "Khu Vực";
            this.khuvuc.Name = "khuvuc";
            this.khuvuc.ReadOnly = true;
            // 
            // nganhdk
            // 
            this.nganhdk.DataPropertyName = "nganhdk";
            this.nganhdk.HeaderText = "Ngành Thi";
            this.nganhdk.Name = "nganhdk";
            this.nganhdk.ReadOnly = true;
            // 
            // namthi
            // 
            this.namthi.DataPropertyName = "namthi";
            this.namthi.HeaderText = "Năm Thi";
            this.namthi.Name = "namthi";
            this.namthi.ReadOnly = true;
            // 
            // dcbaotin
            // 
            this.dcbaotin.DataPropertyName = "dcbaotin";
            this.dcbaotin.HeaderText = "Địa chỉ báo tin";
            this.dcbaotin.Name = "dcbaotin";
            this.dcbaotin.ReadOnly = true;
            // 
            // namtn
            // 
            this.namtn.DataPropertyName = "namtn";
            this.namtn.HeaderText = "Năm TN";
            this.namtn.Name = "namtn";
            this.namtn.ReadOnly = true;
            // 
            // FrmChiTietTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 96);
            this.Controls.Add(this.gridhienthi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChiTietTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết thí sinh";
            this.Load += new System.EventHandler(this.FrmChiTietTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridhienthi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX gridhienthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoso;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobd;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn matinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hokhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_ut;
        private System.Windows.Forms.DataGridViewTextBoxColumn khuvuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganhdk;
        private System.Windows.Forms.DataGridViewTextBoxColumn namthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcbaotin;
        private System.Windows.Forms.DataGridViewTextBoxColumn namtn;
    }
}