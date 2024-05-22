using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS_Final
{
    public partial class frmLop : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;

        public frmLop()
        {
            InitializeComponent();
        }
        private void dgw_Lop_Load()
        {
            dgw_Lop.DataSource = DataProvider.Instance.ExecuteQuery(" exec dbo.USP_Query_lophoc");
            dgw_Lop.ReadOnly = true;
            dgw_Lop.AllowUserToDeleteRows = false;
            dgw_Lop.AllowUserToAddRows = false;
            dgw_Lop.Columns[0].Width = 70;
            dgw_Lop.Columns[1].Width = 180;
            dgw_Lop.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            dgw_Lop_Load();
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            DataTable checkLopHoc = DataProvider.Instance.ExecuteQuery("exec dbo.Check_Exists_LopHoc @tenlop", new object[] {
                txb_Tenlop.Text,
            });
            if (string.IsNullOrWhiteSpace(txb_MaLop.Text) || string.IsNullOrWhiteSpace(txb_Tenlop.Text) ||
               string.IsNullOrWhiteSpace(txb_GVQL.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else
            {
                if (checkLopHoc.Rows.Count > 0)
                {
                    MessageBox.Show("Lớp học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                string mutation = "exec dbo.USP_Mutation_AddLopHoc @malop, @tenlop, @gvql";
                DataProvider.Instance.ExecuteNonQuery(mutation, new object[]
                {
                txb_MaLop.Text,
                txb_Tenlop.Text,
                txb_GVQL.Text
                });
                dgw_Lop_Load();
            }
            txb_MaLop.Text = " ";
            txb_Tenlop.Text = " ";
            txb_GVQL.Text = " ";
        }

        private void dgw_Lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgw_Lop.Rows[e.RowIndex];

            txb_MaLop.Text = Convert.ToString(row.Cells["Mã lớp"].Value);
            txb_Tenlop.Text = Convert.ToString(row.Cells["Tên lớp"].Value);
            txb_GVQL.Text = Convert.ToString(row.Cells["Giảng viên quản lý"].Value);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string mutation = "exec dbo.USP_Mutation_UpdateLopHoc @malop, @tenlop, @gvql";
            int result = DataProvider.Instance.ExecuteNonQuery(mutation, new object[]
            {
                txb_MaLop.Text,
                txb_Tenlop.Text,
                txb_GVQL.Text
            });
            if (result <= 0)
            {
                MessageBox.Show("Sửa thông tin lớp học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            dgw_Lop_Load();
            txb_MaLop.Text = " ";
            txb_Tenlop.Text = " ";
            txb_GVQL.Text = " ";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string mutation = "exec dbo.USP_Mutation_DeleteLopHoc @malop ";

            DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                int result = DataProvider.Instance.ExecuteNonQuery(mutation, new object[]
                {
                    txb_MaLop.Text
                });
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgw_Lop_Load();
                txb_MaLop.Text = " ";
                txb_Tenlop.Text = " ";
                txb_GVQL.Text = " ";
            }
            else
            {
                return;
            }    
        }
    }
}
