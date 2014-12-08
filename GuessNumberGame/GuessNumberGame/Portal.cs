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

        /// <summary>
        /// It is used to register a player to DB.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        /// <returns>True for success, false for fail.</returns>
        public bool UserRegister(string username,string password)
        {

            if (dh.IsExistingUser(username)==null)
            {
                //Player p = new Player(username, password);
                dh.UserRegister(username, password);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// It is used to log in a player.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        /// <returns>True for success, false for fail.</returns>
        public bool logIn(Player player)
        {
            return dh.IsValidLogin(player.userName, player.password);
        }

        /// <summary>
        /// Invites the player for a game.
        /// </summary>
        /// <param name="send">The sender of invitation.</param>
        /// <param name="receive">The receiver of invitation.</param>
        /// <returns>True for acceptance, false for dismissal.</returns>
        public bool InvitePlayer(Player sender, Player receiver)
        {
            return receiver.PortalCallBack.OnInvitation(sender);
        }

        /// <summary>
        /// It is used when a player logges out.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        public void UserLogOut(Player player)
        {
            player.PortalCallBack.OnLoggingOut(player);
            OnlinePlayers.Remove(player);
        }

        /// <summary>
        /// Receives player's message.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        /// <param name="m">The message sent.</param>
        /// <returns>A string with the player and the sent message.</returns>
        public void ChatMessage(Player player, string message)
        {
            player.PortalCallBack.messageReceived(player.userName + ": " + message);
        }


    }
}
