using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //Carregar as permissões do usuário.
            perInserir = true;
            perAlterar = true;
            perExcluir = true;
            perImprimir = true;

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
    }
}
