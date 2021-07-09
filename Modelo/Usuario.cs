using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string  Grupo { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {
            Id = 0;
            Nome = "";
            Login = "";
            Grupo = "";
            Senha = "";

        }

        public Usuario(int id, string nome, string login, string grupo, string senha)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Grupo = grupo;
            Senha = senha;

        }
    }
}
