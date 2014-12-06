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
        //method to register a user
        [OperationContract]
        bool UserRegister(Player p);

        //method so that a user logs in
        [OperationContract]
        bool logIn(Player p);

        //method used to invite another user
        [OperationContract]
        bool InvitePlayer(Player send, Player receive);

        //methods to log out a user
        [OperationContract]
        void UserLogOut(Player p);

        [OperationContract]
        string ChatMessage(Player p, string m);
        
        //method to update the score for a user
        [OperationContract]
        void CountGuessTime();

    }

    public interface IPortalCallBack
    {
        //To inform a user when an invitation from another player has been recieved
        [OperationContract]
        bool OnInvitation(Player sender);

        //this event will be fired when a user logs in or out,to update the list of the logged in users. 
        [OperationContract]
        void OnLoggingInOrOut1(Player player);

        
        //to show the message to the other user in the chatbox
        [OperationContract]
        void messageRecieved(string message);
    }

}
