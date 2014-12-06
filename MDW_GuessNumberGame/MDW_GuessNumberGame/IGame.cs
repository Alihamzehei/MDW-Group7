using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MDW_GuessNumberGame
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [DataContract]
    public class Player
    {
        string userName;
        string passWord;
        IGameCallBack callback;

        public Player(string userName, string passWord, IGameCallBack cb)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.callback=cb;
        }

        [DataMember]
        public string UserName
        { get; set; }
        [DataMember]
        public string PassWord
        { get; set; }


    }

    [DataContract]
    public class Number
    {
        private int[] arrayNumber;
        

        public Number(int[] arrayNumber, int arrayLength)
        {
            
            
        }

        public void CreateGuessNumber()
        {
            Random rnd = new Random(9999);
        }
        
        public bool CheckGuessNumber()
        { return false; }

    }

    
    [ServiceContract]
    public interface IGame
    {
        [OperationContract]
        void StartGame(Player p1,Player p2);
        [OperationContract]
        void CountGuessTime();
        [OperationContract]
        bool InvitePlayer(Player p1, Player p2);
    }
    [ServiceContract]
    public interface IGameCallBack
    {
        
        [OperationContract]
        void SendMessage(Player p1, string message);

        
    }

    [ServiceContract]
    
}
