using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace MDW_GuessNumberGame
{
    class DataHandler
    {
        private MySqlConnection connection;
        private string userID;
        private string passWord;

        public bool CheckUser()
        { return false; }
        public void UserLogin(string userID, string passWord) { }
        public void UserRegister(string userID, string passWord) { }

    }
}
