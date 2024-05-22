namespace Project_DBMS_Final
{
    partial class frmQLDiem
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
            this.lbl_TTD = new System.Windows.Forms.Label();
            this.gB_LuaChon = new System.Windows.Forms.GroupBox();
            this.cbo_MonHoc = new System.Windows.Forms.ComboBox();
            this.cbo_HocKi = new System.Windows.Forms.ComboBox();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            this.lbl_MonHoc = new System.Windows.Forms.Label();
            this.lbl_HocKi = new System.Windows.Forms.Label();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.gB_TTChiTiet = new System.Windows.Forms.GroupBox();
            this.txt_HanhKiem = new System.Windows.Forms.TextBox();
            this.lbl_HanhKiem = new System.Windows.Forms.Label();
            this.lbl_DiemTK = new System.Windows.Forms.Label();
            this.txt_DiemTK = new System.Windows.Forms.TextBox();
            this.txt_DiemL1 = new System.Windows.Forms.TextBox();
            this.lbl_DiemL1 = new System.Windows.Forms.Label();
            this.txt_DiemTB = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_DiemTB = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.gB_GhiChu = new System.Windows.Forms.GroupBox();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.gB_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgw_DiemSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThiLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhKiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_InBangDiem = new System.Windows.Forms.Button();
            this.gB_LuaChon.SuspendLayout();
            this.gB_TTChiTiet.SuspendLayout();
            this.gB_GhiChu.SuspendLayout();
            this.gB_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_DiemSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TTD
            // 
            this.lbl_TTD.AutoSize = true;
            this.lbl_TTD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TTD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_TTD.Location = new System.Drawing.Point(334, 19);
            this.lbl_TTD.Name = "lbl_TTD";
            this.lbl_TTD.Size = new System.Drawing.Size(280, 22);
            this.lbl_TTD.TabIndex = 0;
            this.lbl_TTD.Text = "THÔNG TIN ĐIỂM SINH VIÊN";
            this.lbl_TTD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gB_LuaChon
            // 
            this.gB_LuaChon.Controls.Add(this.cbo_MonHoc);
            this.gB_LuaChon.Controls.Add(this.cbo_HocKi);
            this.gB_LuaChon.Controls.Add(this.cbo_Lop);
            this.gB_LuaChon.Controls.Add(this.lbl_MonHoc);
            this.gB_LuaChon.Controls.Add(this.lbl_HocKi);
            this.gB_LuaChon.Controls.Add(this.lbl_Lop);
            this.gB_LuaChon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_LuaChon.Location = new System.Drawing.Point(12, 59);
            this.gB_LuaChon.Name = "gB_LuaChon";
            this.gB_LuaChon.Size = new System.Drawing.Size(355, 143);
            this.gB_LuaChon.TabIndex = 1;
            this.gB_LuaChon.TabStop = false;
            this.gB_LuaChon.Text = "Lựa chọn";
            // 
            // cbo_MonHoc
            // 
            this.cbo_MonHoc.FormattingEnabled = true;
            this.cbo_MonHoc.Location = new System.Drawing.Point(68, 108);
            this.cbo_MonHoc.Name = "cbo_MonHoc";
            this.cbo_MonHoc.Size = new System.Drawing.Size(273, 23);
            this.cbo_MonHoc.TabIndex = 9;
            // 
            // cbo_HocKi
            // 
            this.cbo_HocKi.FormattingEnabled = true;
            this.cbo_HocKi.Location = new System.Drawing.Point(68, 67);
            this.cbo_HocKi.Name = "cbo_HocKi";
            this.cbo_HocKi.Size = new System.Drawing.Size(131, 23);
            this.cbo_HocKi.TabIndex = 8;
            // 
            // cbo_Lop
            // 
            this.cbo_Lop.FormattingEnabled = true;
            this.cbo_Lop.Location = new System.Drawing.Point(68, 31);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(273, 23);
            this.cbo_Lop.TabIndex = 7;
            // 
            // lbl_MonHoc
            // 
            this.lbl_MonHoc.AutoSize = true;
            this.lbl_MonHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MonHoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MonHoc.Location = new System.Drawing.Point(6, 116);
            this.lbl_MonHoc.Name = "lbl_MonHoc";
            this.lbl_MonHoc.Size = new System.Drawing.Size(59, 15);
            this.lbl_MonHoc.TabIndex = 6;
            this.lbl_MonHoc.Text = "Môn học ";
            this.lbl_MonHoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_HocKi
            // 
            this.lbl_HocKi.AutoSize = true;
            this.lbl_HocKi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HocKi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HocKi.Location = new System.Drawing.Point(6, 75);
            this.lbl_HocKi.Name = "lbl_HocKi";
            this.lbl_HocKi.Size = new System.Drawing.Size(41, 15);
            this.lbl_HocKi.TabIndex = 5;
            this.lbl_HocKi.Text = "Học kì";
            this.lbl_HocKi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Lop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Lop.Location = new System.Drawing.Point(6, 34);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(28, 15);
            this.lbl_Lop.TabIndex = 4;
            this.lbl_Lop.Text = "Lớp";
            this.lbl_Lop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gB_TTChiTiet
            // 
            this.gB_TTChiTiet.Controls.Add(this.txt_HanhKiem);
            this.gB_TTChiTiet.Controls.Add(this.lbl_HanhKiem);
            this.gB_TTChiTiet.Controls.Add(this.lbl_DiemTK);
            this.gB_TTChiTiet.Controls.Add(this.txt_DiemTK);
            this.gB_TTChiTiet.Controls.Add(this.txt_DiemL1);
            this.gB_TTChiTiet.Controls.Add(this.lbl_DiemL1);
            this.gB_TTChiTiet.Controls.Add(this.txt_DiemTB);
            this.gB_TTChiTiet.Controls.Add(this.txt_HoTen);
            this.gB_TTChiTiet.Controls.Add(this.txt_MaSV);
            this.gB_TTChiTiet.Controls.Add(this.lbl_DiemTB);
            this.gB_TTChiTiet.Controls.Add(this.lbl_HoTen);
            this.gB_TTChiTiet.Controls.Add(this.lbl_MaSV);
            this.gB_TTChiTiet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TTChiTiet.Location = new System.Drawing.Point(12, 219);
            this.gB_TTChiTiet.Name = "gB_TTChiTiet";
            this.gB_TTChiTiet.Size = new System.Drawing.Size(895, 116);
            this.gB_TTChiTiet.TabIndex = 7;
            this.gB_TTChiTiet.TabStop = false;
            this.gB_TTChiTiet.Text = "Thông tin chi tiết";
            // 
            // txt_HanhKiem
            // 
            this.txt_HanhKiem.Location = new System.Drawing.Point(688, 27);
            this.txt_HanhKiem.Name = "txt_HanhKiem";
            this.txt_HanhKiem.Size = new System.Drawing.Size(201, 22);
            this.txt_HanhKiem.TabIndex = 15;
            // 
            // lbl_HanhKiem
            // 
            this.lbl_HanhKiem.AutoSize = true;
            this.lbl_HanhKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HanhKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HanhKiem.Location = new System.Drawing.Point(619, 34);
            this.lbl_HanhKiem.Name = "lbl_HanhKiem";
            this.lbl_HanhKiem.Size = new System.Drawing.Size(63, 15);
            this.lbl_HanhKiem.TabIndex = 14;
            this.lbl_HanhKiem.Text = "Hạnh kiểm";
            this.lbl_HanhKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_DiemTK
            // 
            this.lbl_DiemTK.AutoSize = true;
            this.lbl_DiemTK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiemTK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DiemTK.Location = new System.Drawing.Point(543, 82);
            this.lbl_DiemTK.Name = "lbl_DiemTK";
            this.lbl_DiemTK.Size = new System.Drawing.Size(81, 15);
            this.lbl_DiemTK.TabIndex = 13;
            this.lbl_DiemTK.Text = "Điểm tổng kết";
            this.lbl_DiemTK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_DiemTK
            // 
            this.txt_DiemTK.Location = new System.Drawing.Point(641, 79);
            this.txt_DiemTK.Name = "txt_DiemTK";
            this.txt_DiemTK.Size = new System.Drawing.Size(117, 22);
            this.txt_DiemTK.TabIndex = 12;
            // 
            // txt_DiemL1
            // 
            this.txt_DiemL1.Location = new System.Drawing.Point(422, 79);
            this.txt_DiemL1.Name = "txt_DiemL1";
            this.txt_DiemL1.Size = new System.Drawing.Size(100, 22);
            this.txt_DiemL1.TabIndex = 11;
            // 
            // lbl_DiemL1
            // 
            this.lbl_DiemL1.AutoSize = true;
            this.lbl_DiemL1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiemL1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DiemL1.Location = new System.Drawing.Point(319, 79);
            this.lbl_DiemL1.Name = "lbl_DiemL1";
            this.lbl_DiemL1.Size = new System.Drawing.Size(79, 15);
            this.lbl_DiemL1.TabIndex = 10;
            this.lbl_DiemL1.Text = "Điểm thi lần 1";
            this.lbl_DiemL1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_DiemTB
            // 
            this.txt_DiemTB.Location = new System.Drawing.Point(203, 79);
            this.txt_DiemTB.Name = "txt_DiemTB";
            this.txt_DiemTB.Size = new System.Drawing.Size(100, 22);
            this.txt_DiemTB.TabIndex = 9;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(322, 27);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(239, 22);
            this.txt_HoTen.TabIndex = 8;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(89, 27);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(100, 22);
            this.txt_MaSV.TabIndex = 7;
            // 
            // lbl_DiemTB
            // 
            this.lbl_DiemTB.AutoSize = true;
            this.lbl_DiemTB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiemTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DiemTB.Location = new System.Drawing.Point(120, 79);
            this.lbl_DiemTB.Name = "lbl_DiemTB";
            this.lbl_DiemTB.Size = new System.Drawing.Size(53, 15);
            this.lbl_DiemTB.TabIndex = 6;
            this.lbl_DiemTB.Text = "Điểm TB";
            this.lbl_DiemTB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HoTen.Location = new System.Drawing.Point(254, 34);
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
            // gB_GhiChu
            // 
            this.gB_GhiChu.Controls.Add(this.txt_GhiChu);
            this.gB_GhiChu.Location = new System.Drawing.Point(387, 59);
            this.gB_GhiChu.Name = "gB_GhiChu";
            this.gB_GhiChu.Size = new System.Drawing.Size(520, 143);
            this.gB_GhiChu.TabIndex = 8;
            this.gB_GhiChu.TabStop = false;
            this.gB_GhiChu.Text = "Ghi chú";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(7, 20);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(507, 110);
            this.txt_GhiChu.TabIndex = 0;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Nhap.Location = new System.Drawing.Point(943, 113);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(75, 23);
            this.btn_Nhap.TabIndex = 0;
            this.btn_Nhap.Text = "Thêm";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            // 
            // gB_DanhSach
            // 
            this.gB_DanhSach.Controls.Add(this.dgw_DiemSV);
            this.gB_DanhSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_DanhSach.Location = new System.Drawing.Point(12, 357);
            this.gB_DanhSach.Name = "gB_DanhSach";
            this.gB_DanhSach.Size = new System.Drawing.Size(1006, 143);
            this.gB_DanhSach.TabIndex = 10;
            this.gB_DanhSach.TabStop = false;
            this.gB_DanhSach.Text = "Danh sách";
            // 
            // dgw_DiemSV
            // 
            this.dgw_DiemSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_DiemSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.MaLop,
            this.MaMon,
            this.DiemTB,
            this.DiemThiLan1,
            this.DiemTongKet,
            this.HanhKiem,
            this.HocKi,
            this.GhiChu});
            this.dgw_DiemSV.Location = new System.Drawing.Point(1, 22);
            this.dgw_DiemSV.Name = "dgw_DiemSV";
            this.dgw_DiemSV.Size = new System.Drawing.Size(999, 114);
            this.dgw_DiemSV.TabIndex = 0;
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
            this.MaMon.HeaderText = "Mã môn ";
            this.MaMon.Name = "MaMon";
            // 
            // DiemTB
            // 
            this.DiemTB.HeaderText = "Điểm TB";
            this.DiemTB.Name = "DiemTB";
            // 
            // DiemThiLan1
            // 
            this.DiemThiLan1.HeaderText = "Điểm lần 1";
            this.DiemThiLan1.Name = "DiemThiLan1";
            // 
            // DiemTongKet
            // 
            this.DiemTongKet.HeaderText = "Điểm TK";
            this.DiemTongKet.Name = "DiemTongKet";
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
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(943, 157);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(943, 207);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(943, 257);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_InBangDiem
            // 
            this.btn_InBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InBangDiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_InBangDiem.Location = new System.Drawing.Point(943, 328);
            this.btn_InBangDiem.Name = "btn_InBangDiem";
            this.btn_InBangDiem.Size = new System.Drawing.Size(75, 23);
            this.btn_InBangDiem.TabIndex = 14;
            this.btn_InBangDiem.Text = "In điểm";
            this.btn_InBangDiem.UseVisualStyleBackColor = true;
            // 
            // frmQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 505);
            this.Controls.Add(this.btn_InBangDiem);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.gB_DanhSach);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.gB_GhiChu);
            this.Controls.Add(this.gB_TTChiTiet);
            this.Controls.Add(this.gB_LuaChon);
            this.Controls.Add(this.lbl_TTD);
            this.Name = "frmQLDiem";
            this.Text = "Nhập điểm sinh viên";
            this.gB_LuaChon.ResumeLayout(false);
            this.gB_LuaChon.PerformLayout();
            this.gB_TTChiTiet.ResumeLayout(false);
            this.gB_TTChiTiet.PerformLayout();
            this.gB_GhiChu.ResumeLayout(false);
            this.gB_GhiChu.PerformLayout();
            this.gB_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_DiemSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TTD;
        private System.Windows.Forms.GroupBox gB_LuaChon;
        private System.Windows.Forms.ComboBox cbo_MonHoc;
        private System.Windows.Forms.ComboBox cbo_HocKi;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private System.Windows.Forms.Label lbl_MonHoc;
        private System.Windows.Forms.Label lbl_HocKi;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.GroupBox gB_TTChiTiet;
        private System.Windows.Forms.TextBox txt_HanhKiem;
        private System.Windows.Forms.Label lbl_HanhKiem;
        private System.Windows.Forms.Label lbl_DiemTK;
        private System.Windows.Forms.TextBox txt_DiemTK;
        private System.Windows.Forms.TextBox txt_DiemL1;
        private System.Windows.Forms.Label lbl_DiemL1;
        private System.Windows.Forms.TextBox txt_DiemTB;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label lbl_DiemTB;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.GroupBox gB_GhiChu;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.GroupBox gB_DanhSach;
        private System.Windows.Forms.DataGridView dgw_DiemSV;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_InBangDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThiLan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}

