using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace Project_DBMS_Final
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDSV;Integrated Security=True");

        private void LayDSMonHoc()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlCommand cmd = new SqlCommand("SP_DSMonHoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Connection = conn;
            conn.Open();
            da.Fill(dt);
            cboMaMH.DataSource = dt;
            cboMaMH.DisplayMember = "TENMONHOC";
            cboMaMH.ValueMember = "MAMONHOC";
            cboMaMH.SelectedValue = 0;
            conn.Close();
        }


        private void LayDSHS()
        {
            dgw_TCD.Rows.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlCommand cmd = new SqlCommand("SP_lAYDSHS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            int STT = 0;
            while (dr.Read())
            {
                STT = STT + 1;
                string formattedDate = dr.GetDateTime(2).ToString("dd/MM/yyyy");
                dgw_TCD.Rows.Add(STT, dr.GetValue(0), dr.GetString(1), formattedDate, dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));
            }
            dr.Close();
        }
        private bool KiemTraThongTin()
        {
            if (cbb_xeploai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn học lực của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboMaMH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            //hiển thị ds môn học
            LayDSMonHoc();
            //hiển thị ds học sinh
            LayDSHS();
        }

        private void btn_BatdauLoc_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            //dgw_TCD.Rows.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlCommand cmd = new SqlCommand("sp_DSSV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // Thêm tham số vào stored procedure
            cmd.Parameters.AddWithValue("@monHoc", cboMaMH.Text.ToString());
            cmd.Parameters.AddWithValue("@xepLoai", cbb_xeploai.Text.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TCD.DataSource = dtable;
            dgw_TCD.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btn_InDS_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintList);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintList(object sender, PrintPageEventArgs e)
        {
            // Thiết lập font chữ và kích thước cho bản in

            Font font = new Font("Times New Roman", 8);
            int lineHeight = font.Height + 30;

            // Tính toán kích thước của trang
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;

            // Tính toán số dòng và số cột của DataGridView
            int rowCount = dgw_TCD.Rows.Count;
            int columnCount = dgw_TCD.Columns.Count;

            // Tạo định dạng cho bảng
            Pen pen = new Pen(Color.Black, 1);
            SolidBrush headerBrush = new SolidBrush(Color.LightGray);
            SolidBrush rowBrush = new SolidBrush(Color.White);

            // Vẽ tiêu đề cho bản in
            Font titleFont = new Font("Times New Roman", 20, FontStyle.Bold);

            string title = "Danh sách sinh viên";
            int titleX = pageWidth / 2 - (int)e.Graphics.MeasureString(title, titleFont).Width / 2;
            int titleY = 50;
            e.Graphics.DrawString(title, titleFont, Brushes.Black, titleX, titleY);

            // Vẽ nội dung cho bản in
            int startX = 5;
            int startY = titleY + lineHeight + 40;
            int padding = 4;

            // Vẽ tiêu đề cột
            for (int j = 0; j < columnCount; j++)
            {
                int x = startX + j * (pageWidth - 2 * startX) / columnCount;
                e.Graphics.FillRectangle(headerBrush, x, startY, (pageWidth - 2 * startX) / columnCount, lineHeight);
                e.Graphics.DrawRectangle(pen, x, startY, (pageWidth - 2 * startX) / columnCount, lineHeight);
                e.Graphics.DrawString(dgw_TCD.Columns[j].HeaderText, font, Brushes.Black, x + padding, startY + padding);
            }

            // Vẽ dữ liệu hàng
            for (int i = 0; i < rowCount; i++)
            {
                int y = startY + (i + 1) * lineHeight;
                for (int j = 0; j < columnCount; j++)
                {
                    int x = startX + j * (pageWidth - 2 * startX) / columnCount;
                    string value = dgw_TCD.Rows[i].Cells[j].FormattedValue.ToString();
                    e.Graphics.DrawString(value, font, Brushes.Black, x + padding, y + padding);
                    e.Graphics.DrawRectangle(pen, x, y, (pageWidth - 2 * startX) / columnCount, lineHeight);
                }
            }
        }
    }
}
