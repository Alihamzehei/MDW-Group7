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
using Client.ServicePortal;

namespace Client
{
    public partial class Login : Form, Client.ServicePortal.IPortalCallback
    {
        public Client.ServicePortal.PortalClient PortalProxy;

        public Login()
        {
            InitializeComponent();
            InstanceContext context = new InstanceContext(this);
            PortalProxy = new PortalClient(context);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Player temp = new Player();
            if (PortalProxy.logIn(temp))
            {
                MessageBox.Show("Log in Successful!");
            }
            else
            {
                MessageBox.Show("Log in failed.");
            }
        }

        /*IPortalCallback implementation start*/
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

        public void messageRecieved(string m)
        {
            throw new NotImplementedException();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        /*IPortalCallback implementation end*/
    }
}
