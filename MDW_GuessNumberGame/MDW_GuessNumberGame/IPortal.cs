using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace MDW_GuessNumberGame
{
    [ServiceContract(Namespace = "MDW_GuessNumberGame", CallbackContract = typeof(IPortalCallBack))]
    public interface IPortal
    {
        //method to register a user
        [OperationContract]
        bool signUp(Player p);

        //method so that a user logs in
        [OperationContract]
        bool logIn(Player p);

        //method used to invite another user
        [OperationContract]
        bool Invite(Player p1, Player p2);

        //methods to log out a user
        [OperationContract]
        void logOut(Player p);

        //method returns the list of players
        [OperationContract]
        List<Player> GetlistOfPlayers();

        [OperationContract]
        string ChatMessage(Player p, string message);
        
        //method to update number of the player's guess
        [OperationContract]
        void updateScore(string userName, int guessNr);

    }

    public interface IPortalCallBack
    {
        
        //To inform a user when an invitation from another player has been recieved
        [OperationContract]
        bool OnInvitation(string sender, Player recipient);

        //this event will be fired when a user logs in or out,to update the list of the logged in users. 
        [OperationContract]
        void OnLoggingInOrOut1(List<Player> loggedInList);

        //to show the message to the other user in the chatbox
        [OperationContract]
        void messageRecieved(string message);

        //to let the other user know that the player has left the game
        [OperationContract]
        void gameInterupted(string message);

        //method for updating the number of the player's guess
        [OperationContract]
        void guessChange(int guessNr);
    } 
}
