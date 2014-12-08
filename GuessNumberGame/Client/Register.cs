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
    public partial class Register : Form,ServicePortal.IPortal
    {
        private ServicePortal.IPortal proxy;
        public Register()
        {
            InitializeComponent();
            InstanceContext context = new InstanceContext(this);
            proxy = new ServicePortal.PortalClient(context);
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            String userName = this.tb_username.ToString();
            String passWord = this.tb_password.ToString();
            String repassWord = this.tb_repassword.ToString();
            if (passWord == repassWord)
            {   
                Player player = new Player(userName,passWord);
                this.label_error_message.Visible = false;
                proxy.UserRegister(player);
            }
            else {
                this.label_error_message.Visible = true;
            }
            
        }
    }
}
