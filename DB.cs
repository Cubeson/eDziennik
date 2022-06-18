using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edziennik
{
    public class DB
    {
        private DB() { }
        private static MySqlConnection? connection;
        public static bool CheckDB()
        {
            connection = GetInstance();
            try
            {
                connection.Open();
            }
            catch (MySqlException ex) { 
                return false;
            }
            connection.Close();
            return true;
        }
        public static MySqlConnection GetInstance()
        {
            if(connection == null)
                connection = getConnection();
            return connection;
        }
        private static MySqlConnection getConnection()
        {
            var server = "localhost";
            var database = "edziennik";
            var port = "3307";
            var uid = "eduser";
            var password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";"+ "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            var connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
