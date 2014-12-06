using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{   
    [ServiceContract]
    public interface IGame
    {
        [OperationContract]
        bool guessNumber(int[] number);

        [OperationContract]
        void StartGame(Player p1, Player p2);

        [OperationContract]
        void CountGuessTime();

        [OperationContract]
        bool InvitePlayer(Player p1, Player p2);
        

        // TODO: Add your service operations here
    }
}
