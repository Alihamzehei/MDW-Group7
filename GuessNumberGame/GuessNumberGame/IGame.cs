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
        void CountGuessTime();

        
        

        // TODO: Add your service operations here
    }
}
