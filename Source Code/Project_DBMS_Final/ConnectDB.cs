using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_DBMS_Final
{
    public class ConnectDB
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDSV;Integrated Security=True");
        public SqlConnection getConnect()
        {
            return conn;
        }
    }
}
