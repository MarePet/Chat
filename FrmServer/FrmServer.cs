using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmServer
{
    public partial class FrmServer : Form
    {
        Server server;
        Thread serverskaNit;
        public FrmServer()
        {
            InitializeComponent();
            lblAdmin.Text = Controller.Instance.CurrentAdmin.ToString();
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.Start();
            serverskaNit = new Thread(server.HandleClients);
            serverskaNit.Start();
            serverskaNit.IsBackground = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            serverskaNit.Abort();
        }
    }
}
