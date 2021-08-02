using Ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModeloCadastro f = new frmModeloCadastro();
            f.ShowDialog();
            f.Dispose();
        }

        private void mnCadUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario f = new frmCadastroUsuario();
            f.ShowDialog();
            f.Dispose();

        }

        private void mnPermissaoUsuario_Click(object sender, EventArgs e)
        {
            frmPermissaoUsuario f = new frmPermissaoUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            login.Dispose();
            txtUsuarioLogado.Text = SessaoUsuario.Session.Instance.UsuNome;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //txtUsuarioLogado.Text = SessaoUsuario.Session.Instance.UsuNome;
        }
    }
}
