using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Server
{
    [DataContract]
    public class Player
    {
        [DataMember]
        public string userName;

        [DataMember]
        public string password;

        [DataMember]
        public bool loggedIn;

        [DataMember]
        public Player opponent;

        //players have a callback, so we can callback methods for them
        public IPortalCallBack PortalCallBack { get; set; }

        public IGameCallBack GameCallback { get; set; }

        public Player(string un,string pw)
        {
            this.userName = un;
            this.password = pw;
        }
    }
}
