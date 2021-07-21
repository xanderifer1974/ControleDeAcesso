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
    public partial class frmModeloCadastro : Form
    {
        //Variáveis que serão utilizadas nos formulários filhos
        public string operacao;


        public frmModeloCadastro()
        {
          
            InitializeComponent();
        }

        public void alteraBotoes(int op, Boolean perInserir, Boolean perAlterar, Boolean perExcluir, Boolean perImprimir)
        { // 1 - Inserir e Localizar 2 - Inserir e Alterar  3 - Excluir e Alterar
            pnDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnPesquisar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if (op == 1)
            {
                pnDados.Enabled = perInserir;
                btnPesquisar.Enabled = true;
            }

            if (op == 2)
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 3)
            {
                btnAlterar.Enabled = perAlterar;
                btnExcluir.Enabled = perExcluir;
                btnCancelar.Enabled = true;
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void frmModeloCadastro_Load(object sender, EventArgs e)
        {
            alteraBotoes(1, false, false, false, false);
        }
    }
}
