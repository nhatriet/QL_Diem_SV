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
    public partial class frmGiangVienDayMH : Form
    {
        private string maGiangVien;
        public frmGiangVienDayMH(string maGV)
        {
            InitializeComponent();
            maGiangVien = maGV;
        }

        private void bt_TroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmGiangVienDayMH_Load(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("sp_ThongTinMH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@magv", maGiangVien);
            // Thêm tham số vào stored procedure
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgv_DanhSach.DataSource = dtable;
            dgv_DanhSach.Refresh();
        }

        private void LoadData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("sp_ThongTinMH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@magv", maGiangVien);
            // Thêm tham số vào stored procedure
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgv_DanhSach.DataSource = dtable;
            dgv_DanhSach.Refresh();
        }

        private bool KiemTraMHTonTai(string magv, string mamonhoc)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM GIANGVIEN_DAY_MONHOC WHERE MAGV = @magv " +
                                            "AND MAMONHOC = @mamonhoc", conn);
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@mamonhoc", mamonhoc);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;

        }
        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_MaMH.Text))
            {
                MessageBox.Show("Vui lòng chọn mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string magv = txb_MAGV.Text;
                string mamonhoc = cbo_MaMH.Text;
                if (KiemTraMHTonTai(magv, mamonhoc))
                {
                    MessageBox.Show("Môn học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    ConnectDB connectDB = new ConnectDB();
                    SqlConnection conn = connectDB.getConnect();
                    SqlCommand cmd = new SqlCommand("sp_ThemMonHocChoGiangVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@magv", txb_MAGV.Text);
                    cmd.Parameters.AddWithValue("@mamonhoc", cbo_MaMH.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            cbo_MaMH.Text = " ";
        }

        private void dgv_DanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSach.SelectedRows.Count > 0)
            {
                // Lấy giá trị từ các ô dữ liệu của dòng đang chọn trong DataGridView
                string magv = dgv_DanhSach.SelectedRows[0].Cells["MaGV"].Value.ToString();
                string hoten = dgv_DanhSach.SelectedRows[0].Cells["HoTen"].Value.ToString();
                string mamonhoc = dgv_DanhSach.SelectedRows[0].Cells["MaMH"].Value.ToString();
                txb_MAGV.Text = magv;
                txb_HoTen.Text = hoten;
                cbo_MaMH.Text = mamonhoc;
            }    
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSach.SelectedRows.Count > 0)
            {
                // Lấy giá trị mã giảng viên (MAGV) từ hàng đang chọn trong DataGridView
                string magv = dgv_DanhSach.SelectedRows[0].Cells["MaGV"].Value.ToString();
                ConnectDB connectDB = new ConnectDB();
                SqlConnection conn = connectDB.getConnect();
                SqlCommand cmd = new SqlCommand("sp_XoaMonHocCuaGiangVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@magv", magv);
                cmd.Parameters.AddWithValue("@mamonhoc", cbo_MaMH.Text);
                conn.Open();
                DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txb_MAGV.Text = " ";
                    txb_HoTen.Text = " ";
                    cbo_MaMH.Text = " ";
                }
                else
                {
                    return;
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
