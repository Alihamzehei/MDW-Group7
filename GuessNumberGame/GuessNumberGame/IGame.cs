using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    [DataMember]
    public class Number
    {
        private int[] arrayNumber;


        public Number(int[] arrayNumber, int arrayLength)
        {


        }

        public void CreateGuessNumber()
        {
            for (int i = 0; i < 4; i++)
            {

            }
        }
        public bool CheckGuessNumber()
        { return false; }

    }


    [ServiceContract(Namespace = "Server", CallbackContract = typeof(IGameCallBack))]
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

    public interface IGameCallBack
    {

        [OperationContract]
        void SendMessage(Player p1, string message);


    }
}
