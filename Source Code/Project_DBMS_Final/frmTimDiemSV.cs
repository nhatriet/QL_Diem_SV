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
    public partial class frmTimDiemSV : Form
    {
        public frmTimDiemSV()
        {
            InitializeComponent();
        }

        private void frmTimDiemSV_Load(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            string query = "EXEC ThongTinKetQuaSinhVien";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TCD.DataSource = dtable;
            dgw_TCD.Refresh();
        }

        private void TimKiemDiemSV_MaSV()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("TimDiemTheoMaSinhVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // Thêm tham số vào stored procedure
            cmd.Parameters.AddWithValue("@MaSV", txb_MaSV.Text.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TCD.DataSource = dtable;
            dgw_TCD.Refresh();
        }

        private void TimKiemDiemSV_MonHoc()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("TimDiemSinhVienTheoMonHoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // Thêm tham số vào stored procedure
            cmd.Parameters.AddWithValue("@MaMonHoc", cbo_MonHoc.Text.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TCD.DataSource = dtable;
            dgw_TCD.Refresh();
        }

        private void TimKiemDiemTheoMaSV_MonHoc()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            SqlCommand cmd = new SqlCommand("TimDiemTheoMaSinhVien_MonHoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // Thêm tham số vào stored procedure
            cmd.Parameters.AddWithValue("@MaSV", txb_MaSV.Text.ToString());
            cmd.Parameters.AddWithValue("@MaMonHoc", cbo_MonHoc.Text.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TCD.DataSource = dtable;
            dgw_TCD.Refresh();
        }    

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_MaSV.Text) && string.IsNullOrWhiteSpace(cbo_MonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txb_MaSV.Text) && !string.IsNullOrWhiteSpace(cbo_MonHoc.Text))
            {
                TimKiemDiemTheoMaSV_MonHoc();
                return;
            }
            else if (!string.IsNullOrWhiteSpace(txb_MaSV.Text))
            {
                TimKiemDiemSV_MaSV();
            }
            else if (!string.IsNullOrWhiteSpace(cbo_MonHoc.Text))
            {
                TimKiemDiemSV_MonHoc();
            }
            txb_MaSV.Text = "";
            cbo_MonHoc.Text = "";
        }
    }
}
