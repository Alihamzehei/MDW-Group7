using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.OleDb;


namespace MDW_GuessNumberGame
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class GameContract : IGame,IPortal
    {
        private List<Player> avaliablePlayers;
        private Player player1;
        private Player player2;
        private string username;
        private string password;
        public List<Player> GetPlayerList()
        {
            return null;
        }

        public void StartGame(Player p1,Player p2)
        { }//if InvitePlayer() is true put two player in the game
        public void CountGuessTime()
        {
        }

        public bool InvitePlayer(Player p1,Player p2) { return false; }

        public String CheckNumber(int[] a) { return null; }

        public List<Player> AvaliablePlayers() { return null; }

        public String ChatMessage(string player, string message)
        { return null; }


        public bool CheckUser()
        { return false; }

        void UserRegister(string userID, string passWord) {
            DataHelper dataHelper = new DataHelper();
            dataHelper.UserRegister(userID, passWord);
            
        }
      
        
        
    }
}
