using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    public static class Connection
    {
        public static string ServerHost = "localhost";
        public static string DatabaseName = "viet_database";
        public static string DBUserName = "root";
        public static string DBPWD = "zhouyu8008";

        public static MySqlConnection _Connection = null;


        public static string getConnectString()
        {
            return "SERVER = " + ServerHost + "; DATABASE = " + DatabaseName + "; UID = " + DBUserName + "; PASSWORD = " + DBPWD + "; Convert Zero Datetime = True";
        }

        public static MySqlConnection ConnectionDB
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new MySqlConnection(getConnectString());
                }

                return _Connection;
            }
        }

       
    }
}
