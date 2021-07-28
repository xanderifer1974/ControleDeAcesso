using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALPermissaoUsuario
    {

        private DALConexao conexao;

        public DALPermissaoUsuario(DALConexao cx)
        {
            conexao = cx;
        }

        /// <summary>
        /// Método para incluir permissão do usuário
        /// </summary>
        /// <param name="permissaoDoUsuario"></param>
        public void Incluir(PermissaoDoUsuario permissaoDoUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into permissao_usuario(use_id,per_nomefrm,per_descricao,per_bloqueada,per_inserir,per_alterar,per_excluir,per_imprimir) values" +
                               "(@use_id,@per_nomefrm,@per_descricao,@per_bloqueada,@per_inserir,@per_alterar,@per_excluir,@per_imprimir); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@use_id", permissaoDoUsuario.UseId);
            cmd.Parameters.AddWithValue("@per_nomefrm", permissaoDoUsuario.PerNomeFrm);
            cmd.Parameters.AddWithValue("@per_descricao", permissaoDoUsuario.PerDescricao);
            cmd.Parameters.AddWithValue("@per_bloqueada", permissaoDoUsuario.Bloqueado);
            cmd.Parameters.AddWithValue("@per_inserir", permissaoDoUsuario.PerInserir);
            cmd.Parameters.AddWithValue("@per_alterar", permissaoDoUsuario.PerAlterar);
            cmd.Parameters.AddWithValue("@per_excluir", permissaoDoUsuario.PerExcluir);
            cmd.Parameters.AddWithValue("@per_imprimir", permissaoDoUsuario.PerImprimir);
            conexao.Conectar();
            permissaoDoUsuario.PerId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        /// <summary>
        /// Método para excluir as permissões do usuário.
        /// </summary>
        /// <param name="codigo"></param>
        public void ExcluirTudo(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from permissao_usuario where use_id=@codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        /// <summary>
        /// Método para carregar as permissões do usuário.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public PermissaoDoUsuario CarregarPermissaoDoUsuario(int codigo)
        {
            PermissaoDoUsuario permissaoDoUsuario = new PermissaoDoUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from permissao_usuario where use_id=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                permissaoDoUsuario.PerId = Convert.ToInt32(registro["per_id"]);
                permissaoDoUsuario.UseId = Convert.ToInt32(registro["use_id"]);
                permissaoDoUsuario.PerNomeFrm = Convert.ToString(registro["per_nomefrm"]);
                permissaoDoUsuario.PerDescricao = Convert.ToString(registro["per_descricao"]);
                permissaoDoUsuario.Bloqueado = Convert.ToString(registro["per_bloqueada"]);
                permissaoDoUsuario.PerInserir = Convert.ToString(registro["per_inserir"]);
                permissaoDoUsuario.PerAlterar = Convert.ToString(registro["per_alterar"]);
                permissaoDoUsuario.PerExcluir = Convert.ToString(registro["per_excluir"]);
                permissaoDoUsuario.PerImprimir = Convert.ToString(registro["per_imprimir"]);               
            }
            conexao.Desconectar();
            registro.Close();
            return permissaoDoUsuario;
        }

        /// <summary>
        /// Método que preenche o DGV Dados com as permissões
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select p.per_id, p.per_nomefrm,p.per_descricao,p.per_bloqueada,p.per_inserir,p.per_alterar,p.per_excluir,p.per_imprimir," +
                "u.use_nome,u.use_login,u.use_id from usuario u inner join permissao_usuario p on u.use_id=p.use_id" +
                "where u.use_id =" + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        /// <summary>
        /// Método localizar que pega a permissão do usuario para ser utilizado nos formulários.
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="nomeFormulario"></param>
        /// <returns></returns>
        public DataTable LocalizarPermissoes(int idUsuario, string nomeFormulario)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select p.per_id, p.per_nomefrm,p.per_descricao,p.per_bloqueada,p.per_inserir,p.per_alterar,p.per_excluir,p.per_imprimir," +
                "u.use_nome,u.use_login,u.use_id from usuario u inner join permissao_usuario p on u.use_id=p.use_id" +
                "where p.per_nomefrm ='" + nomeFormulario.ToString() + "' and p.use_id = " + idUsuario.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }



    }
}
