﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmServer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLoginAdmin frmLoginAdmin = new FrmLoginAdmin();
            frmLoginAdmin.ShowDialog();
            if(frmLoginAdmin.DialogResult== DialogResult.OK)
            {
                frmLoginAdmin.Dispose();
                FrmServer frmServer = new FrmServer();
                frmServer.ShowDialog();
            }
        }
    }
}
