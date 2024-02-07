using Domen;
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
using Message = Domen.Message;

namespace KlijentskiInterfejs
{
    public partial class FrmKlijent : Form
    {
        List<string> najnovije = new List<string>();
        public FrmKlijent()
        {
            InitializeComponent();
           
            Thread readMessages = new Thread(ReadMessages);
            readMessages.Start();
        }

        private void ReadMessages()
        {
            
            Thread.Sleep(10000);
            while (true)
            {
                Thread appendData = new Thread(AppendData);
                Message m = new Message(Operacija.GetOnlineUsers);
                Communication.Instance.Send(m);
                m = Communication.Instance.Recieve();
                try
                {
                    Invoke(new Action(() =>
                            {
                                cbOnlineKorisnici.DataSource = new List<User>();
                                if (m.ResponseObject == null) return;
                                cbOnlineKorisnici.DataSource = m.ResponseObject;
                            }));
                }
                catch (ObjectDisposedException)
                {
                    return;
                }
                if (m.Operacija == Operacija.PristiglaPoruka)
                {
                    najnovije.Add(m.MessageText);
                    if (najnovije.Count > 3) najnovije.RemoveAt(0);
                    Invoke(new Action(() =>
                    {
                        txtNajnovije.Text = "";
                        txtNajnovije.Text += m.FromWho + ": " + string.Join(Environment.NewLine, najnovije);
                        txtSve.Text += m.FromWho + ":" + m.MessageText + Environment.NewLine;
                    }));
                }
            }
        }

        private void AppendData()
        {
            
        }

        private void btnSendToAll_Click(object sender, EventArgs e)
        {
            Message m = new Message(Operacija.SendToAll);
            m.FromWho = Communication.Instance.CurrentUser.Username;
            m.MessageText = txtSendToAll.Text;
            Communication.Instance.Send(m);
        }

        private void FrmKlijent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Message m = new Message(Operacija.DiskonektujKorisnika);
            m.FromWho = Communication.Instance.CurrentUser.Username;
            Communication.Instance.Send(m);
            
        }
    }
}
