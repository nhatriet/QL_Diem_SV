namespace Project_DBMS_Final
{
    partial class frmGiangVien
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.cbo_Phanloai = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_MatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_XemChiTiet = new System.Windows.Forms.Button();
            this.txb_TaiKhoanGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.txb_HoTen = new System.Windows.Forms.TextBox();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.txb_MaGV = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_MaGV = new System.Windows.Forms.Label();
            this.dgw_TTGV = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_TTGV = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TTGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(14, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(102, 191);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(170, 22);
            this.txb_Email.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(14, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phân loại GV";
            // 
            // txb_Phone
            // 
            this.txb_Phone.Location = new System.Drawing.Point(102, 151);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(170, 22);
            this.txb_Phone.TabIndex = 4;
            // 
            // cbo_Phanloai
            // 
            this.cbo_Phanloai.FormattingEnabled = true;
            this.cbo_Phanloai.Items.AddRange(new object[] {
            "Chính thức",
            "Thỉnh giảng"});
            this.cbo_Phanloai.Location = new System.Drawing.Point(102, 231);
            this.cbo_Phanloai.Name = "cbo_Phanloai";
            this.cbo_Phanloai.Size = new System.Drawing.Size(121, 23);
            this.cbo_Phanloai.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_MatKhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_XemChiTiet);
            this.groupBox1.Controls.Add(this.txb_TaiKhoanGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_GioiTinh);
            this.groupBox1.Controls.Add(this.txb_HoTen);
            this.groupBox1.Controls.Add(this.lbl_GioiTinh);
            this.groupBox1.Controls.Add(this.txb_MaGV);
            this.groupBox1.Controls.Add(this.lbl_HoTen);
            this.groupBox1.Controls.Add(this.lbl_MaGV);
            this.groupBox1.Controls.Add(this.cbo_Phanloai);
            this.groupBox1.Controls.Add(this.txb_Phone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txb_Email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(11, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(547, 449);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txb_MatKhau
            // 
            this.txb_MatKhau.Location = new System.Drawing.Point(102, 313);
            this.txb_MatKhau.Name = "txb_MatKhau";
            this.txb_MatKhau.Size = new System.Drawing.Size(170, 22);
            this.txb_MatKhau.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mật khẩu";
            // 
            // bt_XemChiTiet
            // 
            this.bt_XemChiTiet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_XemChiTiet.Location = new System.Drawing.Point(85, 359);
            this.bt_XemChiTiet.Name = "bt_XemChiTiet";
            this.bt_XemChiTiet.Size = new System.Drawing.Size(107, 39);
            this.bt_XemChiTiet.TabIndex = 52;
            this.bt_XemChiTiet.Text = "Xem chi tiết";
            this.bt_XemChiTiet.UseVisualStyleBackColor = true;
            this.bt_XemChiTiet.Click += new System.EventHandler(this.bt_XemChiTiet_Click);
            // 
            // txb_TaiKhoanGV
            // 
            this.txb_TaiKhoanGV.Location = new System.Drawing.Point(102, 273);
            this.txb_TaiKhoanGV.Name = "txb_TaiKhoanGV";
            this.txb_TaiKhoanGV.Size = new System.Drawing.Size(170, 22);
            this.txb_TaiKhoanGV.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tài khoản";
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_GioiTinh.Location = new System.Drawing.Point(102, 111);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(90, 23);
            this.cbo_GioiTinh.TabIndex = 47;
            // 
            // txb_HoTen
            // 
            this.txb_HoTen.Location = new System.Drawing.Point(102, 71);
            this.txb_HoTen.Name = "txb_HoTen";
            this.txb_HoTen.Size = new System.Drawing.Size(124, 22);
            this.txb_HoTen.TabIndex = 46;
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_GioiTinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(14, 119);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(52, 15);
            this.lbl_GioiTinh.TabIndex = 43;
            this.lbl_GioiTinh.Text = "Giới tính";
            this.lbl_GioiTinh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_MaGV
            // 
            this.txb_MaGV.Location = new System.Drawing.Point(102, 32);
            this.txb_MaGV.Name = "txb_MaGV";
            this.txb_MaGV.Size = new System.Drawing.Size(124, 22);
            this.txb_MaGV.TabIndex = 41;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HoTen.Location = new System.Drawing.Point(14, 78);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(62, 15);
            this.lbl_HoTen.TabIndex = 40;
            this.lbl_HoTen.Text = "Họ và tên ";
            this.lbl_HoTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_MaGV
            // 
            this.lbl_MaGV.AutoSize = true;
            this.lbl_MaGV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MaGV.Location = new System.Drawing.Point(14, 39);
            this.lbl_MaGV.Name = "lbl_MaGV";
            this.lbl_MaGV.Size = new System.Drawing.Size(84, 15);
            this.lbl_MaGV.TabIndex = 39;
            this.lbl_MaGV.Text = "Mã giảng viên";
            this.lbl_MaGV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgw_TTGV
            // 
            this.dgw_TTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_TTGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.HoTen,
            this.GioiTinh,
            this.Phone,
            this.Email,
            this.PLGV,
            this.TK});
            this.dgw_TTGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_TTGV.Location = new System.Drawing.Point(2, 17);
            this.dgw_TTGV.Name = "dgw_TTGV";
            this.dgw_TTGV.Size = new System.Drawing.Size(770, 430);
            this.dgw_TTGV.TabIndex = 0;
            this.dgw_TTGV.SelectionChanged += new System.EventHandler(this.dgw_TTGV_SelectionChanged);
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaGV.DataPropertyName = "MAGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.Name = "MaGV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HOTEN";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.DataPropertyName = "GIOITINH";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "SODIENTHOAI";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "EMAIL";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // PLGV
            // 
            this.PLGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLGV.DataPropertyName = "PHANLOAI";
            this.PLGV.HeaderText = "Phân loại";
            this.PLGV.Name = "PLGV";
            // 
            // TK
            // 
            this.TK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TK.DataPropertyName = "TAIKHOAN_GV";
            this.TK.HeaderText = "Tài khoản";
            this.TK.Name = "TK";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgw_TTGV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(292, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(774, 449);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // lbl_TTGV
            // 
            this.lbl_TTGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TTGV.AutoSize = true;
            this.lbl_TTGV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TTGV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_TTGV.Location = new System.Drawing.Point(495, 19);
            this.lbl_TTGV.Name = "lbl_TTGV";
            this.lbl_TTGV.Size = new System.Drawing.Size(241, 22);
            this.lbl_TTGV.TabIndex = 20;
            this.lbl_TTGV.Text = "THÔNG TIN GIẢNG VIÊN";
            this.lbl_TTGV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(1097, 304);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 30);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(1097, 253);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 31);
            this.btn_Sua.TabIndex = 22;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Nhap.Location = new System.Drawing.Point(1097, 205);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(75, 29);
            this.btn_Nhap.TabIndex = 21;
            this.btn_Nhap.Text = "Thêm";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 516);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.lbl_TTGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiangVien";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TTGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txb_Phone;
        private System.Windows.Forms.ComboBox cbo_Phanloai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_TTGV;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.TextBox txb_HoTen;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.TextBox txb_MaGV;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_MaGV;
        private System.Windows.Forms.Button bt_XemChiTiet;
        private System.Windows.Forms.TextBox txb_TaiKhoanGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TK;
        private System.Windows.Forms.TextBox txb_MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgw_TTGV;
    }
}