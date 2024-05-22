namespace Project_DBMS_Final
{
    partial class frmMonhoc
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
            this.gB_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgw_MonHoc = new System.Windows.Forms.DataGridView();
            this.gB_TTCT = new System.Windows.Forms.GroupBox();
            this.txt_HocKy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_DSMH = new System.Windows.Forms.Label();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.lbl_MaGV = new System.Windows.Forms.Label();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gB_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MonHoc)).BeginInit();
            this.gB_TTCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_DanhSach
            // 
            this.gB_DanhSach.Controls.Add(this.dgw_MonHoc);
            this.gB_DanhSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_DanhSach.Location = new System.Drawing.Point(286, 78);
            this.gB_DanhSach.Name = "gB_DanhSach";
            this.gB_DanhSach.Size = new System.Drawing.Size(461, 367);
            this.gB_DanhSach.TabIndex = 15;
            this.gB_DanhSach.TabStop = false;
            this.gB_DanhSach.Text = "Danh sách";
            // 
            // dgw_MonHoc
            // 
            this.dgw_MonHoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgw_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.HocKy,
            this.MaGV});
            this.dgw_MonHoc.Location = new System.Drawing.Point(6, 19);
            this.dgw_MonHoc.Name = "dgw_MonHoc";
            this.dgw_MonHoc.Size = new System.Drawing.Size(446, 342);
            this.dgw_MonHoc.TabIndex = 0;
            // 
            // gB_TTCT
            // 
            this.gB_TTCT.Controls.Add(this.txt_MaGV);
            this.gB_TTCT.Controls.Add(this.lbl_MaGV);
            this.gB_TTCT.Controls.Add(this.txt_HocKy);
            this.gB_TTCT.Controls.Add(this.label5);
            this.gB_TTCT.Controls.Add(this.txt_TenMon);
            this.gB_TTCT.Controls.Add(this.label2);
            this.gB_TTCT.Controls.Add(this.txt_MaMon);
            this.gB_TTCT.Controls.Add(this.label7);
            this.gB_TTCT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_TTCT.Location = new System.Drawing.Point(11, 78);
            this.gB_TTCT.Margin = new System.Windows.Forms.Padding(2);
            this.gB_TTCT.Name = "gB_TTCT";
            this.gB_TTCT.Padding = new System.Windows.Forms.Padding(2);
            this.gB_TTCT.Size = new System.Drawing.Size(262, 367);
            this.gB_TTCT.TabIndex = 14;
            this.gB_TTCT.TabStop = false;
            this.gB_TTCT.Text = "Thông tin chi tiết";
            // 
            // txt_HocKy
            // 
            this.txt_HocKy.Location = new System.Drawing.Point(93, 128);
            this.txt_HocKy.Name = "txt_HocKy";
            this.txt_HocKy.Size = new System.Drawing.Size(145, 22);
            this.txt_HocKy.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Học kỳ";
            // 
            // txt_TenMon
            // 
            this.txt_TenMon.Location = new System.Drawing.Point(93, 77);
            this.txt_TenMon.Name = "txt_TenMon";
            this.txt_TenMon.Size = new System.Drawing.Size(145, 22);
            this.txt_TenMon.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên môn";
            // 
            // txt_MaMon
            // 
            this.txt_MaMon.Location = new System.Drawing.Point(93, 31);
            this.txt_MaMon.Name = "txt_MaMon";
            this.txt_MaMon.Size = new System.Drawing.Size(145, 22);
            this.txt_MaMon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã môn";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(774, 316);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 21;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(774, 249);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(774, 194);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(774, 138);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // lbl_DSMH
            // 
            this.lbl_DSMH.AutoSize = true;
            this.lbl_DSMH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DSMH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_DSMH.Location = new System.Drawing.Point(325, 28);
            this.lbl_DSMH.Name = "lbl_DSMH";
            this.lbl_DSMH.Size = new System.Drawing.Size(222, 22);
            this.lbl_DSMH.TabIndex = 22;
            this.lbl_DSMH.Text = "DANH SÁCH MÔN HỌC";
            this.lbl_DSMH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Location = new System.Drawing.Point(93, 172);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(145, 22);
            this.txt_MaGV.TabIndex = 23;
            // 
            // lbl_MaGV
            // 
            this.lbl_MaGV.AutoSize = true;
            this.lbl_MaGV.Location = new System.Drawing.Point(8, 179);
            this.lbl_MaGV.Name = "lbl_MaGV";
            this.lbl_MaGV.Size = new System.Drawing.Size(44, 15);
            this.lbl_MaGV.TabIndex = 22;
            this.lbl_MaGV.Text = "Mã GV";
            // 
            // MaMon
            // 
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.Name = "MaMon";
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "Tên môn";
            this.TenMon.Name = "TenMon";
            // 
            // HocKy
            // 
            this.HocKy.HeaderText = "Học kỳ";
            this.HocKy.Name = "HocKy";
            // 
            // MaGV
            // 
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.Name = "MaGV";
            // 
            // frmMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.lbl_DSMH);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.gB_DanhSach);
            this.Controls.Add(this.gB_TTCT);
            this.Name = "frmMonhoc";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmMonhoc_Load);
            this.gB_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MonHoc)).EndInit();
            this.gB_TTCT.ResumeLayout(false);
            this.gB_TTCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gB_DanhSach;
        private System.Windows.Forms.DataGridView dgw_MonHoc;
        private System.Windows.Forms.GroupBox gB_TTCT;
        private System.Windows.Forms.TextBox txt_HocKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_DSMH;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.Label lbl_MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
    }
}