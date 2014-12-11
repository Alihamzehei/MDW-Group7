using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Server
{
    class Portal : IPortal
    {
        private List<Player> OnlinePlayers;
        private DataHelper dh;
        private Game game;

        public Portal()
        {
            OnlinePlayers = new List<Player>();
            dh = new DataHelper();
        }

        public Player Player
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal DataHelper DataHelper
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// It is used to register a player to DB.
        /// </summary>
        /// <param name="player">The player of the game.</param>
        /// <returns>True for success, false for fail.</returns>
        public bool UserRegister(Player player)
        {
            if (!dh.IsExistingUser(player.Username))
            {
                dh.UserRegister(player.Username, player.Password);
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
        public bool LogIn(Player player)
        {
            return dh.IsValidLogin(player.Username, player.Password);
        }

        /// <summary>
        /// Invites the player for a game.
        /// </summary>
        /// <param name="send">The sender of invitation.</param>
        /// <param name="receive">The receiver of invitation.</param>
        /// <returns>True for acceptance, false for dismissal.</returns>
        public bool InvitePlayer(Player sender, Player receiver)
        {
            if (receiver.PortalCallback.OnInvitation(sender))
            {
                game = new Game(sender, receiver);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// It is used when a player logges out.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        public void UserLogOut(Player player)
        {
            player.PortalCallback.OnLoggingOut(player);
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
            player.PortalCallback.OnMessage(player.Username + ": " + message);
        }
    }
}
