using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Server;


namespace Client
{
    public partial class Register : Form, ServicePortal.IPortalCallback
    {
        private ServicePortal.IPortal proxy;
        private IPortalCallBack portalCallback;
        
        public Register()
        {
            InitializeComponent();
            InstanceContext context = new InstanceContext(this);
            proxy = new ServicePortal.PortalClient(context);
            portalCallback = OperationContext.Current.GetCallbackChannel<IPortalCallBack>();
        }

        public void messageReceived(string m)
        {
            throw new NotImplementedException();
        }

        public bool OnInvitation(Player p)
        {
            throw new NotImplementedException();
        }

        public void OnLoggingIn(Player p)
        {
            throw new NotImplementedException();
        }

        public void OnLoggingOut(Player p)
        {
            throw new NotImplementedException();
        }

        public void OnMessage(string m)
        {
            throw new NotImplementedException();
        }

        public void Register_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            String userName = this.tb_username.ToString();
            String passWord = this.tb_password.ToString();
            String repassWord = this.tb_repassword.ToString();
            if (passWord == repassWord)
            {
                Player player = new Player(userName, passWord);
                this.label_error_message.Visible = false;
                proxy.UserRegister(player);
            }
            else
            {
                this.label_error_message.Visible = true;
            }
        }
    }
}
