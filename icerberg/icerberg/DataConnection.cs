using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data;
using System.Security.Cryptography;
using System.Configuration;
using System.Linq;
using icerberg;

namespace icerberg
{
    class DataConnection
    {
        private SqlConnection Connection;
        private string Server;
        private string Database;
        private string UserId;
        private string Password;

        public string getServer()
        {
            String ServerName = Encryption.Decrypt(ConfigurationManager.AppSettings["server"], "TheLastAirBender");
            return ServerName;
        }

        public void Connect()
        {
            if(ConnectoDB(Server,Database,UserId,Password)) {
                
            }
        }

        public static Boolean ConnectoDB(String ServerName, String DatabaseName, String UserId, String Password, String Port = "")
        {
            Boolean Connected = false;
            String ConnectionString = null;
            SqlConnection SqlCon ;
            if (Port != "")
            {
                Port = "," + Port;
            }
            String Source = "Data Source=" + ServerName;

            ConnectionString = "Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + UserId + ";Password=" + Password;
            SqlCon = new SqlConnection(ConnectionString);
            try
            {
                SqlCon.Open();
                Connected = true;
                return Connected;
                SqlCon.Close();
            }
            catch (Exception ex)
            {
                return Connected;
            }
        }
    }
}
