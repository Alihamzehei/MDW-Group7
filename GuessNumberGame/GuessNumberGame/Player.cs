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
        private string username;

        [DataMember]
        private string password;

        private IPortalCallBack portalCallBack;

        private IGameCallBack gameCallback;

        public string Username 
        {
            get { return username; }
        }

        public string Password
        {
            get { return password; }
        }

        public IPortalCallBack PortalCallback
        {
            get { return portalCallBack; }
        }

        public IGameCallBack GameCallback
        {
            set { gameCallback = value; }
            get { return gameCallback; }
        }

        public Player(string un,string pw)
        {
            this.username = un;
            this.password = pw;
            this.portalCallBack = OperationContext.Current.GetCallbackChannel<IPortalCallBack>();
        }
    }
}
