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
using Server;

namespace Client
{
    public partial class Login : Form, Client.ServicePortal.IPortalCallback
    {
        private Client.ServicePortal.PortalClient PortalProxy;

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
            this.Visible = false;
            Register register = new Register();
            register.Show();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Player temp = new Player(this.tb_username.Text, this.tb_password.Text);
            if (PortalProxy.LogIn(temp))
            {
                MessageBox.Show("Log in Successful!");
            }
            else
            {
                MessageBox.Show("Log in failed.");
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Register register = new Register();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rf = new Register();
            rf.Show();
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

        public void OnMessage(string m)
        {
            throw new NotImplementedException();
        }
        /*IPortalCallback implementation end*/
    }
}
