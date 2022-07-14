using MySql.Data.MySqlClient;
using System;

namespace lib
{
    public class db
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; port=3306; username=root; password = root;database =database");
        public void open()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getconnection()
        {
            return connection;
        }
    }
}
