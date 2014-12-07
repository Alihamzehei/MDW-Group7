using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    [ServiceContract(Namespace = "Server", CallbackContract = typeof(IGameCallBack))]
    public interface IGame
    {
        [OperationContract]
        string checkNumber(int number);

        [OperationContract]
        void countGuessTimes();

        [OperationContract]
        void quitGame(Player player);

        [OperationContract]
        void winner(Player p);

        // TODO: Add your service operations here
    }

    public interface IGameCallBack
    {
        //to let the other user know that the player has left the game
        [OperationContract]
        void OngameInterupted();

        //method for updating the score for the users
        [OperationContract]
        void OnCountGuessTimes();

        [OperationContract]
        void OnWinner(Player p);
    }
}
