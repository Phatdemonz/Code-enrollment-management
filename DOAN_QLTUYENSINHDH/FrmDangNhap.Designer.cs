namespace DOAN_QLTUYENSINHDH
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chbnho = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnhuy = new DevComponents.DotNetBar.ButtonX();
            this.btndangnhap = new DevComponents.DotNetBar.ButtonX();
            this.txtmatkhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttaikhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.Transparent;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(45, -7);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(101, 167);
            this.reflectionImage1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình quản lý điểm tuyển sinh Đại Học_Cao Đẳng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(152, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(152, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mật khẩu";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.chbnho);
            this.groupPanel1.Controls.Add(this.btnhuy);
            this.groupPanel1.Controls.Add(this.btndangnhap);
            this.groupPanel1.Controls.Add(this.txtmatkhau);
            this.groupPanel1.Controls.Add(this.txttaikhoan);
            this.groupPanel1.Controls.Add(this.reflectionImage1);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel1.Location = new System.Drawing.Point(0, 62);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(608, 211);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Thông Tin Đăng Nhập";
            // 
            // chbnho
            // 
            this.chbnho.BackColor = System.Drawing.Color.Transparent;
            this.chbnho.Checked = true;
            this.chbnho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbnho.CheckValue = "Y";
            this.chbnho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbnho.Location = new System.Drawing.Point(262, 113);
            this.chbnho.Name = "chbnho";
            this.chbnho.Size = new System.Drawing.Size(218, 27);
            this.chbnho.TabIndex = 2;
            this.chbnho.Text = "Nhớ tài khoản và mật khẩu";
            this.chbnho.TextColor = System.Drawing.Color.Red;
            this.chbnho.CheckedChanged += new System.EventHandler(this.chbnho_CheckedChanged);
            this.chbnho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbnho_KeyDown);
            // 
            // btnhuy
            // 
            this.btnhuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnhuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnhuy.Location = new System.Drawing.Point(437, 156);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(87, 27);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "Exit";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndangnhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndangnhap.Location = new System.Drawing.Point(262, 156);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(87, 27);
            this.btndangnhap.TabIndex = 3;
            this.btndangnhap.Text = "Connect";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtmatkhau
            // 
            // 
            // 
            // 
            this.txtmatkhau.Border.Class = "TextBoxBorder";
            this.txtmatkhau.Location = new System.Drawing.Point(261, 80);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(199, 22);
            this.txtmatkhau.TabIndex = 1;
            this.txtmatkhau.WatermarkText = "Nhập Mật Khẩu";
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            this.txtmatkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmatkhau_KeyDown_1);
            // 
            // txttaikhoan
            // 
            // 
            // 
            // 
            this.txttaikhoan.Border.Class = "TextBoxBorder";
            this.txttaikhoan.Location = new System.Drawing.Point(262, 38);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(199, 22);
            this.txttaikhoan.TabIndex = 0;
            this.txttaikhoan.WatermarkText = "Nhập Tài Khoản";
            this.txttaikhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttaikhoan_KeyDown);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(608, 273);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Frm_DangNhap_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmatkhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txttaikhoan;
        private DevComponents.DotNetBar.ButtonX btnhuy;
        private DevComponents.DotNetBar.ButtonX btndangnhap;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbnho;
    }
}