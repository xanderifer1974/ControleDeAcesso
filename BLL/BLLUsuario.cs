using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;

        public BLLUsuario(DALConexao cx)
        {
            conexao = cx;
        }

        public void Incluir(Usuario usuario)
        {
            if(usuario.Grupo.Trim().Length == 0)
            {
                throw new Exception("O grupo do usuário deve ser informado!");
            }

            if (usuario.Login.Trim().Length == 0)
            {
                throw new Exception("O login do usuário deve ser informado!");
            }

            if (usuario.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário deve ser informado!");
            }

            if (usuario.Senha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuário deve ser informada!");
            }
          

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Incluir(usuario);

        }

        public void Atualizar(Usuario usuario)
        {
            if (usuario.Grupo.Trim().Length == 0)
            {
                throw new Exception("O grupo do usuário deve ser informado!");
            }

            if (usuario.Login.Trim().Length == 0)
            {
                throw new Exception("O login do usuário deve ser informado!");
            }

            if (usuario.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário deve ser informado!");
            }

            if (usuario.Senha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuário deve ser informada!");
            }

            if (usuario.Id <=0)
            {
                throw new Exception("O código do usuário deve ser informado!");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Alterar(usuario);
        }

        public void Excluir(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Excluir(codigo);

        }

        public Usuario CarregarUsuario(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregarUsuario(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable Localizar(string nome)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(nome);
        }

        public DataTable LocalizarUsuarioLogin(string login, string senha)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarUsuarioLogin(login,senha);
        }
    }
}
