using System;
using MySql.Data.MySqlClient;

namespace NavchPrakt_28_LINQtoSQL
{
    public class SQLConnection
    {
        public static MySqlConnection GetDBConnection(string host, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database
                + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            //int port = 3306;
            string database = "firma100";
            string username = "root";
            string password = "";

            return GetDBConnection(host, database, username, password);
        }
    }
}