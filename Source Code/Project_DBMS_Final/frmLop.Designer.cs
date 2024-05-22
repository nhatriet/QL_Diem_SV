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
            this.components = new System.ComponentModel.Container();
            this.gB_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgw_Lop = new System.Windows.Forms.DataGridView();
            this.gB_LuaChon = new System.Windows.Forms.GroupBox();
            this.txb_GVQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_MaLop = new System.Windows.Forms.TextBox();
            this.txb_Tenlop = new System.Windows.Forms.TextBox();
            this.lbl_TenLop = new System.Windows.Forms.Label();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.lbl_LOP = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gB_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Lop)).BeginInit();
            this.gB_LuaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gB_DanhSach
            // 
            this.gB_DanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_DanhSach.Controls.Add(this.dgw_Lop);
            this.gB_DanhSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_DanhSach.Location = new System.Drawing.Point(372, 63);
            this.gB_DanhSach.Name = "gB_DanhSach";
            this.gB_DanhSach.Size = new System.Drawing.Size(444, 335);
            this.gB_DanhSach.TabIndex = 26;
            this.gB_DanhSach.TabStop = false;
            this.gB_DanhSach.Text = "Danh sách";
            // 
            // dgw_Lop
            // 
            this.dgw_Lop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgw_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Lop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_Lop.Location = new System.Drawing.Point(3, 18);
            this.dgw_Lop.Name = "dgw_Lop";
            this.dgw_Lop.Size = new System.Drawing.Size(438, 314);
            this.dgw_Lop.TabIndex = 0;
            this.dgw_Lop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Lop_CellContentClick);
            // 
            // gB_LuaChon
            // 
            this.gB_LuaChon.Controls.Add(this.txb_GVQL);
            this.gB_LuaChon.Controls.Add(this.label1);
            this.gB_LuaChon.Controls.Add(this.txb_MaLop);
            this.gB_LuaChon.Controls.Add(this.txb_Tenlop);
            this.gB_LuaChon.Controls.Add(this.lbl_TenLop);
            this.gB_LuaChon.Controls.Add(this.lbl_MaLop);
            this.gB_LuaChon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_LuaChon.Location = new System.Drawing.Point(12, 63);
            this.gB_LuaChon.Name = "gB_LuaChon";
            this.gB_LuaChon.Size = new System.Drawing.Size(346, 159);
            this.gB_LuaChon.TabIndex = 25;
            this.gB_LuaChon.TabStop = false;
            this.gB_LuaChon.Text = "Lựa chọn";
            // 
            // txb_GVQL
            // 
            this.txb_GVQL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_GVQL.Location = new System.Drawing.Point(124, 122);
            this.txb_GVQL.Name = "txb_GVQL";
            this.txb_GVQL.Size = new System.Drawing.Size(208, 22);
            this.txb_GVQL.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giảng viên quản lý";
            // 
            // txb_MaLop
            // 
            this.txb_MaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaLop.Location = new System.Drawing.Point(124, 39);
            this.txb_MaLop.Name = "txb_MaLop";
            this.txb_MaLop.Size = new System.Drawing.Size(208, 22);
            this.txb_MaLop.TabIndex = 1;
            // 
            // txb_Tenlop
            // 
            this.txb_Tenlop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Tenlop.Location = new System.Drawing.Point(124, 80);
            this.txb_Tenlop.Name = "txb_Tenlop";
            this.txb_Tenlop.Size = new System.Drawing.Size(208, 22);
            this.txb_Tenlop.TabIndex = 2;
            // 
            // lbl_TenLop
            // 
            this.lbl_TenLop.AutoSize = true;
            this.lbl_TenLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenLop.Location = new System.Drawing.Point(11, 87);
            this.lbl_TenLop.Name = "lbl_TenLop";
            this.lbl_TenLop.Size = new System.Drawing.Size(48, 15);
            this.lbl_TenLop.TabIndex = 4;
            this.lbl_TenLop.Text = "Tên lớp";
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLop.Location = new System.Drawing.Point(11, 46);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(45, 15);
            this.lbl_MaLop.TabIndex = 0;
            this.lbl_MaLop.Text = "Mã lớp";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(850, 262);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 33);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(850, 215);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 30);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Nhap.Location = new System.Drawing.Point(850, 162);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(75, 33);
            this.btn_Nhap.TabIndex = 14;
            this.btn_Nhap.Text = "Thêm";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // lbl_LOP
            // 
            this.lbl_LOP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_LOP.AutoSize = true;
            this.lbl_LOP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_LOP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_LOP.Location = new System.Drawing.Point(399, 18);
            this.lbl_LOP.Name = "lbl_LOP";
            this.lbl_LOP.Size = new System.Drawing.Size(139, 22);
            this.lbl_LOP.TabIndex = 27;
            this.lbl_LOP.Text = "QUẢN LÝ LỚP";
            this.lbl_LOP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 403);
            this.Controls.Add(this.lbl_LOP);
            this.Controls.Add(this.gB_DanhSach);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.gB_LuaChon);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Nhap);
            this.Name = "frmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp học";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.gB_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Lop)).EndInit();
            this.gB_LuaChon.ResumeLayout(false);
            this.gB_LuaChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gB_DanhSach;
        private System.Windows.Forms.DataGridView dgw_Lop;
        private System.Windows.Forms.GroupBox gB_LuaChon;
        private System.Windows.Forms.TextBox txb_MaLop;
        private System.Windows.Forms.TextBox txb_Tenlop;
        private System.Windows.Forms.Label lbl_TenLop;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Label lbl_LOP;
        private System.Windows.Forms.TextBox txb_GVQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}