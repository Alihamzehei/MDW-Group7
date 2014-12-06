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
        bool checkNumber(int[] number);

        [OperationContract]
        int[] createNumber();

        [OperationContract]
        void CountGuessTime();

        [OperationContract]
        bool quitGame(Player player);

        
        
        

        // TODO: Add your service operations here
    }
}
