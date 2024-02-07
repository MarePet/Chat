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

namespace FrmServer
{
    public partial class FrmLoginAdmin : Form
    {
        public FrmLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Username = txtUsername.Text;
            admin.Password = txtPassword.Text;
            admin = Controller.Instance.Login(admin);
            if (admin != null)
            {
                DialogResult = DialogResult.OK;
                Controller.Instance.CurrentAdmin= admin;
            }
            else
            {
                MessageBox.Show("Administrator ne postoji!");
                return;
            }
        }
    }
}
