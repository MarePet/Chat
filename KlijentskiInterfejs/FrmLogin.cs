using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentskiInterfejs
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Communication.Instance.Connect();
            User user = new User() { 
                Username= txtUsername.Text,
                Password= txtPassword.Text,
            };
            Domen.Message request = new Domen.Message(Operacija.Login, user);
            Communication.Instance.Send(request);
            Domen.Message response = Communication.Instance.Recieve();
            if(response.ResponseObject!= null)
            {
                Communication.Instance.CurrentUser = (User)response.ResponseObject;
                DialogResult= DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Korisnik ne postoji!");
            }
        }
    }
}
