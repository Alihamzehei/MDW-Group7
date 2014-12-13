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
        private List<Player> onlinePlayers;
        private DataHelper dh;
        private List<Game> gamesList;

        public Portal()
        {
            onlinePlayers = new List<Player>();
            dh = new DataHelper();
            gamesList = new List<Game>();
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
                Game game = new Game(sender, receiver);
                gamesList.Add(game);
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
            foreach (Player p in onlinePlayers)
            {
                p.PortalCallback.OnLoggingOut(player);
            }
            onlinePlayers.Remove(player);
        }

        /// <summary>
        /// Receives player's message.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        /// <param name="m">The message sent.</param>
        /// <returns>A string with the player and the sent message.</returns>
        public void ChatMessage(Player player, string message)
        {
            foreach (Player p in onlinePlayers)
            {
                p.PortalCallback.OnMessage(player.Username + ": " + message);
            }
        }
    }
}
