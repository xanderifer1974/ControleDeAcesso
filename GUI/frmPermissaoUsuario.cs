using BLL;
using DAL;
using GUI.Common;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPermissaoUsuario : Form
    {
        public frmPermissaoUsuario()
        {
            InitializeComponent();
        }

        string operacao = "";
        int usoId = 0;
        string usoLoginPesquisado = "";
        string usoNomePesquiado = "";


        public void alteraBotoes(int op)
        { // 1 - Inserir e Localizar 2 - Inserir e Alterar  3 - Excluir e Alterar

            btnAlterar.Enabled = false;
            btnPesquisar.Enabled = false;
            btnLocalizarPermissao.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            dgvDadosPermissao.Enabled = false;
            gbxMarcarTodos.Enabled = false;
            btnExcluir.Enabled = false;




            if (op == 1)
            {
                btnPesquisar.Enabled = true;
                btnLocalizarPermissao.Enabled = true;
            }

            if (op == 2)
            {
                dgvDadosPermissao.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                gbxMarcarTodos.Enabled = true;
            }

            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }

        private void frmPermissaoUsuario_Load(object sender, EventArgs e)
        {
            alteraBotoes(1);
        }

        private void btnLocalizarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);

                //Verifica se existe usuário
                BLLUsuario bllTestaUsuario = new BLLUsuario(cx);
                if(bllTestaUsuario.Localizar(Convert.ToInt32(txtValor.Text)).Rows.Count <= 0)
                {
                    MessageBox.Show("Atenção!!! O código digitado não corresponde  a nenhum usuário Cadastrado!!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValor.Focus();
                    txtValor.Text = "";
                    return;
                }

                BLLPermissaoDoUsuario bll = new BLLPermissaoDoUsuario(cx);
                DataTable tabela = new DataTable();
                tabela = bll.Localizar(Convert.ToInt32(txtValor.Text));
                int tPermissao = 0;
                tPermissao = tabela.Rows.Count;
                if (tPermissao > 0)
                {
                    //Carrega permissões do  banco
                    for (int x = 0; x < tPermissao; x++)
                    {
                        dgvDadosPermissao.Rows.Add();
                        dgvDadosPermissao.Rows[x].Cells[0].Value = tabela.Rows[x][0];
                        dgvDadosPermissao.Rows[x].Cells[1].Value = tabela.Rows[x][1];
                        dgvDadosPermissao.Rows[x].Cells[2].Value = tabela.Rows[x][2];
                        dgvDadosPermissao.Rows[x].Cells[3].Value = tabela.Rows[x][3];
                        dgvDadosPermissao.Rows[x].Cells[4].Value = tabela.Rows[x][4];
                        dgvDadosPermissao.Rows[x].Cells[5].Value = tabela.Rows[x][5];
                        dgvDadosPermissao.Rows[x].Cells[6].Value = tabela.Rows[x][6];
                        dgvDadosPermissao.Rows[x].Cells[7].Value = tabela.Rows[x][7];

                    }
                    usoId = Convert.ToInt32(tabela.Rows[0][10]);
                    usoNomePesquiado = Convert.ToString(tabela.Rows[0][8]);
                    usoLoginPesquisado = Convert.ToString(tabela.Rows[0][9]);
                    operacao = "alterar";
                    alteraBotoes(3);
                    tabela.Dispose();

                }
                else
                {
                    BLLUsuario bllUsuario = new BLLUsuario(cx);
                    DataTable dtbUsuario = new DataTable();
                    dtbUsuario = bllUsuario.Localizar(Convert.ToInt32(txtValor.Text));

                    usoId = Convert.ToInt32(dtbUsuario.Rows[0][0]);
                    usoNomePesquiado = Convert.ToString(dtbUsuario.Rows[0][1]);
                    usoLoginPesquisado = Convert.ToString(dtbUsuario.Rows[0][2]);

                    //Carregar as permissões padrões
                    IDictionary<String, string> strPermissao = new Dictionary<string, string>()
                {
                    {"frmCadastroCliente","Cadastro de Cliente" },
                    {"frmCadastroFornecedor","Cadastrar Fornecedores" },
                    {"frmVendas","Realizar Vendas" },
                    {"frmCadastroCategoria","Cadastrar Categorias" },
                    {"frmCadastroSubCategorias","Cadastrar Sub Categorias" },
                    {"frmCadastroUsuario","Cadastrar Usuários" },
                    {"frmPermissaoUsuario","Cadastrar as permissões de usuários" }
                };
                    int i = 0;
                    foreach (string Perm in strPermissao.Keys)
                    {
                        dgvDadosPermissao.Rows.Add();
                        dgvDadosPermissao.Rows[i].Cells[1].Value = Perm;
                        dgvDadosPermissao.Rows[i].Cells[2].Value = strPermissao[Perm];

                        if (Perm == "frmCadastroUsuario" || Perm == "frmPermissaoUsuario")
                        {
                            dgvDadosPermissao.Rows[i].Cells[3].Value = "true";
                        }
                        else
                        {
                            dgvDadosPermissao.Rows[i].Cells[3].Value = "false";
                            dgvDadosPermissao.Rows[i].Cells[4].Value = "false";
                            dgvDadosPermissao.Rows[i].Cells[5].Value = "false";
                            dgvDadosPermissao.Rows[i].Cells[6].Value = "false";
                            dgvDadosPermissao.Rows[i].Cells[7].Value = "false";

                        }
                        i++;
                    }
                    MessageBox.Show("Atenção \n As configurações Padrão (Default) foram carregadas para o Usuário\n\n" +
                        "Realize as devidas alterações e clique em Salvar para que o usuário tenha acesso ao sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    operacao = "inserir";
                    alteraBotoes(2);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ocorrido na operação \n\n Contacte o Administrador do Sistema\n\nErro ocorrido: " + erro.Message
                 , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtUsuarioPesquisado.Text = usoNomePesquiado + "( " + usoLoginPesquisado + " )";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            alteraBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alteraBotoes(1);
            dgvDadosPermissao.Rows.Clear();
            usoId = 0;
            usoLoginPesquisado = "";
            usoNomePesquiado = "";
            txtValor.Text = "";
            txtUsuarioPesquisado.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
            PermissaoDoUsuario permissaoDoUsuario = new PermissaoDoUsuario();
            BLLPermissaoDoUsuario bll = new BLLPermissaoDoUsuario(cx);

            if(operacao == "alterar")
            {
                //Excluir as permissões do usuário.
                BLLPermissaoDoUsuario bllExcluir = new BLLPermissaoDoUsuario(cx);
                bllExcluir.ExcluiTudo(usoId);
            }
            int tLinhas = dgvDadosPermissao.RowCount;
            //Preencher o modelo e gravar no BD
            for(int i = 0; i < tLinhas; i++)
            {
                permissaoDoUsuario.PerAlterar = Convert.ToString(dgvDadosPermissao.Rows[i].Cells[5].Value);
                permissaoDoUsuario.Bloqueado = Convert.ToString(dgvDadosPermissao.Rows[i].Cells[3].Value);
                permissaoDoUsuario.PerDescricao = Convert.ToString(dgvDadosPermissao.Rows[i].Cells[2].Value);
                permissaoDoUsuario.PerExcluir = Convert.ToString(dgvDadosPermissao.Rows[i].Cells[6].Value);
                permissaoDoUsuario.PerImprimir = Convert.ToString(dgvDadosPermissao.Rows[i].Cells[7].Value);
                permissaoDoUsuario.PerInserir = Convert.ToString(dgvDadosPermissao.Rows[i].Cells[4].Value);
                permissaoDoUsuario.PerNomeFrm = Convert.ToString(dgvDadosPermissao.Rows[i].Cells[1].Value);
                permissaoDoUsuario.UseId = Convert.ToInt32(usoId);
                bll.Incluir(permissaoDoUsuario);
            }
            MessageBox.Show("As permissões foram cadastradas com sucesso!", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
            alteraBotoes(1);
            dgvDadosPermissao.Rows.Clear();
            txtValor.Text = "";
            operacao = "";
            usoId = 0;
            usoLoginPesquisado = "";
            usoNomePesquiado = "";

        }

        private void dgvDadosPermissao_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
         
            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void chxMarcaBloqueado_CheckedChanged(object sender, EventArgs e)
        {
            int qtdeRegistros = dgvDadosPermissao.RowCount;
            for (int i=0; i < qtdeRegistros; i++)
            {
                dgvDadosPermissao.Rows[i].Cells[3].Value = chxMarcaBloqueado.Checked;

            }
        }

        private void chxMarcaInserir_CheckedChanged(object sender, EventArgs e)
        {
            int qtdeRegistros = dgvDadosPermissao.RowCount;
            for (int i = 0; i < qtdeRegistros; i++)
            {
                dgvDadosPermissao.Rows[i].Cells[4].Value = chxMarcaInserir.Checked;

            }
        }

        private void chxMarcaAlterar_CheckedChanged(object sender, EventArgs e)
        {
            int qtdeRegistros = dgvDadosPermissao.RowCount;
            for (int i = 0; i < qtdeRegistros; i++)
            {
                dgvDadosPermissao.Rows[i].Cells[5].Value = chxMarcaAlterar.Checked;

            }

        }

        private void chxMarcaExcluir_CheckedChanged(object sender, EventArgs e)
        {
            int qtdeRegistros = dgvDadosPermissao.RowCount;
            for (int i = 0; i < qtdeRegistros; i++)
            {
                dgvDadosPermissao.Rows[i].Cells[6].Value = chxMarcaExcluir.Checked;

            }
        }

        private void chxMarcaImprimir_CheckedChanged(object sender, EventArgs e)
        {
            int qtdeRegistros = dgvDadosPermissao.RowCount;
            for (int i = 0; i < qtdeRegistros; i++)
            {
                dgvDadosPermissao.Rows[i].Cells[7].Value = chxMarcaImprimir.Checked;

            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmLocalizarUsuario pesquisaUsuario = new frmLocalizarUsuario();
            pesquisaUsuario.ShowDialog();
            if(pesquisaUsuario.codigo != 0)
            {
                txtValor.Text = pesquisaUsuario.codigo.ToString();
                btnLocalizarPermissao_Click(sender, e);
                alteraBotoes(3);
            }
            else
            {
                alteraBotoes(1);
            }
            pesquisaUsuario.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(dgvDadosPermissao.Rows[0].Cells[0].Value) <= 0)
                {
                    dgvDadosPermissao.Rows.Clear();
                    return;
                }

                DialogResult d = MessageBox.Show("Deseja excluir todas as permissões do usuário pesquisado?" +
                    "\n\nAtenção!! Sem as permissões, o usuário não conseguirá acessar o sistema!!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
                    BLLPermissaoDoUsuario bll = new BLLPermissaoDoUsuario(cx);
                    bll.ExcluiTudo(usoId);
                    dgvDadosPermissao.Rows.Clear();
                    alteraBotoes(1);
                }

            }
            catch 
            {

                MessageBox.Show("Impossível Excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            VerificarPermissaoUsuario.VerificaCaracterNaoPermitido(txtValor.Text);
        }
    }
}
