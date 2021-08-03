using BLL;
using DAL;
using Ferramentas;
using System.Data;
using System.Windows.Forms;

namespace GUI.Common
{
    public static class VerificarPermissaoUsuario
    {
        private static DALConexao Conexao;
        private static BLLPermissaoDoUsuario PermissaoUsuario;
        private static DataTable Tabela;


        public static DataTable ObterPermissaoDoUsuario(int id, string formulario)
        {
            Conexao = new DALConexao(DadosDeConexao.StringDeConexao);
            PermissaoUsuario = new BLLPermissaoDoUsuario(Conexao);
            Tabela = new DataTable();

            Tabela = PermissaoUsuario.LocalizarPermissao(id, formulario);

            return Tabela;
        }

        public static void VerificaCaracterNaoPermitido(string texto)
        {
            if (CaracterEspecial.VerificarCaracter(texto) != "OK")
            {
                MessageBox.Show("Um caracter não permitido foi inserido!!! \n\n Remova-o e prossiga com a operação!", "Caracter Não Permitido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


    }
}
