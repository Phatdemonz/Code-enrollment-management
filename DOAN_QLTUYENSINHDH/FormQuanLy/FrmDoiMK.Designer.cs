namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    partial class FrmDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMK));
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtmk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtmk_lai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.Location = new System.Drawing.Point(126, 94);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "Đồng ý";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtmk
            // 
            // 
            // 
            // 
            this.txtmk.Border.Class = "TextBoxBorder";
            this.txtmk.Location = new System.Drawing.Point(126, 29);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(200, 20);
            this.txtmk.TabIndex = 0;
            this.txtmk.UseSystemPasswordChar = true;
            this.txtmk.WatermarkText = "Nhập mật khẩu mới";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(31, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 17);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Mật khẩu mới";
            // 
            // txtmk_lai
            // 
            // 
            // 
            // 
            this.txtmk_lai.Border.Class = "TextBoxBorder";
            this.txtmk_lai.Location = new System.Drawing.Point(126, 55);
            this.txtmk_lai.Name = "txtmk_lai";
            this.txtmk_lai.Size = new System.Drawing.Size(200, 20);
            this.txtmk_lai.TabIndex = 1;
            this.txtmk_lai.UseSystemPasswordChar = true;
            this.txtmk_lai.WatermarkText = "Nhập lại mật khẩu mới";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(31, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 17);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Nhập lại";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = ((System.Drawing.Image)(resources.GetObject("buttonX2.Image")));
            this.buttonX2.Location = new System.Drawing.Point(252, 94);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(81, 23);
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "Thoát";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // FrmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 131);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtmk_lai);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.buttonX1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FrmDoiMK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmk;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmk_lai;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}