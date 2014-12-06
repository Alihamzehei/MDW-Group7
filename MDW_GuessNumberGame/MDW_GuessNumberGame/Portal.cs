using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDW_GuessNumberGame
{
    class Portal : IPortal
    {
        DataHelper dh = new DataHelper();
        List<Player> OnlinePlayers = new List<Player>();
        
        public bool signUp(Player p)
        {
            if (!dh.IsExistingUser(p.UserName))
            {
                dh.UserRegister(p.UserName, p.password);
                OnlinePlayers.Add(p);
                return true;
            }
            else
                return false;
        }

        public bool logIn(Player p)
        {
            throw new NotImplementedException();
            //if (dh.IsExistingUser(p.UserName))
            //{
            //    if (dh.)
            //}
        }

        public void logOut(Player p)
        {
            OnlinePlayers.Remove(p);
        }

        public string ChatMessage(Player p, string message)
        {
            return p.UserName + ": " + message;
        }

        public void Invite(Player p1, Player p2)
        {
            throw new NotImplementedException();
        }
    }
}
