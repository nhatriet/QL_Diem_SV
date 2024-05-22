namespace Project_DBMS_Final
{
    partial class frmTimDiemSV
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
            this.gB_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_InDiem = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cbo_MonHoc = new System.Windows.Forms.ComboBox();
            this.lbl_MonHoc = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_MaSv = new System.Windows.Forms.Label();
            this.gB_TTCT = new System.Windows.Forms.GroupBox();
            this.dgw_TCD = new System.Windows.Forms.DataGridView();
            this.lbl_TCD = new System.Windows.Forms.Label();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhKiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gB_TimKiem.SuspendLayout();
            this.gB_TTCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TCD)).BeginInit();
            this.SuspendLayout();
            // 
            // gB_TimKiem
            // 
            this.gB_TimKiem.Controls.Add(this.cbo_MonHoc);
            this.gB_TimKiem.Controls.Add(this.lbl_MonHoc);
            this.gB_TimKiem.Controls.Add(this.txt_MaSV);
            this.gB_TimKiem.Controls.Add(this.lbl_MaSv);
            this.gB_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TimKiem.Location = new System.Drawing.Point(12, 65);
            this.gB_TimKiem.Name = "gB_TimKiem";
            this.gB_TimKiem.Size = new System.Drawing.Size(698, 88);
            this.gB_TimKiem.TabIndex = 29;
            this.gB_TimKiem.TabStop = false;
            this.gB_TimKiem.Text = "Tìm kiếm";
            // 
            // btn_InDiem
            // 
            this.btn_InDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InDiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_InDiem.Location = new System.Drawing.Point(916, 102);
            this.btn_InDiem.Name = "btn_InDiem";
            this.btn_InDiem.Size = new System.Drawing.Size(75, 23);
            this.btn_InDiem.TabIndex = 16;
            this.btn_InDiem.Text = "In điểm";
            this.btn_InDiem.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Location = new System.Drawing.Point(765, 102);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 15;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(1064, 102);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 14;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // cbo_MonHoc
            // 
            this.cbo_MonHoc.FormattingEnabled = true;
            this.cbo_MonHoc.Location = new System.Drawing.Point(494, 37);
            this.cbo_MonHoc.Name = "cbo_MonHoc";
            this.cbo_MonHoc.Size = new System.Drawing.Size(187, 23);
            this.cbo_MonHoc.TabIndex = 3;
            // 
            // lbl_MonHoc
            // 
            this.lbl_MonHoc.AutoSize = true;
            this.lbl_MonHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MonHoc.Location = new System.Drawing.Point(432, 41);
            this.lbl_MonHoc.Name = "lbl_MonHoc";
            this.lbl_MonHoc.Size = new System.Drawing.Size(56, 15);
            this.lbl_MonHoc.TabIndex = 3;
            this.lbl_MonHoc.Text = "Môn học";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(265, 38);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(121, 22);
            this.txt_MaSV.TabIndex = 1;
            // 
            // lbl_MaSv
            // 
            this.lbl_MaSv.AutoSize = true;
            this.lbl_MaSv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaSv.Location = new System.Drawing.Point(182, 41);
            this.lbl_MaSv.Name = "lbl_MaSv";
            this.lbl_MaSv.Size = new System.Drawing.Size(77, 15);
            this.lbl_MaSv.TabIndex = 0;
            this.lbl_MaSv.Text = "Mã sinh viên";
            // 
            // gB_TTCT
            // 
            this.gB_TTCT.Controls.Add(this.dgw_TCD);
            this.gB_TTCT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TTCT.Location = new System.Drawing.Point(12, 159);
            this.gB_TTCT.Name = "gB_TTCT";
            this.gB_TTCT.Size = new System.Drawing.Size(1156, 383);
            this.gB_TTCT.TabIndex = 28;
            this.gB_TTCT.TabStop = false;
            this.gB_TTCT.Text = "Thông tin chi tiết";
            // 
            // dgw_TCD
            // 
            this.dgw_TCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_TCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.MaLop,
            this.MaMon,
            this.DiemTB,
            this.DiemL1,
            this.DiemL2,
            this.DiemTK,
            this.HanhKiem,
            this.HocKi,
            this.GhiChu});
            this.dgw_TCD.Location = new System.Drawing.Point(9, 18);
            this.dgw_TCD.Name = "dgw_TCD";
            this.dgw_TCD.Size = new System.Drawing.Size(1142, 359);
            this.dgw_TCD.TabIndex = 0;
            // 
            // lbl_TCD
            // 
            this.lbl_TCD.AutoSize = true;
            this.lbl_TCD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TCD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_TCD.Location = new System.Drawing.Point(481, 25);
            this.lbl_TCD.Name = "lbl_TCD";
            this.lbl_TCD.Size = new System.Drawing.Size(153, 22);
            this.lbl_TCD.TabIndex = 28;
            this.lbl_TCD.Text = "TRA CỨU ĐIỂM";
            this.lbl_TCD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            // 
            // MaMon
            // 
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.Name = "MaMon";
            // 
            // DiemTB
            // 
            this.DiemTB.HeaderText = "Điểm TB";
            this.DiemTB.Name = "DiemTB";
            // 
            // DiemL1
            // 
            this.DiemL1.HeaderText = "Điểm lần 1";
            this.DiemL1.Name = "DiemL1";
            // 
            // DiemL2
            // 
            this.DiemL2.HeaderText = "Điểm lần 2";
            this.DiemL2.Name = "DiemL2";
            // 
            // DiemTK
            // 
            this.DiemTK.HeaderText = "Điểm TK";
            this.DiemTK.Name = "DiemTK";
            // 
            // HanhKiem
            // 
            this.HanhKiem.HeaderText = "Hạnh kiểm";
            this.HanhKiem.Name = "HanhKiem";
            // 
            // HocKi
            // 
            this.HocKi.HeaderText = "Học kì";
            this.HocKi.Name = "HocKi";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // frmTimDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 540);
            this.Controls.Add(this.btn_InDiem);
            this.Controls.Add(this.lbl_TCD);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.gB_TimKiem);
            this.Controls.Add(this.gB_TTCT);
            this.Name = "frmTimDiemSV";
            this.Text = "Tra cứu điểm sinh viên";
            this.gB_TimKiem.ResumeLayout(false);
            this.gB_TimKiem.PerformLayout();
            this.gB_TTCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gB_TimKiem;
        private System.Windows.Forms.ComboBox cbo_MonHoc;
        private System.Windows.Forms.Label lbl_MonHoc;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label lbl_MaSv;
        private System.Windows.Forms.GroupBox gB_TTCT;
        private System.Windows.Forms.DataGridView dgw_TCD;
        private System.Windows.Forms.Label lbl_TCD;
        private System.Windows.Forms.Button btn_InDiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}