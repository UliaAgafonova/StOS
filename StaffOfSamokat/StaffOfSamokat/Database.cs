using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffOfSamokat
{
    internal class Database //класс подключения к базе данных
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-74E9C0IK; Initial Catalog=StaffOfSamokat; Integrated Security=true");
        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
