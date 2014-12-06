using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace MDW_GuessNumberGame
{
    class DataHelper
    {
        private OleDbConnection connection;
        public DataHelper()
        {
            String provider = "Provider=Microsoft.ACE.OLEDB.12.0";
            String databaseInfo = "Data Source=" + @"C:\Users\Joy\Documents\GitHub\MDW-Group7\MDW_GuessNumberGame";
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

        public bool UserRegister(string userID, string passWord)
        {
            if (IsExistingUser(userID) == false)
            {
                String sql = "INSERT INTO User(username,password)VALUES('" + userID + "," + passWord + "');";
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = connection;
                return true;
            }
            else {
                return false;
            }
        }


    }
}
