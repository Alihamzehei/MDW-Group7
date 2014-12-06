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


    }
}
