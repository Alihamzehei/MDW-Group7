using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.ServiceModel;
using Server;
using Client.ServiceGame;


namespace Client
{
    public partial class PlayGame : Form, IGameCallBack
    {
        public PlayGame()
        {
            InitializeComponent();
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {

        }
    }
}
