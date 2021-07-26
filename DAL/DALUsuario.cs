using Modelo;
using System;
using System.Data;
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
        public void Alterar(Usuario usuario)
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

        /// <summary>
        /// Método para carregar dados do usuário na tela
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Usuario CarregarUsuario(int codigo)
        {
            Usuario usuario = new Usuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where use_id=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                usuario.Id = Convert.ToInt32(registro["use_id"]);
                usuario.Nome = Convert.ToString(registro["use_nome"]);
                usuario.Grupo = Convert.ToString(registro["use_grupo"]);
                usuario.Login = Convert.ToString(registro["use_login"]);
                usuario.Senha = Convert.ToString(registro["use_senha"]);
            }
            conexao.Desconectar();
            registro.Close();
            return usuario;
        }

        /// <summary>
        /// Método para localizar usuário por código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where use_id=" + codigo.ToString(), conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        /// <summary>
        /// Método para localizar usuário por nome ou login
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public DataTable Localizar(string nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where use_nome like '%" + nome.ToString() +
                "%' OR use_login like '%" + nome.ToString() + "%'", conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        /// <summary>
        /// Método para pesquisar login e senha de usuário
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public DataTable LocalizarUsuarioLogin(string login, string senha)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where use_login='" + login.ToString() +
                "COLATE SQL_Latin1_General_CP1_CS_AS and use_senha='" + senha.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;

        }



    }
}
