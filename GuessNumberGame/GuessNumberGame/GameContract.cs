using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class GameContract : IPortal
    {
        public List<Player> avaliablePlayers;
        public List<Player> GetPlayerList();
        private Player inviter;
        private Player receiver;

        public void StartGame(Player p1, Player p2)
        { }//if InvitePlayer() is true put two player in the game
        public void CountGuessTime()
        {

        }

        public String CheckNumber(int[] a) { return null; }

        public List<Player> AvaliablePlayers()
        {
            return avaliablePlayers;
        }
    }
}
