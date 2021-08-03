using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroUsuario : GUI.frmModeloCadastro
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        //Variaveis que guardam as permissões
        Boolean perInserir = false;
        Boolean perAlterar = false;
        Boolean perExcluir = false;
        Boolean perImprimir = false;

        private void limparTela()
        {
            foreach(Control c in pnDados.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                //Carregar as permissões do usuário.
                DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
                BLLPermissaoDoUsuario bll = new BLLPermissaoDoUsuario(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarPermissao(SessaoUsuario.Session.Instance.UsuId, this.Name.ToString());

                perInserir = Convert.ToBoolean(tabela.Rows[0][4]);
                perAlterar = Convert.ToBoolean(tabela.Rows[0][5]);
                perExcluir = Convert.ToBoolean(tabela.Rows[0][6]);
                perImprimir = Convert.ToBoolean(tabela.Rows[0][7]);
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao ler as permissões do usuário!!! \n\n Contacte o Administrador do Sistema\n\nErro ocorrido: " + erro.Message
                , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Chamar a função ChecaPermissoes
            alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            operacao = "inserir";
            alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            alteraBotoes(2, perInserir, perAlterar, perExcluir, perImprimir);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpa Tela
            limparTela();
            alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja Excluir o Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    limparTela();
                    alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Impossível Excluir o Registro!!! \n O Registro pode estar vinculado em outras tabelas!!! \n\n Contacte o Administrador do Sistema\n\nErro ocorrido: " + erro.Message
                 ,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Grupo = txtGrupo.Text;
                usuario.Nome = txtNome.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Login = txtLogin.Text;

                DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                if (operacao == "inserir")
                {
                    //Cadastro do usuário.
                    bll.Incluir(usuario);
                    MessageBox.Show("Cadastro Efetuado com Sucesso!!!\n\nCódigo: " + usuario.Id.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Alterar dados
                    usuario.Id = Convert.ToInt32(txtCodigo.Text);
                    bll.Atualizar(usuario);
                    MessageBox.Show("Cadastro Alterado com Sucesso!!!\n\nCódigo: " + usuario.Id.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limparTela();
                alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);
            }
            catch(Exception erro)
            {

                MessageBox.Show("Não foi possível realizar a operação!!! \n\n Contacte o Administrador do Sistema\n\nErro ocorrido: " + erro.Message
                , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            try
            {
                if (operacao == "inserir" && txtLogin.Text.Trim().Length == 0 && txtNome.Text.Trim().Length > 0)
                {
                    string[] f = txtNome.Text.Split(' ');
                    txtLogin.Text = Convert.ToString(f[0] + f.Last());
                }
            }
            catch 
            {

                return;
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                frmLocalizarUsuario f = new frmLocalizarUsuario();
                f.ShowDialog();
                //Carrega os dados no formulário
                if (f.codigo != 0)
                {
                    DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    Usuario usuario = bll.CarregarUsuario(f.codigo);
                    txtCodigo.Text = usuario.Id.ToString();
                    txtGrupo.Text = usuario.Grupo;
                    txtLogin.Text = usuario.Login;
                    txtNome.Text = usuario.Nome;
                    txtSenha.Text = usuario.Senha;
                    alteraBotoes(3, perInserir, perAlterar, perExcluir, perImprimir);

                }
                else
                {
                    limparTela();
                    alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);


                }

                f.Dispose();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível realizar a operação!!! \n\n Contacte o Administrador do Sistema\n\nErro ocorrido: " + erro.Message
                , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
