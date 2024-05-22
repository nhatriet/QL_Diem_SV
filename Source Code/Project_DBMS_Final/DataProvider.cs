using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project_DBMS_Final
{
    public class DataProvider
    {

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set { instance = value; }
        }

        private DataProvider() { }

        private string connSTR = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDSV;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connSTR))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        string[] listPar = query.Split(' ');
                        int i = 0;
                        foreach (string s in listPar)
                        {
                            if (s.Contains('@'))
                            {
                                string[] values = s.Split(',');
                                foreach (string v in values)
                                {
                                    if (v.Contains('@'))
                                    {
                                        command.Parameters.AddWithValue(v, parameters[i++]);
                                    }
                                }
                            }
                        }
                    }
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    sda.Fill(dTable);
                    conn.Close();
                }
            }
            catch
            {
                throw;
            }

            return dTable;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connSTR))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);

                    if (parameters != null)
                    {
                        string[] listPar = query.Split(' ');
                        int i = 0;
                        foreach (string s in listPar)
                        {
                            if (s.Contains('@'))
                            {
                                string[] values = s.Split(',');
                                foreach (string v in values)
                                {
                                    if (v.Contains('@'))
                                    {
                                        command.Parameters.AddWithValue(v, parameters[i++]);
                                    }
                                }
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch { throw; }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data;
            using (SqlConnection conn = new SqlConnection(connSTR))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);

                if (parameters != null)
                {
                    string[] listPar = query.Split(' ');
                    int i = 0;
                    foreach (string s in listPar)
                    {
                        if (s.Contains('@'))
                        {
                            string[] values = s.Split(',');
                            foreach (string v in values)
                            {
                                if (v.Contains('@'))
                                {
                                    command.Parameters.AddWithValue(v, parameters[i++]);
                                }
                            }
                        }
                    }
                }
                data = command.ExecuteScalar();

                conn.Close();
            }
            return data;
        }
    }
}