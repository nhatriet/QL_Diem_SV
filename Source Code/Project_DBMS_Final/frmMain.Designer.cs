namespace Project_DBMS_Final
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuItem_Hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Trangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItem_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Mon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Lop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Quanli = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SV = new System.Windows.Forms.ToolStripMenuItem();
            this.giảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Diem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Timkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThongtinSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DiemTK = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_MH = new System.Windows.Forms.Button();
            this.bt_LOP = new System.Windows.Forms.Button();
            this.bt_QLDSV = new System.Windows.Forms.Button();
            this.bt_QLGV = new System.Windows.Forms.Button();
            this.bt_QLSV = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_Hethong,
            this.MnuItem_DanhMuc,
            this.mnuItem_Quanli,
            this.mnuItem_Timkiem,
            this.mnuItem_ThongKe});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip.TabIndex = 26;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuItem_Hethong
            // 
            this.mnuItem_Hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Trangchu,
            this.mnu_Exit});
            this.mnuItem_Hethong.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuItem_Hethong.Name = "mnuItem_Hethong";
            this.mnuItem_Hethong.Size = new System.Drawing.Size(69, 20);
            this.mnuItem_Hethong.Text = "&Hệ thống";
            // 
            // mnu_Trangchu
            // 
            this.mnu_Trangchu.Name = "mnu_Trangchu";
            this.mnu_Trangchu.Size = new System.Drawing.Size(126, 22);
            this.mnu_Trangchu.Text = "&Trang chủ";
            this.mnu_Trangchu.Click += new System.EventHandler(this.mnu_Trangchu_Click);
            // 
            // mnu_Exit
            // 
            this.mnu_Exit.Name = "mnu_Exit";
            this.mnu_Exit.Size = new System.Drawing.Size(126, 22);
            this.mnu_Exit.Text = "&Exit";
            this.mnu_Exit.Click += new System.EventHandler(this.mnu_Exit_Click);
            // 
            // MnuItem_DanhMuc
            // 
            this.MnuItem_DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Mon,
            this.mnu_Lop});
            this.MnuItem_DanhMuc.Name = "MnuItem_DanhMuc";
            this.MnuItem_DanhMuc.Size = new System.Drawing.Size(74, 20);
            this.MnuItem_DanhMuc.Text = "&Danh mục";
            // 
            // mnu_Mon
            // 
            this.mnu_Mon.Name = "mnu_Mon";
            this.mnu_Mon.Size = new System.Drawing.Size(122, 22);
            this.mnu_Mon.Text = "&Môn học";
            this.mnu_Mon.Click += new System.EventHandler(this.mnu_Mon_Click);
            // 
            // mnu_Lop
            // 
            this.mnu_Lop.Name = "mnu_Lop";
            this.mnu_Lop.Size = new System.Drawing.Size(122, 22);
            this.mnu_Lop.Text = "&Lớp";
            this.mnu_Lop.Click += new System.EventHandler(this.mnu_Lop_Click);
            // 
            // mnuItem_Quanli
            // 
            this.mnuItem_Quanli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_SV,
            this.giảngViênToolStripMenuItem,
            this.mnu_Diem});
            this.mnuItem_Quanli.Name = "mnuItem_Quanli";
            this.mnuItem_Quanli.Size = new System.Drawing.Size(60, 20);
            this.mnuItem_Quanli.Text = "&Quản lí ";
            // 
            // mnu_SV
            // 
            this.mnu_SV.Name = "mnu_SV";
            this.mnu_SV.Size = new System.Drawing.Size(153, 22);
            this.mnu_SV.Text = "&Sinh viên";
            this.mnu_SV.Click += new System.EventHandler(this.mnu_SV_Click);
            // 
            // giảngViênToolStripMenuItem
            // 
            this.giảngViênToolStripMenuItem.Name = "giảngViênToolStripMenuItem";
            this.giảngViênToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.giảngViênToolStripMenuItem.Text = "&Giảng viên";
            this.giảngViênToolStripMenuItem.Click += new System.EventHandler(this.giảngViênToolStripMenuItem_Click);
            // 
            // mnu_Diem
            // 
            this.mnu_Diem.Name = "mnu_Diem";
            this.mnu_Diem.Size = new System.Drawing.Size(153, 22);
            this.mnu_Diem.Text = "&Điểm môn học";
            this.mnu_Diem.Click += new System.EventHandler(this.mnu_Diem_Click);
            // 
            // mnuItem_Timkiem
            // 
            this.mnuItem_Timkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ThongtinSV});
            this.mnuItem_Timkiem.Name = "mnuItem_Timkiem";
            this.mnuItem_Timkiem.Size = new System.Drawing.Size(68, 20);
            this.mnuItem_Timkiem.Text = "&Tìm kiếm";
            // 
            // mnu_ThongtinSV
            // 
            this.mnu_ThongtinSV.Name = "mnu_ThongtinSV";
            this.mnu_ThongtinSV.Size = new System.Drawing.Size(180, 22);
            this.mnu_ThongtinSV.Text = "&Điểm sinh viên";
            this.mnu_ThongtinSV.Click += new System.EventHandler(this.mnu_ThongtinSV_Click);
            // 
            // mnuItem_ThongKe
            // 
            this.mnuItem_ThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_DiemTK});
            this.mnuItem_ThongKe.Name = "mnuItem_ThongKe";
            this.mnuItem_ThongKe.Size = new System.Drawing.Size(71, 20);
            this.mnuItem_ThongKe.Text = "&Thống kê ";
            // 
            // mnu_DiemTK
            // 
            this.mnu_DiemTK.Name = "mnu_DiemTK";
            this.mnu_DiemTK.Size = new System.Drawing.Size(191, 22);
            this.mnu_DiemTK.Text = "&Sinh viên theo học lực";
            this.mnu_DiemTK.Click += new System.EventHandler(this.mnu_DiemTK_Click);
            // 
            // bt_MH
            // 
            this.bt_MH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_MH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_MH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_MH.Image = ((System.Drawing.Image)(resources.GetObject("bt_MH.Image")));
            this.bt_MH.Location = new System.Drawing.Point(22, 600);
            this.bt_MH.Name = "bt_MH";
            this.bt_MH.Size = new System.Drawing.Size(150, 60);
            this.bt_MH.TabIndex = 32;
            this.bt_MH.Text = "Quản lý Môn học";
            this.bt_MH.UseVisualStyleBackColor = true;
            this.bt_MH.Click += new System.EventHandler(this.bt_MH_Click);
            // 
            // bt_LOP
            // 
            this.bt_LOP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_LOP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_LOP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_LOP.Image = ((System.Drawing.Image)(resources.GetObject("bt_LOP.Image")));
            this.bt_LOP.Location = new System.Drawing.Point(22, 520);
            this.bt_LOP.Name = "bt_LOP";
            this.bt_LOP.Size = new System.Drawing.Size(150, 60);
            this.bt_LOP.TabIndex = 31;
            this.bt_LOP.Text = "Quản lý Lớp";
            this.bt_LOP.UseVisualStyleBackColor = true;
            this.bt_LOP.Click += new System.EventHandler(this.bt_LOP_Click);
            // 
            // bt_QLDSV
            // 
            this.bt_QLDSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_QLDSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_QLDSV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_QLDSV.Image = ((System.Drawing.Image)(resources.GetObject("bt_QLDSV.Image")));
            this.bt_QLDSV.Location = new System.Drawing.Point(22, 440);
            this.bt_QLDSV.Name = "bt_QLDSV";
            this.bt_QLDSV.Size = new System.Drawing.Size(150, 60);
            this.bt_QLDSV.TabIndex = 29;
            this.bt_QLDSV.Text = "Quản lý điểm Sinh viên";
            this.bt_QLDSV.UseVisualStyleBackColor = true;
            this.bt_QLDSV.Click += new System.EventHandler(this.bt_QLDSV_Click);
            // 
            // bt_QLGV
            // 
            this.bt_QLGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_QLGV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_QLGV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_QLGV.Image = ((System.Drawing.Image)(resources.GetObject("bt_QLGV.Image")));
            this.bt_QLGV.Location = new System.Drawing.Point(22, 360);
            this.bt_QLGV.Name = "bt_QLGV";
            this.bt_QLGV.Size = new System.Drawing.Size(150, 60);
            this.bt_QLGV.TabIndex = 28;
            this.bt_QLGV.Text = "QL Giảng Viên";
            this.bt_QLGV.UseVisualStyleBackColor = true;
            this.bt_QLGV.Click += new System.EventHandler(this.bt_QLGV_Click);
            // 
            // bt_QLSV
            // 
            this.bt_QLSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_QLSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_QLSV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_QLSV.Image = ((System.Drawing.Image)(resources.GetObject("bt_QLSV.Image")));
            this.bt_QLSV.Location = new System.Drawing.Point(22, 286);
            this.bt_QLSV.Name = "bt_QLSV";
            this.bt_QLSV.Size = new System.Drawing.Size(150, 60);
            this.bt_QLSV.TabIndex = 27;
            this.bt_QLSV.Text = "QL Sinh viên";
            this.bt_QLSV.UseVisualStyleBackColor = true;
            this.bt_QLSV.Click += new System.EventHandler(this.bt_QLSV_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1170, 577);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1170, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Content
            // 
            this.panel_Content.Location = new System.Drawing.Point(0, 152);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1170, 577);
            this.panel_Content.TabIndex = 35;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 729);
            this.Controls.Add(this.bt_MH);
            this.Controls.Add(this.bt_LOP);
            this.Controls.Add(this.bt_QLDSV);
            this.Controls.Add(this.bt_QLGV);
            this.Controls.Add(this.bt_QLSV);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel_Content);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bt_QLSV;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Hethong;
        private System.Windows.Forms.ToolStripMenuItem mnu_Trangchu;
        public System.Windows.Forms.ToolStripMenuItem MnuItem_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnu_Mon;
        private System.Windows.Forms.ToolStripMenuItem mnu_Lop;
        public System.Windows.Forms.ToolStripMenuItem mnuItem_Quanli;
        private System.Windows.Forms.ToolStripMenuItem mnu_SV;
        private System.Windows.Forms.ToolStripMenuItem mnu_Diem;
        public System.Windows.Forms.ToolStripMenuItem mnuItem_Timkiem;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThongtinSV;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnu_DiemTK;
        public System.Windows.Forms.Button bt_MH;
        public System.Windows.Forms.Button bt_LOP;
        public System.Windows.Forms.Button bt_QLDSV;
        public System.Windows.Forms.Button bt_QLGV;
        private System.Windows.Forms.ToolStripMenuItem giảngViênToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
    }
}