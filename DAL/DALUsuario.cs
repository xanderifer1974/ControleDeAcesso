using Modelo;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;

        public DALUsuario(DALConexao cx)
        {
            conexao = cx;
        }

        public void Incluir( Usuario usuario )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuario(use_nome,use_login,use_grupo,use_senha) values"+
                               "(@use_nome,@use_login,@use_grupo,@use_senha); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@use_nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@use_login", usuario.Login);
            cmd.Parameters.AddWithValue("@use_grupo", usuario.Grupo);
            cmd.Parameters.AddWithValue("@use_senha", usuario.Senha);
            conexao.Conectar();
            usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
          
        }
        
    }
}
