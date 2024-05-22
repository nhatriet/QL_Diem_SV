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
            this.components = new System.ComponentModel.Container();
            this.gB_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgw_MonHoc = new System.Windows.Forms.DataGridView();
            this.gB_TTCT = new System.Windows.Forms.GroupBox();
            this.txb_HocKy = new System.Windows.Forms.TextBox();
            this.txb_SoTC = new System.Windows.Forms.TextBox();
            this.lbl_SoTC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_TenMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_MaMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_DSMH = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gB_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MonHoc)).BeginInit();
            this.gB_TTCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gB_DanhSach
            // 
            this.gB_DanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgw_MonHoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgw_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_MonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_MonHoc.Location = new System.Drawing.Point(3, 18);
            this.dgw_MonHoc.Name = "dgw_MonHoc";
            this.dgw_MonHoc.Size = new System.Drawing.Size(455, 346);
            this.dgw_MonHoc.TabIndex = 0;
            this.dgw_MonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_MonHoc_CellContentClick);
            // 
            // gB_TTCT
            // 
            this.gB_TTCT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gB_TTCT.Controls.Add(this.txb_HocKy);
            this.gB_TTCT.Controls.Add(this.txb_SoTC);
            this.gB_TTCT.Controls.Add(this.lbl_SoTC);
            this.gB_TTCT.Controls.Add(this.label5);
            this.gB_TTCT.Controls.Add(this.txb_TenMon);
            this.gB_TTCT.Controls.Add(this.label2);
            this.gB_TTCT.Controls.Add(this.txb_MaMon);
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
            // txb_HocKy
            // 
            this.txb_HocKy.Location = new System.Drawing.Point(93, 171);
            this.txb_HocKy.Name = "txb_HocKy";
            this.txb_HocKy.Size = new System.Drawing.Size(145, 22);
            this.txb_HocKy.TabIndex = 24;
            // 
            // txb_SoTC
            // 
            this.txb_SoTC.Location = new System.Drawing.Point(93, 128);
            this.txb_SoTC.Name = "txb_SoTC";
            this.txb_SoTC.Size = new System.Drawing.Size(145, 22);
            this.txb_SoTC.TabIndex = 23;
            // 
            // lbl_SoTC
            // 
            this.lbl_SoTC.AutoSize = true;
            this.lbl_SoTC.Location = new System.Drawing.Point(14, 131);
            this.lbl_SoTC.Name = "lbl_SoTC";
            this.lbl_SoTC.Size = new System.Drawing.Size(57, 15);
            this.lbl_SoTC.TabIndex = 22;
            this.lbl_SoTC.Text = "Số tín chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Học kỳ";
            // 
            // txb_TenMon
            // 
            this.txb_TenMon.Location = new System.Drawing.Point(93, 77);
            this.txb_TenMon.Name = "txb_TenMon";
            this.txb_TenMon.Size = new System.Drawing.Size(145, 22);
            this.txb_TenMon.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên môn";
            // 
            // txb_MaMon
            // 
            this.txb_MaMon.Location = new System.Drawing.Point(93, 31);
            this.txb_MaMon.Name = "txb_MaMon";
            this.txb_MaMon.Size = new System.Drawing.Size(145, 22);
            this.txb_MaMon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã môn";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(774, 299);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 36);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(774, 245);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 36);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(774, 185);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 39);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_DSMH
            // 
            this.lbl_DSMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.lbl_DSMH);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.gB_DanhSach);
            this.Controls.Add(this.gB_TTCT);
            this.Name = "frmMonhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmMonhoc_Load);
            this.gB_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MonHoc)).EndInit();
            this.gB_TTCT.ResumeLayout(false);
            this.gB_TTCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gB_DanhSach;
        private System.Windows.Forms.DataGridView dgw_MonHoc;
        private System.Windows.Forms.GroupBox gB_TTCT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_TenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_MaMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_DSMH;
        private System.Windows.Forms.Label lbl_SoTC;
        private System.Windows.Forms.TextBox txb_HocKy;
        private System.Windows.Forms.TextBox txb_SoTC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}