using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS_Final
{
    public partial class frmMonhoc : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;

        public frmMonhoc()
        {
            InitializeComponent();
        }

        private void dgw_MonHoc_Load()
        {
            dgw_MonHoc.DataSource = DataProvider.Instance.ExecuteQuery(" exec dbo.USP_Query_monhoc");
            dgw_MonHoc.ReadOnly = true;
            dgw_MonHoc.AllowUserToDeleteRows = false;
            dgw_MonHoc.AllowUserToAddRows = false;
            dgw_MonHoc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgw_MonHoc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgw_MonHoc.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgw_MonHoc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgw_MonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgw_MonHoc.Rows[e.RowIndex];
            /*
            txb_MaMon.Text = dgw_MonHoc.CurrentRow.Cells[0].Value.ToString();
            txb_TenMon.Text = dgw_MonHoc.CurrentRow.Cells[1].Value.ToString();
            txb_SoTC.Text = dgw_MonHoc.CurrentRow.Cells[2].Value.ToString();
            txb_HocKy.Text = dgw_MonHoc.CurrentRow.Cells[3].Value.ToString();
            */
            txb_MaMon.Text = Convert.ToString(row.Cells["Mã môn học"].Value);
            txb_TenMon.Text = Convert.ToString(row.Cells["Tên môn học"].Value);
            txb_SoTC.Text = Convert.ToString(row.Cells["Số tín chỉ"].Value);
            txb_HocKy.Text = Convert.ToString(row.Cells["Học kỳ"].Value);
        }
        

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataTable checkMonnHoc = DataProvider.Instance.ExecuteQuery("exec dbo.Check_Exists_MonHoc @tenmh", new object[] {
                txb_TenMon.Text,
            });
            if (string.IsNullOrWhiteSpace(txb_MaMon.Text) || string.IsNullOrWhiteSpace(txb_TenMon.Text) ||
                string.IsNullOrWhiteSpace(txb_SoTC.Text) || string.IsNullOrWhiteSpace(txb_HocKy.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else
            {
                if (checkMonnHoc.Rows.Count > 0)
                {
                    MessageBox.Show("Môn học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }

                string mutation = "exec dbo.USP_Mutation_AddMonHoc @mamh, @tenmh, @sotc, @hocky";
                DataProvider.Instance.ExecuteNonQuery(mutation, new object[]
                {
                txb_MaMon.Text,
                txb_TenMon.Text,
                txb_SoTC.Text,
                txb_HocKy.Text
                });
                dgw_MonHoc_Load();
            }
            txb_MaMon.Text = " ";
            txb_TenMon.Text = " ";
            txb_SoTC.Text = " ";
            txb_HocKy.Text = " ";
        }

        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            dgw_MonHoc_Load();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string mutation = "exec dbo.USP_Mutation_UpdateMonHoc @mamh, @tenmh, @sotc, @hocky";
            int result = DataProvider.Instance.ExecuteNonQuery(mutation, new object[]
            {
                txb_MaMon.Text,
                txb_TenMon.Text,
                txb_SoTC.Text,
                txb_HocKy.Text
            });
            if (result <= 0)
            {
                MessageBox.Show("Sửa thông tin môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            dgw_MonHoc_Load();
            txb_MaMon.Text = " ";
            txb_TenMon.Text = " ";
            txb_SoTC.Text = " ";
            txb_HocKy.Text = " ";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string mutation = "exec dbo.USP_Mutation_DeleteMonHoc @mamh ";

            DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                int result = DataProvider.Instance.ExecuteNonQuery(mutation, new object[]
                {
                    txb_MaMon.Text
                });
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgw_MonHoc_Load();
                txb_MaMon.Text = " ";
                txb_TenMon.Text = " ";
                txb_SoTC.Text = " ";
                txb_HocKy.Text = " ";
            }
            else
            {
                return;
            }
                
        }
       
    }
}
