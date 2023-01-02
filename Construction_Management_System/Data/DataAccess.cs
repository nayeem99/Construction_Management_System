using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_Management_System.Data
{
    class DataAccess
    {
        private string ConnectionString { get; set; }

        public DataAccess()
        {
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            ConnectionString = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
        }

        public void IUD(string query)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand sqlcmd = new SqlCommand(query, con);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
        }
        public DataTable Select(string query)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand sqlcmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            sqlcmd.Connection.Open();
            dt.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            return dt;
        }
    }
}
