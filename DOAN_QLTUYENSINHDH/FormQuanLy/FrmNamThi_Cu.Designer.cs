namespace DOAN_QLTUYENSINHDH.FormQuanLy
{
    partial class FrmNamThi_Cu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNamThi_Cu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDsNamHoc = new System.Windows.Forms.GroupBox();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.dgvNamHoc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdndieukhien = new System.Windows.Forms.BindingNavigator(this.components);
            this.bdnthem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.bdluulai = new System.Windows.Forms.ToolStripButton();
            this.bdload = new System.Windows.Forms.ToolStripButton();
            this.bdthoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDsNamHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdndieukhien)).BeginInit();
            this.bdndieukhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDsNamHoc
            // 
            this.groupBoxDsNamHoc.Controls.Add(this.contextMenuBar1);
            this.groupBoxDsNamHoc.Controls.Add(this.bdndieukhien);
            this.groupBoxDsNamHoc.Controls.Add(this.dgvNamHoc);
            this.groupBoxDsNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsNamHoc.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDsNamHoc.Name = "groupBoxDsNamHoc";
            this.groupBoxDsNamHoc.Size = new System.Drawing.Size(414, 343);
            this.groupBoxDsNamHoc.TabIndex = 2;
            this.groupBoxDsNamHoc.TabStop = false;
            this.groupBoxDsNamHoc.Text = "Danh Sách Năm Học";
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar1.Location = new System.Drawing.Point(184, 149);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(52, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.contextMenuBar1.TabIndex = 3;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem5,
            this.buttonItem6,
            this.buttonItem2,
            this.buttonItem4,
            this.buttonItem3});
            this.buttonItem1.Text = "Menu";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem5.Image")));
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.buttonItem5.Text = "Thêm";
            this.buttonItem5.Click += new System.EventHandler(this.buttonItem5_Click);
            // 
            // buttonItem6
            // 
            this.buttonItem6.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem6.Image")));
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.buttonItem6.Text = "Xóa";
            this.buttonItem6.Click += new System.EventHandler(this.buttonItem6_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.buttonItem2.Text = "Lưu Lại";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.buttonItem4.Text = "Cập nhật";
            this.buttonItem4.Click += new System.EventHandler(this.buttonItem4_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.buttonItem3.Text = "Thoát";
            this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // dgvNamHoc
            // 
            this.dgvNamHoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNamHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNamHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNamHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNamHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.namthi});
            this.contextMenuBar1.SetContextMenuEx(this.dgvNamHoc, this.buttonItem1);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNamHoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNamHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNamHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNamHoc.Location = new System.Drawing.Point(3, 58);
            this.dgvNamHoc.Name = "dgvNamHoc";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNamHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNamHoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNamHoc.Size = new System.Drawing.Size(408, 282);
            this.dgvNamHoc.TabIndex = 1;
            this.dgvNamHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNamHoc_CellClick);
            this.dgvNamHoc.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvNamHoc_DataError);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma.DefaultCellStyle = dataGridViewCellStyle3;
            this.ma.HeaderText = "Mã Năm Thi";
            this.ma.Name = "ma";
            this.ma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ma.Width = 150;
            // 
            // namthi
            // 
            this.namthi.DataPropertyName = "namthi";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namthi.DefaultCellStyle = dataGridViewCellStyle4;
            this.namthi.HeaderText = "Năm Thi";
            this.namthi.MaxInputLength = 4;
            this.namthi.Name = "namthi";
            this.namthi.Width = 150;
            // 
            // bdndieukhien
            // 
            this.bdndieukhien.AddNewItem = this.bdnthem;
            this.bdndieukhien.CountItem = this.bindingNavigatorCountItem;
            this.bdndieukhien.CountItemFormat = "của {0}";
            this.bdndieukhien.DeleteItem = null;
            this.bdndieukhien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bdnthem,
            this.btnxoa,
            this.bdluulai,
            this.bdload,
            this.bdthoat,
            this.toolStripButton2,
            this.toolStripButton1});
            this.bdndieukhien.Location = new System.Drawing.Point(3, 16);
            this.bdndieukhien.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdndieukhien.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdndieukhien.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdndieukhien.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdndieukhien.Name = "bdndieukhien";
            this.bdndieukhien.PositionItem = this.bindingNavigatorPositionItem;
            this.bdndieukhien.Size = new System.Drawing.Size(408, 25);
            this.bdndieukhien.TabIndex = 2;
            this.bdndieukhien.Text = "bindingNavigator1";
            // 
            // bdnthem
            // 
            this.bdnthem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdnthem.Image = ((System.Drawing.Image)(resources.GetObject("bdnthem.Image")));
            this.bdnthem.Name = "bdnthem";
            this.bdnthem.RightToLeftAutoMirrorImage = true;
            this.bdnthem.Size = new System.Drawing.Size(23, 22);
            this.bdnthem.Text = "Thêm mới";
            this.bdnthem.Click += new System.EventHandler(this.bdnthem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnxoa
            // 
            this.btnxoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(23, 22);
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // bdluulai
            // 
            this.bdluulai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdluulai.Image = ((System.Drawing.Image)(resources.GetObject("bdluulai.Image")));
            this.bdluulai.Name = "bdluulai";
            this.bdluulai.RightToLeftAutoMirrorImage = true;
            this.bdluulai.Size = new System.Drawing.Size(23, 22);
            this.bdluulai.Text = "Lưu Lại";
            this.bdluulai.Click += new System.EventHandler(this.bdluulai_Click);
            // 
            // bdload
            // 
            this.bdload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdload.Image = ((System.Drawing.Image)(resources.GetObject("bdload.Image")));
            this.bdload.Name = "bdload";
            this.bdload.RightToLeftAutoMirrorImage = true;
            this.bdload.Size = new System.Drawing.Size(23, 22);
            this.bdload.Text = "Cập Nhật";
            this.bdload.Click += new System.EventHandler(this.bdload_Click);
            // 
            // bdthoat
            // 
            this.bdthoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdthoat.Image = ((System.Drawing.Image)(resources.GetObject("bdthoat.Image")));
            this.bdthoat.Name = "bdthoat";
            this.bdthoat.RightToLeftAutoMirrorImage = true;
            this.bdthoat.Size = new System.Drawing.Size(23, 22);
            this.bdthoat.Text = "Thoát";
            this.bdthoat.Click += new System.EventHandler(this.bdthoat_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmNamThi_Cu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 343);
            this.Controls.Add(this.groupBoxDsNamHoc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNamThi_Cu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Năm Thi";
            this.Load += new System.EventHandler(this.FrmNamThi_Load);
            this.groupBoxDsNamHoc.ResumeLayout(false);
            this.groupBoxDsNamHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdndieukhien)).EndInit();
            this.bdndieukhien.ResumeLayout(false);
            this.bdndieukhien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDsNamHoc;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvNamHoc;
        private System.Windows.Forms.BindingNavigator bdndieukhien;
        private System.Windows.Forms.ToolStripButton bdnthem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bdluulai;
        private System.Windows.Forms.ToolStripButton bdload;
        private System.Windows.Forms.ToolStripButton bdthoat;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn namthi;
    }
}