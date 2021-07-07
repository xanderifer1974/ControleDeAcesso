using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDeConexao
    {
        public static String servidor = "ALEXANDREFERREI";
        public static String banco = "ControleDeAcesso";
        public static String usuario = "sa";
        public static String senha = "30012000";
        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }
        }
    }
}
