using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class SessaoUsuario
    {
        public sealed class Session
        {
            private static volatile Session instance;
            private static object sync = new Object();

            private Session() { }

            public static Session Instance
            {
                get
                {
                    if(instance == null)
                    {
                        lock (sync)
                        {
                            if(instance == null)
                            {
                                instance = new Session();
                            }
                        }
                    }

                    return instance;
                }
            }
                      
            public int UsuId { get; set; }
            public string UsuNome { get; set; }
            public string UsuGrupo { get; set; }
        }
    }
}
