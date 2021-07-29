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
    public partial class frmPermissaoUsuario : Form
    {
        public frmPermissaoUsuario()
        {
            InitializeComponent();
        }

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
            foreach( string Perm in strPermissao.Keys)
            {
                dgvDadosPermissao.Rows.Add();
                dgvDadosPermissao.Rows[i].Cells[1].Value = Perm;
                dgvDadosPermissao.Rows[i].Cells[2].Value = strPermissao[Perm];

                if(Perm == "frmCadastroUsuario" || Perm == "frmPermissaoUsuario")
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
    }
}
