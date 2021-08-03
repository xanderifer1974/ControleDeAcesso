using BLL;
using DAL;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim().Length == 0 || txtSenha.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Os campos usuários e senha são de preenchimento obrigatório!!! \n\n" +
                        "Preecha os dados e clique novamente em logar!!!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }
                DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarUsuarioLogin(txtUsuario.Text, txtSenha.Text);
                if (tabela.Rows.Count == 1)
                {
                    SessaoUsuario.Session.Instance.UsuId = Convert.ToInt32(tabela.Rows[0][0].ToString());
                    SessaoUsuario.Session.Instance.UsuNome = tabela.Rows[0][1].ToString();
                    SessaoUsuario.Session.Instance.UsuGrupo = tabela.Rows[0][3].ToString();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                    return;
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ocorrido ao tentar processar os dados \n\n Contacte o Administrador do Sistema\n\nErro ocorrido: " + erro.Message
               , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            VerificarPermissaoUsuario.VerificaCaracterNaoPermitido(txtUsuario.Text);            
        }
    }
}
