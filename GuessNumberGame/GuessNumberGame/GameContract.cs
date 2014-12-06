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

        public bool InvitePlayer(Player send, Player receive)
        {
            return false;
        }

        public String CheckNumber(int[] a) { return null; }

        public List<Player> AvaliablePlayers()
        {
            return avaliablePlayers;
        }

        public String ChatMessage(Player player, string message)
        {
            return player.userName + ": " + message;
        }

        public bool CheckUser(Player player)
        {
            foreach (Player p in GetPlayerList())
            {
                if (player.userName == p.userName)
                {
                    if (player.password == p.password)
                    {
                        AddAvailablePlayer(p);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool UserLogOut(Player p)
        {
            foreach (Player player in avaliablePlayers)
            {
                if (p == player)
                {
                    RemoveAvailablePlayer(p);
                    return true;
                }
            }
            return false;
        }

        public bool UserRegister(Player player)
        {
            foreach (Player p in GetPlayerList())
            {
                if (player.userName == p.userName)
                {
                    return false;
                }
            }
            return false;//just for compiling

            //TODO if username is unique add player to db
        }

        public void AddAvailablePlayer(Player p)
        {
            avaliablePlayers.Add(p);
        }

        public void RemoveAvailablePlayer(Player p)
        {
            avaliablePlayers.Remove(p);
        }

      

        public bool UserRegister(string userID, string passWord)
        {

            DataHelper dataHelper = new DataHelper();
            return dataHelper.UserRegister(userID, passWord);

        }
    }
}
