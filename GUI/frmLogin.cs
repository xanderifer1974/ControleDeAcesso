using BLL;
using DAL;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDeConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarUsuarioLogin(txtUsuario.Text, txtSenha.Text);
            if (tabela.Rows.Count == 1)
            {
                SessaoUsuario.Session.Instance.UsuId = Convert.ToInt32(tabela.Rows[0][0].ToString());
                SessaoUsuario.Session.Instance.UsuNome = tabela.Rows[0][1].ToString();
                SessaoUsuario.Session.Instance.UsuGrupo = tabela.Rows[0][3].ToString();
                MessageBox.Show("Usuário encontrado com sucesso");
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
                return;
            }
        }
    }
}
