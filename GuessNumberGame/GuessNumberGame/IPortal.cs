using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    [ServiceContract(Namespace = "Server", CallbackContract = typeof(IPortalCallBack))]
    public interface IPortal
    {
        /// <summary>
        /// It is used to register a player to DB.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        /// <returns>True for success, false for fail.</returns>
        [OperationContract]
        bool UserRegister(Player p);

        /// <summary>
        /// It is used to log in a player.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        /// <returns>True for success, false for fail.</returns>
        [OperationContract]
        bool logIn(Player p);

        /// <summary>
        /// Invites the player for a game.
        /// </summary>
        /// <param name="send">The sender of invitation.</param>
        /// <param name="receive">The receiver of invitation.</param>
        /// <returns>True for acceptance, false for dismissal.</returns>
        [OperationContract]
        bool InvitePlayer(Player send, Player receive);

        /// <summary>
        /// It is used when a player logges out.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        [OperationContract]
        void UserLogOut(Player p);

        /// <summary>
        /// Receives player's message.
        /// </summary>
        /// <param name="p">The player of the game.</param>
        /// <param name="m">The message sent.</param>
        [OperationContract]
        void ChatMessage(Player p, string m);
    }

    public interface IPortalCallBack
    {
        /// <summary>
        /// It is called when a user sends an invitation.
        /// </summary>
        /// <param name="sender">The sender of the invitation.</param>
        /// <returns>True for accept, false for deny.</returns>
        [OperationContract]
        bool OnInvitation(Player sender);

        /// <summary>
        /// It is called when a player connects to lobby.
        /// </summary>
        /// <param name="player">The new player.</param>
        [OperationContract]
        void OnLoggingIn(Player player);

        /// <summary>
        /// It is called when a player leaves lobby.
        /// </summary>
        /// <param name="p">The leaving player.</param>
        [OperationContract]
        void OnLoggingOut(Player p);

        /// <summary>
        /// It is called when a player sends a message on chat.
        /// </summary>
        /// <param name="message">The sent message INCLUDING player's name.</param>
        [OperationContract]
        void messageRecieved(string message);
    }

}
