using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project_DBMS_Final
{
    public partial class frmQLDiem : Form
    {
        public frmQLDiem()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            string query = "EXEC HienThiDiemSinhVien";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_DiemSV.DataSource = dtable;
            dgw_DiemSV.Refresh();
        }

        private void frmQLDiem_Load(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            string query = "EXEC HienThiDiemSinhVien";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_DiemSV.DataSource = dtable;
            dgw_DiemSV.Refresh();
        }

        private bool KiemTraSVTonTai(string masv, string mamonhoc, string hocky)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM KETQUA WHERE MASV = @MaSV " +
                                            "AND MAMONHOC = @MaMonHoc AND HOCKY = @HocKy", conn);
            cmd.Parameters.AddWithValue("@MaSV", masv);
            cmd.Parameters.AddWithValue("@MaMonHoc", mamonhoc);
            cmd.Parameters.AddWithValue("@HocKy", hocky);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;

        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_Lop.Text) || string.IsNullOrWhiteSpace(cbo_HocKi.Text) ||
                string.IsNullOrWhiteSpace(cbo_MonHoc.Text) || string.IsNullOrWhiteSpace(txb_MaSV.Text) ||
                string.IsNullOrWhiteSpace(txt_HoTen.Text) || string.IsNullOrWhiteSpace(txb_DiemCK.Text) ||
                string.IsNullOrWhiteSpace(txb_DiemQT.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string masv = txb_MaSV.Text;
                string mamonhoc = cbo_MonHoc.Text;
                string hocky = cbo_HocKi.Text;
                if (KiemTraSVTonTai(masv, mamonhoc, hocky))
                {
                    MessageBox.Show("Thông tin đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    ConnectDB connectDB = new ConnectDB();
                    SqlConnection conn = connectDB.getConnect();
                    SqlCommand cmd = new SqlCommand("ThemDiemSinhVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", txb_MaSV.Text);
                    cmd.Parameters.AddWithValue("@MaMonHoc", cbo_MonHoc.Text);
                    cmd.Parameters.AddWithValue("@DiemQuaTrinh", txb_DiemQT.Text);
                    cmd.Parameters.AddWithValue("@DiemCuoiKy", txb_DiemCK.Text);
                    cmd.Parameters.AddWithValue("@HocKy", cbo_HocKi.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", txt_GhiChu.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                cbo_Lop.Text = " ";
                cbo_HocKi.Text = " ";
                cbo_MonHoc.Text = " ";
                txb_MaSV.Text = " ";
                txt_HoTen.Text = " ";
                txb_DiemCK.Text = " ";
                txb_DiemQT.Text = " ";
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgw_DiemSV.SelectedRows.Count > 0)
            {
                string masv = dgw_DiemSV.SelectedRows[0].Cells["MaSV"].Value.ToString();
                string mamonhoc = dgw_DiemSV.SelectedRows[0].Cells["MaMon"].Value.ToString();
                string hocki = dgw_DiemSV.SelectedRows[0].Cells["HocKi"].Value.ToString();
                ConnectDB connectDB = new ConnectDB();
                SqlConnection conn = connectDB.getConnect();
                SqlCommand cmd = new SqlCommand("XoaDiemSinhVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSV", masv);
                cmd.Parameters.AddWithValue("@MaMonHoc", mamonhoc);
                cmd.Parameters.AddWithValue("@HocKy", hocki);
                conn.Open();
                DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    cbo_Lop.Text = " ";
                    cbo_HocKi.Text = " ";
                    cbo_MonHoc.Text = " ";
                    txb_MaSV.Text = " ";
                    txt_HoTen.Text = " ";
                    txb_DiemCK.Text = " ";
                    txb_DiemQT.Text = " ";
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

        private void dgw_DiemSV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgw_DiemSV.SelectedRows.Count > 0)
            {
                // Lấy giá trị từ các ô dữ liệu của dòng đang chọn trong DataGridView
                string masv = dgw_DiemSV.SelectedRows[0].Cells["MaSV"].Value.ToString();
                string hoten = dgw_DiemSV.SelectedRows[0].Cells["HoTen"].Value.ToString();
                string malop = dgw_DiemSV.SelectedRows[0].Cells["MaLop"].Value.ToString();
                string mamonhoc = dgw_DiemSV.SelectedRows[0].Cells["MaMon"].Value.ToString();
                string diemquatrinh = dgw_DiemSV.SelectedRows[0].Cells["DiemQT"].Value.ToString();
                string diemcuoiky = dgw_DiemSV.SelectedRows[0].Cells["DiemCK"].Value.ToString();
                string hocki = dgw_DiemSV.SelectedRows[0].Cells["HocKi"].Value.ToString();
                string ghichu = dgw_DiemSV.SelectedRows[0].Cells["GhiChu"].Value.ToString();
                txb_MaSV.Text = masv;
                txt_HoTen.Text = hoten;
                cbo_Lop.Text = malop;
                cbo_MonHoc.Text = mamonhoc;
                txb_DiemQT.Text = diemquatrinh;
                txb_DiemCK.Text = diemcuoiky;
                cbo_HocKi.Text = hocki;
                txt_GhiChu.Text = ghichu;
            }
        }

        private bool KiemTraDiemTonTai(string mamonhoc, string diemquatrinh, string diemcuoiky, string hocky)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM KETQUA WHERE MAMONHOC = @MaMonHoc " +
                                            "AND DIEMQUATRINH = @DiemQuaTrinh AND DIEMCUOIKY = @DiemCuoiKy " +
                                            "AND HOCKY = @HocKy", conn);
            cmd.Parameters.AddWithValue("@MaMonHoc", mamonhoc);
            cmd.Parameters.AddWithValue("@DiemQuaTrinh", diemquatrinh);
            cmd.Parameters.AddWithValue("@DiemCuoiKy", diemcuoiky);
            cmd.Parameters.AddWithValue("@HocKy", hocky);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_Lop.Text) || string.IsNullOrWhiteSpace(cbo_HocKi.Text) ||
                string.IsNullOrWhiteSpace(cbo_MonHoc.Text) || string.IsNullOrWhiteSpace(txb_MaSV.Text) ||
                string.IsNullOrWhiteSpace(txt_HoTen.Text) || string.IsNullOrWhiteSpace(txb_DiemCK.Text) ||
                string.IsNullOrWhiteSpace(txb_DiemQT.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string mamonhoc = cbo_MonHoc.Text;
                string diemquatrinh = txb_DiemQT.Text;
                string diemcuoiky = txb_DiemCK.Text;
                string hocky = cbo_HocKi.Text;
                if (KiemTraDiemTonTai(mamonhoc, diemquatrinh, diemcuoiky, hocky))
                {
                    MessageBox.Show("Thông tin đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }    
                else
                {
                    ConnectDB connectDB = new ConnectDB();
                    SqlConnection conn = connectDB.getConnect();
                    SqlCommand cmd = new SqlCommand("SuaDiemSinhVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", txb_MaSV.Text);
                    cmd.Parameters.AddWithValue("@MaMonHoc", cbo_MonHoc.Text);
                    cmd.Parameters.AddWithValue("@DiemQuaTrinh", txb_DiemQT.Text);
                    cmd.Parameters.AddWithValue("@DiemCuoiKy", txb_DiemCK.Text);
                    cmd.Parameters.AddWithValue("@HocKy", cbo_HocKi.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", txt_GhiChu.Text);
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
                cbo_Lop.Text = " ";
                cbo_HocKi.Text = " ";
                cbo_MonHoc.Text = " ";
                txb_MaSV.Text = " ";
                txt_HoTen.Text = " ";
                txb_DiemCK.Text = " ";
                txb_DiemQT.Text = " ";
            }
        }
    }
}
