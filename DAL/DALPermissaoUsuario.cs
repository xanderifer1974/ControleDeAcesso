using Modelo;
using System;
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
    }
}
