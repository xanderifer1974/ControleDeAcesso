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

        /// <summary>
        /// Método para incluir usuário
        /// </summary>
        /// <param name="usuario"></param>
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

        /// <summary>
        /// Método para alterar usuário.
        /// </summary>
        /// <param name="usuario"></param>
        public void Atualizar(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuario set use_nome=@use_nome,use_login=@use_login,use_grupo=@use_grupo,use_senha=@use_senha where use_id=@codigo";
            cmd.Parameters.AddWithValue("@codigo", usuario.Id);
            cmd.Parameters.AddWithValue("@use_nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@use_login", usuario.Login);
            cmd.Parameters.AddWithValue("@use_grupo", usuario.Grupo);
            cmd.Parameters.AddWithValue("@use_senha", usuario.Senha);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        /// <summary>
        /// Método para excluir usuário.
        /// </summary>
        /// <param name="codigo"></param>
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from usuario where use_id=@codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();


        }
        
    }
}
