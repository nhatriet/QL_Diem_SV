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
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            string query = "SELECT * FROM SINHVIEN";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TTSV.DataSource = dtable;
            dgw_TTSV.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgw_TTSV.Refresh();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            string query = "EXEC sp_SinhVien";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TTSV.DataSource = dtable;
            dgw_TTSV.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgw_TTSV.Refresh();
        }

        private void TimKiemSV()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("sp_TimKiemSV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // Thêm tham số vào stored procedure
            cmd.Parameters.AddWithValue("@malop", cbo_LopHoc.SelectedItem.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TTSV.DataSource = dtable;
            dgw_TTSV.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgw_TTSV.Refresh();
        }

        private void cbo_LopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemSV();
        }

        private bool KiemTraSVTonTai(string masv)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SINHVIEN WHERE MASV = @masv", conn);
            cmd.Parameters.AddWithValue("@masv", masv);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_MaSV.Text) || string.IsNullOrWhiteSpace(txb_HoTen.Text) ||
                string.IsNullOrWhiteSpace(txb_NgaySinh.Text) || string.IsNullOrWhiteSpace(cbo_GioiTinh.Text) ||
                string.IsNullOrWhiteSpace(txb_DiaChi.Text) || string.IsNullOrWhiteSpace(txb_TinhTrang.Text) ||
                string.IsNullOrWhiteSpace(cbo_MaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            {
                string masv = txb_MaSV.Text;

                // Kiểm tra mã sinh viên đã tồn tại trong cơ sở dữ liệu
                if (KiemTraSVTonTai(masv))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    ConnectDB connectDB = new ConnectDB();
                    SqlConnection conn = connectDB.getConnect();
                    SqlCommand cmd = new SqlCommand("sp_ThemSV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@masv", txb_MaSV.Text);
                    cmd.Parameters.AddWithValue("@hoten", txb_HoTen.Text);
                    if (DateTime.TryParseExact(txb_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh))
                    {
                        cmd.Parameters.AddWithValue("@ngaysinh", ngaySinh.Date);
                    }
                    cmd.Parameters.AddWithValue("@gioitinh", cbo_GioiTinh.Text);
                    cmd.Parameters.AddWithValue("@diachi", txb_DiaChi.Text);
                    cmd.Parameters.AddWithValue("@tinhtrang", txb_TinhTrang.Text);
                    cmd.Parameters.AddWithValue("@malop", cbo_MaLop.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                txb_MaSV.Text = " ";
                txb_HoTen.Text = " ";
                txb_NgaySinh.Text = " ";
                cbo_GioiTinh.Text = " ";
                txb_DiaChi.Text = " ";
                txb_TinhTrang.Text = " ";
                cbo_MaLop.Text = " ";
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgw_TTSV.SelectedRows.Count > 0)
            {
                // Lấy giá trị mã sinh viên (MASV) từ hàng đang chọn trong DataGridView
                string masv = dgw_TTSV.SelectedRows[0].Cells["MaSV"].Value.ToString();

                ConnectDB connectDB = new ConnectDB();
                SqlConnection conn = connectDB.getConnect();
                SqlCommand cmd = new SqlCommand("sp_XoaSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masv", masv);
                conn.Open();
                DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txb_MaSV.Text = " ";
                    txb_HoTen.Text = " ";
                    txb_NgaySinh.Text = " ";
                    cbo_GioiTinh.Text = " ";
                    txb_DiaChi.Text = " ";
                    txb_TinhTrang.Text = " ";
                    cbo_MaLop.Text = " ";
                }   
                else
                {
                    return;
                }     
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgw_TTSV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgw_TTSV.SelectedRows.Count > 0)
            {
                // Lấy giá trị từ các ô dữ liệu của dòng đang chọn trong DataGridView
                string masv = dgw_TTSV.SelectedRows[0].Cells["MaSV"].Value.ToString();
                string hoten = dgw_TTSV.SelectedRows[0].Cells["HoTen"].Value.ToString();
                string ngaysinh = dgw_TTSV.SelectedRows[0].Cells["NgaySinh"].Value.ToString();
                string gioitinh = dgw_TTSV.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                string diachi = dgw_TTSV.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                string tinhtrang = dgw_TTSV.SelectedRows[0].Cells["TinhTrang"].Value.ToString();
                string malop = dgw_TTSV.SelectedRows[0].Cells["MaLop"].Value.ToString();
                // Hiển thị dữ liệu lên các TextBox
                txb_MaSV.Text = masv;
                txb_HoTen.Text = hoten;
                DateTime ngaySinh;
                if (DateTime.TryParseExact(ngaysinh, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                {
                    // Format lại chuỗi theo định dạng "dd/MM/yyyy" và hiển thị trong TextBox
                    txb_NgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
                }
                cbo_GioiTinh.Text = gioitinh;
                txb_DiaChi.Text = diachi;
                txb_TinhTrang.Text = tinhtrang;
                cbo_MaLop.Text = malop;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_MaSV.Text) || string.IsNullOrWhiteSpace(txb_HoTen.Text) ||
                string.IsNullOrWhiteSpace(txb_NgaySinh.Text) || string.IsNullOrWhiteSpace(cbo_GioiTinh.Text) ||
                string.IsNullOrWhiteSpace(txb_DiaChi.Text) || string.IsNullOrWhiteSpace(txb_TinhTrang.Text) ||
                string.IsNullOrWhiteSpace(cbo_MaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ConnectDB connectDB = new ConnectDB();
                SqlConnection conn = connectDB.getConnect();
                SqlCommand cmd = new SqlCommand("sp_SuaSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masv", txb_MaSV.Text);
                cmd.Parameters.AddWithValue("@hoten", txb_HoTen.Text);
                if (DateTime.TryParseExact(txb_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh))
                {
                    cmd.Parameters.AddWithValue("@ngaysinh", ngaySinh.Date);
                }
                cmd.Parameters.AddWithValue("@gioitinh", cbo_GioiTinh.Text);
                cmd.Parameters.AddWithValue("@diachi", txb_DiaChi.Text);
                cmd.Parameters.AddWithValue("@tinhtrang", txb_TinhTrang.Text);
                cmd.Parameters.AddWithValue("@malop", cbo_MaLop.Text);
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
            txb_MaSV.Text = " ";
            txb_HoTen.Text = " ";
            txb_NgaySinh.Text = " ";
            cbo_GioiTinh.Text = " ";
            txb_DiaChi.Text = " ";
            txb_TinhTrang.Text = " ";
            cbo_MaLop.Text = " ";
            cbo_MaLop.Text = " ";
        }
    }
}
