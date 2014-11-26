using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MDW_GuessNumberGame
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Game : IGame
    {
        private List<Player> playerlist;
        private Player player1;
        private Player player2;
        public List<Player> GetPlayerList()
        {
            return playerlist;
        }

        public void StartGame(Player p1,Player p2)
        { }//if InvitePlayer() is true put two player in the game
        public void CountGuessTime()
        {
        }

        public bool InvitePlayer(Player p1,Player p2) { return false; }

       
       
    }
}
