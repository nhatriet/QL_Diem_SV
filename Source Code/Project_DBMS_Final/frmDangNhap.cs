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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if(Show_Hide.Checked)
            {
                txbMatKhau.UseSystemPasswordChar = true;
            }    
            else
            {
                txbMatKhau.UseSystemPasswordChar = false;
            }    
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            frmMain formMain = new frmMain();
            formMain.Show();
            this.Hide();
        }
    }
}
