using Ferramentas;
using GUI.Common;
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
            DataTable tabela = new DataTable();
            tabela = VerificarPermissaoUsuario.ObterPermissaoDoUsuario(SessaoUsuario.Session.Instance.UsuId, "frmCadastroUsuario");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Usuário não possui permissões cadastradas!! \n\n Contacte o Administrador e solicite as permissões!!","Sem Permissão Cadastrada",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tabela.Dispose();
                return;
            }

            if (Convert.ToBoolean(tabela.Rows[0][3]) ==true)
            {
                MessageBox.Show("Usuário não possui permissão de acesso para este formulário!!", "Sem Permissão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabela.Dispose();
                return;
            }


            frmCadastroUsuario f = new frmCadastroUsuario();
            tabela.Dispose();
            f.ShowDialog();
            f.Dispose();

        }

        private void mnPermissaoUsuario_Click(object sender, EventArgs e)
        {
            frmPermissaoUsuario f = new frmPermissaoUsuario();
            f.ShowDialog();
            f.Dispose();
        }

       

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (SessaoUsuario.Session.Instance.UsuGrupo != "Admin")
            {
                mnUsuarios.Enabled = false;
                mnConsultaFornecedor.Visible = false;
            }
            txtUsuarioLogado.Text = SessaoUsuario.Session.Instance.UsuNome;
        }
    }
}
