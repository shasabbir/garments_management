using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GMS
{
    class DataAccess
    {
        static SqlConnection connection;
        static SqlCommand command;



        public DataAccess()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-KORGD9I;Initial Catalog=GMS;Persist Security Info=True;User ID=sa;Password=root");
            connection.Open();
        }



        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }



        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }



        public void Dispose()
        {
            connection.Close();
        }
        ~DataAccess()
        {
            connection.Close();
        }
    }
}
