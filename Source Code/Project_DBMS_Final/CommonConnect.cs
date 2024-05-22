using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS_Final
{
    class CommonConnect
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlCommand cmd1;
        private SqlDataReader reader1;
        private SqlCommand cmd2;
        private SqlDataReader reader2;

        public SqlConnection Connected()
        {
            string connect = SystemInformation.UserDomainName.ToString();
            string source = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDSV;Integrated Security=True";
            conn = new SqlConnection(source);
            conn.Open();
            return conn;
        }
    }
}
