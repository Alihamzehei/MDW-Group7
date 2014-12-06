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

        public Player(string userName, string passWord)
        {
        }

        [DataMember]
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        [DataMember]
        public string PassWord
        {
            get { return this.passWord; }
            set { this.passWord = value; }
        }


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
            for(int i=0; i<4;i++)
            {
                
            }
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
    public interface IPortalCallBack
    {
        [OperationContract]
        void UserLogin(string userID, string passWord);

        [OperationContract]
        bool UserRegister(string userID, string passWord);
    }
    
}
