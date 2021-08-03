using BLL;
using DAL;
using System.Data;

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


    }
}
