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
        string CheckNumber(int[] number,Player player);

        [OperationContract]
        void QuitGame(Player player);
    }

    public interface IGameCallBack
    {
        [OperationContract]
        void OnGameInterupted(Player player);

        [OperationContract]
        void OnWinner(Player player);
    }
}
