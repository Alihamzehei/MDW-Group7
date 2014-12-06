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
        /// <returns>A string with the player and the sent message.</returns>
        [OperationContract]
        string ChatMessage(Player p, string m);
    }

    public interface IPortalCallBack
    {
        //To inform a user when an invitation from another player has been recieved
        [OperationContract]
        bool OnInvitation(Player sender);

        //this event will be fired when a user logs in or out,to update the list of the logged in users. 
        [OperationContract]
        void OnLoggingIn(Player player);

        [OperationContract]
        void OnLoggingOut(Player p);

        //to show the message to the other user in the chatbox
        [OperationContract]
        void messageRecieved(string message);
    }

}
