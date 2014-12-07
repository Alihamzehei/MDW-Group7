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
            String databaseInfo = "Data Source=" + @"..\..\..";
            String connectionInfo = provider + ";" + databaseInfo;
            connection = new OleDbConnection(connectionInfo);
        }

        public bool IsExistingUser(String username)
        {
            String sql = "SELECT username From User" + username + "';";
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
            String sql = "SELECT username, password FROM User WHERE playerName = '" + userName + "' AND " + "password = '" + password + "';";
            OleDbCommand command = new OleDbCommand(sql, connection);

           
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count >= 1)
                {  return true;}else{return false;}

        }
    }
}
