namespace Project_DBMS_Final
{
    partial class frmQLSV
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
            this.lbl_TTSV = new System.Windows.Forms.Label();
            this.gB_TTChiTiet = new System.Windows.Forms.GroupBox();
            this.cbo_MaLop = new System.Windows.Forms.ComboBox();
            this.mTB_NgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.gB_TimKiem = new System.Windows.Forms.GroupBox();
            this.cbo_LopHoc = new System.Windows.Forms.ComboBox();
            this.lbl_LopHoc = new System.Windows.Forms.Label();
            this.gB_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgw_TTSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.gB_TTChiTiet.SuspendLayout();
            this.gB_TimKiem.SuspendLayout();
            this.gB_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TTSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TTSV
            // 
            this.lbl_TTSV.AutoSize = true;
            this.lbl_TTSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TTSV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_TTSV.Location = new System.Drawing.Point(306, 22);
            this.lbl_TTSV.Name = "lbl_TTSV";
            this.lbl_TTSV.Size = new System.Drawing.Size(313, 22);
            this.lbl_TTSV.TabIndex = 1;
            this.lbl_TTSV.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            this.lbl_TTSV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gB_TTChiTiet
            // 
            this.gB_TTChiTiet.Controls.Add(this.cbo_MaLop);
            this.gB_TTChiTiet.Controls.Add(this.mTB_NgaySinh);
            this.gB_TTChiTiet.Controls.Add(this.cbo_GioiTinh);
            this.gB_TTChiTiet.Controls.Add(this.textBox2);
            this.gB_TTChiTiet.Controls.Add(this.txt_DiaChi);
            this.gB_TTChiTiet.Controls.Add(this.lbl_MaLop);
            this.gB_TTChiTiet.Controls.Add(this.lbl_DiaChi);
            this.gB_TTChiTiet.Controls.Add(this.lbl_GioiTinh);
            this.gB_TTChiTiet.Controls.Add(this.lbl_NgaySinh);
            this.gB_TTChiTiet.Controls.Add(this.txt_MaSV);
            this.gB_TTChiTiet.Controls.Add(this.lbl_HoTen);
            this.gB_TTChiTiet.Controls.Add(this.lbl_MaSV);
            this.gB_TTChiTiet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TTChiTiet.Location = new System.Drawing.Point(12, 118);
            this.gB_TTChiTiet.Name = "gB_TTChiTiet";
            this.gB_TTChiTiet.Size = new System.Drawing.Size(220, 290);
            this.gB_TTChiTiet.TabIndex = 8;
            this.gB_TTChiTiet.TabStop = false;
            this.gB_TTChiTiet.Text = "Thông tin chi tiết";
            // 
            // cbo_MaLop
            // 
            this.cbo_MaLop.FormattingEnabled = true;
            this.cbo_MaLop.Location = new System.Drawing.Point(89, 248);
            this.cbo_MaLop.Name = "cbo_MaLop";
            this.cbo_MaLop.Size = new System.Drawing.Size(124, 23);
            this.cbo_MaLop.TabIndex = 18;
            // 
            // mTB_NgaySinh
            // 
            this.mTB_NgaySinh.Location = new System.Drawing.Point(89, 111);
            this.mTB_NgaySinh.Mask = "__/__/____";
            this.mTB_NgaySinh.Name = "mTB_NgaySinh";
            this.mTB_NgaySinh.Size = new System.Drawing.Size(124, 22);
            this.mTB_NgaySinh.TabIndex = 19;
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Location = new System.Drawing.Point(89, 157);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(90, 23);
            this.cbo_GioiTinh.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 22);
            this.textBox2.TabIndex = 14;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(89, 204);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(124, 22);
            this.txt_DiaChi.TabIndex = 13;
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaLop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MaLop.Location = new System.Drawing.Point(6, 250);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(45, 15);
            this.lbl_MaLop.TabIndex = 12;
            this.lbl_MaLop.Text = "Mã lớp";
            this.lbl_MaLop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DiaChi.Location = new System.Drawing.Point(6, 207);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(44, 15);
            this.lbl_DiaChi.TabIndex = 11;
            this.lbl_DiaChi.Text = "Địa chỉ";
            this.lbl_DiaChi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_GioiTinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(6, 163);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(52, 15);
            this.lbl_GioiTinh.TabIndex = 10;
            this.lbl_GioiTinh.Text = "Giới tính";
            this.lbl_GioiTinh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NgaySinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(6, 117);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(62, 15);
            this.lbl_NgaySinh.TabIndex = 9;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            this.lbl_NgaySinh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(89, 27);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(124, 22);
            this.txt_MaSV.TabIndex = 7;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HoTen.Location = new System.Drawing.Point(6, 73);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(62, 15);
            this.lbl_HoTen.TabIndex = 5;
            this.lbl_HoTen.Text = "Họ và tên ";
            this.lbl_HoTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_MaSV
            // 
            this.lbl_MaSV.AutoSize = true;
            this.lbl_MaSV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MaSV.Location = new System.Drawing.Point(6, 34);
            this.lbl_MaSV.Name = "lbl_MaSV";
            this.lbl_MaSV.Size = new System.Drawing.Size(77, 15);
            this.lbl_MaSV.TabIndex = 4;
            this.lbl_MaSV.Text = "Mã sinh viên";
            this.lbl_MaSV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gB_TimKiem
            // 
            this.gB_TimKiem.Controls.Add(this.cbo_LopHoc);
            this.gB_TimKiem.Controls.Add(this.lbl_LopHoc);
            this.gB_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TimKiem.Location = new System.Drawing.Point(12, 47);
            this.gB_TimKiem.Name = "gB_TimKiem";
            this.gB_TimKiem.Size = new System.Drawing.Size(220, 65);
            this.gB_TimKiem.TabIndex = 9;
            this.gB_TimKiem.TabStop = false;
            this.gB_TimKiem.Text = "Tìm kiếm";
            // 
            // cbo_LopHoc
            // 
            this.cbo_LopHoc.FormattingEnabled = true;
            this.cbo_LopHoc.Location = new System.Drawing.Point(69, 28);
            this.cbo_LopHoc.Name = "cbo_LopHoc";
            this.cbo_LopHoc.Size = new System.Drawing.Size(121, 23);
            this.cbo_LopHoc.TabIndex = 17;
            // 
            // lbl_LopHoc
            // 
            this.lbl_LopHoc.AutoSize = true;
            this.lbl_LopHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_LopHoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_LopHoc.Location = new System.Drawing.Point(12, 28);
            this.lbl_LopHoc.Name = "lbl_LopHoc";
            this.lbl_LopHoc.Size = new System.Drawing.Size(51, 15);
            this.lbl_LopHoc.TabIndex = 15;
            this.lbl_LopHoc.Text = "Lớp học";
            this.lbl_LopHoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gB_DanhSach
            // 
            this.gB_DanhSach.Controls.Add(this.dgw_TTSV);
            this.gB_DanhSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_DanhSach.Location = new System.Drawing.Point(238, 69);
            this.gB_DanhSach.Name = "gB_DanhSach";
            this.gB_DanhSach.Size = new System.Drawing.Size(608, 320);
            this.gB_DanhSach.TabIndex = 10;
            this.gB_DanhSach.TabStop = false;
            this.gB_DanhSach.Text = "Danh sách";
            // 
            // dgw_TTSV
            // 
            this.dgw_TTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_TTSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.MaLop});
            this.dgw_TTSV.Location = new System.Drawing.Point(6, 19);
            this.dgw_TTSV.Name = "dgw_TTSV";
            this.dgw_TTSV.Size = new System.Drawing.Size(596, 295);
            this.dgw_TTSV.TabIndex = 0;
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
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(871, 305);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 17;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(871, 255);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(871, 200);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(871, 152);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 412);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.gB_DanhSach);
            this.Controls.Add(this.gB_TimKiem);
            this.Controls.Add(this.gB_TTChiTiet);
            this.Controls.Add(this.lbl_TTSV);
            this.Name = "frmQLSV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            this.gB_TTChiTiet.ResumeLayout(false);
            this.gB_TTChiTiet.PerformLayout();
            this.gB_TimKiem.ResumeLayout(false);
            this.gB_TimKiem.PerformLayout();
            this.gB_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TTSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TTSV;
        private System.Windows.Forms.GroupBox gB_TTChiTiet;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.GroupBox gB_TimKiem;
        private System.Windows.Forms.Label lbl_LopHoc;
        private System.Windows.Forms.GroupBox gB_DanhSach;
        private System.Windows.Forms.DataGridView dgw_TTSV;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cbo_MaLop;
        private System.Windows.Forms.MaskedTextBox mTB_NgaySinh;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.ComboBox cbo_LopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
    }
}