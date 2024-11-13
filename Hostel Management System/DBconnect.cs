using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
    class DBconnect
    {
        static string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\vansh\Source\Repos\HMS\Hostel Management System\hms_db.mdf';Integrated Security=True";

        private string connectionString = s;

        public SqlConnection connection;
        public SqlCommand cmd;
        public SqlDataAdapter da;


        public DBconnect()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }


        public SqlCommand insert(string query)
        {
            cmd = new SqlCommand(query, connection);
            return cmd;

        }

        public SqlCommand update(string query)
        {
            cmd = new SqlCommand(query, connection);
            return cmd;

        }

        public SqlCommand delete(string query)
        {
            cmd = new SqlCommand(query, connection);
            return cmd;

        }

        public SqlDataAdapter selectDA(string query)
        {
            da = new SqlDataAdapter(query, connection);
            return da;
        }
    }
}
