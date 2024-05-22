using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS_Final
{
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void bt_XemChiTiet_Click(object sender, EventArgs e)
        {
            string selectedRow = Selected();
            frmGiangVienDayMH formGVDMH = new frmGiangVienDayMH(selectedRow);
            formGVDMH.Show();
        }

        private string Selected()
        {
            int selectedIndex = dgw_TTGV.SelectedCells[0].RowIndex; ;
            DataGridViewRow selected = dgw_TTGV.Rows[selectedIndex];
            string selectedMaGV = selected.Cells[0].Value.ToString();
            return selectedMaGV;
        }

        private void LoadData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            string query = "SELECT * FROM GIANGVIEN";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TTGV.DataSource = dtable;
            dgw_TTGV.Refresh();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            string query = "EXEC sp_GiangVien";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TTGV.DataSource = dtable;
            dgw_TTGV.Refresh();
        }

        private bool KiemTraGVTonTai(string magv)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM GIANGVIEN WHERE MAGV = @magv", conn);
            cmd.Parameters.AddWithValue("@magv", magv);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;

        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_MaGV.Text) || string.IsNullOrWhiteSpace(txb_HoTen.Text) ||
                string.IsNullOrWhiteSpace(cbo_GioiTinh.Text) || string.IsNullOrWhiteSpace(txb_Phone.Text) ||
                string.IsNullOrWhiteSpace(txb_Email.Text) || string.IsNullOrWhiteSpace(cbo_Phanloai.Text) ||
                string.IsNullOrWhiteSpace(txb_TaiKhoanGV.Text) || string.IsNullOrWhiteSpace(txb_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string magv = txb_MaGV.Text;

                // Kiểm tra mã sinh viên đã tồn tại trong cơ sở dữ liệu
                if (KiemTraGVTonTai(magv))
                {
                    MessageBox.Show("Mã giảng viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    ConnectDB connectDB = new ConnectDB();
                    SqlConnection conn = connectDB.getConnect();
                    SqlCommand cmd = new SqlCommand("sp_ThemGV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@magv", txb_MaGV.Text);
                    cmd.Parameters.AddWithValue("@hoten", txb_HoTen.Text);
                    cmd.Parameters.AddWithValue("@gioitinh", cbo_GioiTinh.Text);
                    cmd.Parameters.AddWithValue("@sodienthoai", txb_Phone.Text);
                    cmd.Parameters.AddWithValue("@email", txb_Email.Text);
                    cmd.Parameters.AddWithValue("@phanloai", cbo_Phanloai.Text);
                    cmd.Parameters.AddWithValue("@taikhoan", txb_TaiKhoanGV.Text);
                    cmd.Parameters.AddWithValue("@matkhau", txb_MatKhau.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                txb_MaGV.Text = " ";
                txb_HoTen.Text = " ";
                cbo_GioiTinh.Text = " ";
                txb_Phone.Text = " ";
                txb_Email.Text = " ";
                cbo_Phanloai.Text = " ";
                txb_TaiKhoanGV.Text = " ";
                txb_MatKhau.Text = " ";
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgw_TTGV.SelectedRows.Count > 0)
            {
                // Lấy giá trị mã giảng viên (MAGV) từ hàng đang chọn trong DataGridView
                string magv = dgw_TTGV.SelectedRows[0].Cells["MaGV"].Value.ToString();
                ConnectDB connectDB = new ConnectDB();
                SqlConnection conn = connectDB.getConnect();
                SqlCommand cmd = new SqlCommand("sp_XoaGV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@magv", magv);
                conn.Open();
                DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txb_MaGV.Text = " ";
                    txb_HoTen.Text = " ";
                    cbo_GioiTinh.Text = " ";
                    txb_Phone.Text = " ";
                    txb_Email.Text = " ";
                    cbo_Phanloai.Text = " ";
                    txb_TaiKhoanGV.Text = " ";
                    txb_MatKhau.Text = " ";
                }   
                else
                {
                    return;
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Get_MKGiangVien(string magv)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("SELECT MATKHAU FROM DANGNHAP, GIANGVIEN WHERE MAGV = @magv " +
                                            "AND DANGNHAP.TAIKHOAN = GIANGVIEN.TAIKHOAN_GV", conn);
            cmd.Parameters.AddWithValue("@magv", magv);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return "Không có mật khẩu";
            }
        }

        private void dgw_TTGV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgw_TTGV.SelectedRows.Count > 0)
            {
                // Lấy giá trị từ các ô dữ liệu của dòng đang chọn trong DataGridView
                string magv = dgw_TTGV.SelectedRows[0].Cells["MaGV"].Value.ToString();
                string hoten = dgw_TTGV.SelectedRows[0].Cells["HoTen"].Value.ToString();
                string gioitinh = dgw_TTGV.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                string phone = dgw_TTGV.SelectedRows[0].Cells["Phone"].Value.ToString();
                string email = dgw_TTGV.SelectedRows[0].Cells["Email"].Value.ToString();
                string phanloai = dgw_TTGV.SelectedRows[0].Cells["PLGV"].Value.ToString();
                string taikhoan = dgw_TTGV.SelectedRows[0].Cells["TK"].Value.ToString();
                string matkhau = Get_MKGiangVien(magv);
                // Hiển thị dữ liệu lên các TextBox
                txb_MaGV.Text = magv;
                txb_HoTen.Text = hoten;
                cbo_GioiTinh.Text = gioitinh;
                txb_Phone.Text = phone;
                txb_Email.Text = email;
                cbo_Phanloai.Text = phanloai;
                txb_TaiKhoanGV.Text = taikhoan;
                txb_MatKhau.Text = matkhau;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_MaGV.Text) || string.IsNullOrWhiteSpace(txb_HoTen.Text) ||
                string.IsNullOrWhiteSpace(cbo_GioiTinh.Text) || string.IsNullOrWhiteSpace(txb_Phone.Text) ||
                string.IsNullOrWhiteSpace(txb_Email.Text) || string.IsNullOrWhiteSpace(cbo_Phanloai.Text) ||
                string.IsNullOrWhiteSpace(txb_TaiKhoanGV.Text) || string.IsNullOrWhiteSpace(txb_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ConnectDB connectDB = new ConnectDB();
                SqlConnection conn = connectDB.getConnect();
                SqlCommand cmd = new SqlCommand("sp_SuaGV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@magv", txb_MaGV.Text);
                cmd.Parameters.AddWithValue("@hoten", txb_HoTen.Text);
                cmd.Parameters.AddWithValue("@gioitinh", cbo_GioiTinh.Text);
                cmd.Parameters.AddWithValue("@sodienthoai", txb_Phone.Text);
                cmd.Parameters.AddWithValue("@email", txb_Email.Text);
                cmd.Parameters.AddWithValue("@phanloai", cbo_Phanloai.Text);
                cmd.Parameters.AddWithValue("@taikhoan", txb_TaiKhoanGV.Text);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            txb_MaGV.Text = " ";
            txb_HoTen.Text = " ";
            cbo_GioiTinh.Text = " ";
            txb_Phone.Text = " ";
            txb_Email.Text = " ";
            cbo_Phanloai.Text = " ";
            txb_TaiKhoanGV.Text = " ";
            txb_MatKhau.Text = " ";
        }
    }
}
