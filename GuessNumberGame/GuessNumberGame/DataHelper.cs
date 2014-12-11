using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Server
{
    class DataHelper
    {
        private OleDbConnection connection;
        public DataHelper()
        {
            String provider = "Provider=Microsoft.ACE.OLEDB.12.0";
            String databaseInfo = "Data Source=" + @"..\\..\\..\\..\\Database1.accdb";
            String connectionInfo = provider + ";" + databaseInfo;
            connection = new OleDbConnection(connectionInfo);
        }

        public bool IsExistingUser(string username)
        {
            String sql = "SELECT username From User '" + username + "';";
            OleDbCommand command = new OleDbCommand(sql, connection);

            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;
        }

        public bool UserRegister(string userName, string password)
        {
            if (IsExistingUser(userName) == false)
            {
                String sql = "INSERT INTO User(username,password)VALUES('" + userName + "," + password + "');";
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = connection;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsValidLogin(string userName, string password)
        {
            String sql = "SELECT * FROM User WHERE username = '" + userName + "' AND password = '" + password + "'";
            OleDbCommand command = new OleDbCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.CommandText = sql;

            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            string pName = null;
            string pw = null;
            while (reader.Read())
            {
                pName = Convert.ToString(reader["username"]);
                pw = Convert.ToString(reader["password"]);
            }
            if (pName == null || pw == null)
            {
                connection.Close();
                return false;
            }
            else
            {
                connection.Close();
                return true;
            }
        }
    }
}
