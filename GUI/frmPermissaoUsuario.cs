using BLL;
using DAL;
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
            DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);

            BLLPermissaoDoUsuario bll = new BLLPermissaoDoUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.Localizar(Convert.ToInt32(txtValor.Text));
            int tPermissao = 0;
            tPermissao = tabela.Rows.Count;
            if (tPermissao > 0)
            {
                //Carrega permissões do  banco
                for(int x = 0; x < tPermissao; x++)
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
            }
            else
            {
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
            }
            alteraBotoes(3);
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
