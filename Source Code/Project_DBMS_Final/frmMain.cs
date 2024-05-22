using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS_Final
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnu_Trangchu_Click(object sender, EventArgs e)
        {
            frmMain formMain = new frmMain();
            formMain.Show();
            this.Hide();
        }

        private void mnu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddForm(Form f)
        {
            this.panel_Content.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel_Content.Controls.Add(f);
            this.panel_Content.BringToFront();
            f.Show();
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiangVien formGiangVien = new frmGiangVien();
            AddForm(formGiangVien);
        }

        private void mnu_Mon_Click(object sender, EventArgs e)
        {
            frmMonhoc formMonHoc = new frmMonhoc();
            AddForm(formMonHoc);
        }

        private void mnu_Lop_Click(object sender, EventArgs e)
        {
            frmLop formLop = new frmLop();
            AddForm(formLop);
        }

        private void mnu_SV_Click(object sender, EventArgs e)
        {
            frmQLSV formQLSV = new frmQLSV();
            AddForm(formQLSV);
        }

        private void mnu_Diem_Click(object sender, EventArgs e)
        {
            frmQLDiem formQLDiem = new frmQLDiem();
            AddForm(formQLDiem);
        }

        private void mnu_ThongtinSV_Click(object sender, EventArgs e)
        {
            frmTimDiemSV formTimDiemSV = new frmTimDiemSV();
            AddForm(formTimDiemSV);
        }

        private void bt_QLSV_Click(object sender, EventArgs e)
        {
            frmQLSV formQLSV = new frmQLSV();
            AddForm(formQLSV);
        }

        private void bt_QLGV_Click(object sender, EventArgs e)
        {
            frmGiangVien formGiangVien = new frmGiangVien();
            AddForm(formGiangVien);
        }

        private void bt_QLDSV_Click(object sender, EventArgs e)
        {
            frmQLDiem formQLDiem = new frmQLDiem();
            AddForm(formQLDiem);
        }

        private void bt_LOP_Click(object sender, EventArgs e)
        {
            frmLop formLop = new frmLop();
            AddForm(formLop);
        }

        private void bt_MH_Click(object sender, EventArgs e)
        {
            frmMonhoc formMonHoc = new frmMonhoc();
            AddForm(formMonHoc);
        }

        private void mnu_DiemTK_Click(object sender, EventArgs e)
        {
            frmThongKe formThongKe = new frmThongKe();
            AddForm(formThongKe);
        }
    }
}
