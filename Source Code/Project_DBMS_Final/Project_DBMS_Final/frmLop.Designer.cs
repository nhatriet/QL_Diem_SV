namespace Project_DBMS_Final
{
    partial class frmLop
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
            this.dgw_Lop = new System.Windows.Forms.DataGridView();
            this.gB_LuaChon = new System.Windows.Forms.GroupBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txt_Tenlop = new System.Windows.Forms.TextBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.lbl_LOP = new System.Windows.Forms.Label();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gB_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Lop)).BeginInit();
            this.gB_LuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_DanhSach
            // 
            this.gB_DanhSach.Controls.Add(this.dgw_Lop);
            this.gB_DanhSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_DanhSach.Location = new System.Drawing.Point(372, 63);
            this.gB_DanhSach.Name = "gB_DanhSach";
            this.gB_DanhSach.Size = new System.Drawing.Size(262, 335);
            this.gB_DanhSach.TabIndex = 26;
            this.gB_DanhSach.TabStop = false;
            this.gB_DanhSach.Text = "Danh sách";
            // 
            // dgw_Lop
            // 
            this.dgw_Lop.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgw_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop});
            this.dgw_Lop.Location = new System.Drawing.Point(6, 18);
            this.dgw_Lop.Name = "dgw_Lop";
            this.dgw_Lop.Size = new System.Drawing.Size(246, 311);
            this.dgw_Lop.TabIndex = 0;
            // 
            // gB_LuaChon
            // 
            this.gB_LuaChon.Controls.Add(this.txt_MaLop);
            this.gB_LuaChon.Controls.Add(this.txt_Tenlop);
            this.gB_LuaChon.Controls.Add(this.lbl_TenLop);
            this.gB_LuaChon.Controls.Add(this.lbl_MaLop);
            this.gB_LuaChon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_LuaChon.Location = new System.Drawing.Point(12, 63);
            this.gB_LuaChon.Name = "gB_LuaChon";
            this.gB_LuaChon.Size = new System.Drawing.Size(346, 162);
            this.gB_LuaChon.TabIndex = 25;
            this.gB_LuaChon.TabStop = false;
            this.gB_LuaChon.Text = "Lựa chọn";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLop.Location = new System.Drawing.Point(79, 56);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(208, 22);
            this.txt_MaLop.TabIndex = 1;
            // 
            // txt_Tenlop
            // 
            this.txt_Tenlop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tenlop.Location = new System.Drawing.Point(79, 106);
            this.txt_Tenlop.Name = "txt_Tenlop";
            this.txt_Tenlop.Size = new System.Drawing.Size(208, 22);
            this.txt_Tenlop.TabIndex = 2;
            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenLop.Location = new System.Drawing.Point(5, 106);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(48, 15);
            this.lbl_TenLop.TabIndex = 4;
            this.lbl_TenLop.Text = "Tên lớp";
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLop.Location = new System.Drawing.Point(8, 56);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(45, 15);
            this.lbl_MaLop.TabIndex = 0;
            this.lbl_MaLop.Text = "Mã lớp";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(683, 300);
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
            this.btn_Xoa.Location = new System.Drawing.Point(683, 243);
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
            this.btn_Sua.Location = new System.Drawing.Point(683, 188);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Nhap.Location = new System.Drawing.Point(683, 132);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(75, 23);
            this.btn_Nhap.TabIndex = 14;
            this.btn_Nhap.Text = "Thêm";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            // 
            // lbl_LOP
            // 
            this.lbl_LOP.AutoSize = true;
            this.lbl_LOP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_LOP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_LOP.Location = new System.Drawing.Point(321, 18);
            this.lbl_LOP.Name = "lbl_LOP";
            this.lbl_LOP.Size = new System.Drawing.Size(139, 22);
            this.lbl_LOP.TabIndex = 27;
            this.lbl_LOP.Text = "QUẢN LÝ LỚP";
            this.lbl_LOP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            // 
            // TenLop
            // 
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.Name = "TenLop";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.lbl_LOP);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.gB_DanhSach);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.gB_LuaChon);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Nhap);
            this.Name = "frmLop";
            this.Text = "Lớp học";
            this.gB_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Lop)).EndInit();
            this.gB_LuaChon.ResumeLayout(false);
            this.gB_LuaChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gB_DanhSach;
        private System.Windows.Forms.DataGridView dgw_Lop;
        private System.Windows.Forms.GroupBox gB_LuaChon;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.TextBox txt_Tenlop;
        private System.Windows.Forms.Label lbl_TenLop;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Label lbl_LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
    }
}