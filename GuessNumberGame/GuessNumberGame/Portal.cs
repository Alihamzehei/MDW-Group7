using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Portal : IPortal
    {
        List<Player> OnlinePlayers;
        DataHelper dh;

        public Portal()
        {
            OnlinePlayers = new List<Player>();
            dh = new DataHelper();
        }

        public bool UserRegister(Player player)
        {
            if (dh.UserRegister(player.userName, player.password))
            {
                OnlinePlayers.Add(player);
                player.PortalCallBack.OnLoggingInOrOut1(player);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool logIn(Player player)
        {
            return dh.IsValidLogin(player.userName, player.password);
        }

        public bool InvitePlayer(Player sender, Player receiver)
        {
            return receiver.PortalCallBack.OnInvitation(sender);
        }

        public void UserLogOut(Player player)
        {
            player.PortalCallBack.OnLoggingInOrOut1(player);
            OnlinePlayers.Remove(player);
        }

        public void ChatMessage(Player player, string message)
        {
            player.PortalCallBack.messageRecieved(player.userName + ": " + message);
        }


    }
}
