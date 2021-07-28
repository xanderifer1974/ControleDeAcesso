using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLPermissaoDoUsuario
    {

        private DALConexao conexao;

        public BLLPermissaoDoUsuario(DALConexao cx)
        {
            conexao = cx;
        }

        public void Incluir(PermissaoDoUsuario permissaoDoUsuario)
        {
            if (permissaoDoUsuario.PerDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição é obrigatória!");
            }

            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            DALobj.Incluir(permissaoDoUsuario);

        }

        public void ExcluiTudo(int codigo)
        {           
            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            DALobj.ExcluirTudo(codigo);
        }

        public PermissaoDoUsuario CarregarPermissaoUsuario(int codigo)
        {
            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            return DALobj.CarregarPermissaoDoUsuario(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable LocalizarPermissao(int codigo, string nomeFormulario)
        {
            DALPermissaoUsuario DALobj = new DALPermissaoUsuario(conexao);
            return DALobj.LocalizarPermissoes(codigo, nomeFormulario);
        }

    }
}
