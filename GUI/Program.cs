using Ferramentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin();
            Application.Run(login);
            login.Dispose();
            if(SessaoUsuario.Session.Instance.UsuId > 0)
            {
                Application.Run(new FrmPrincipal());
            }
            else
            {
                Application.Exit();
            }
           
        }
    }
}
