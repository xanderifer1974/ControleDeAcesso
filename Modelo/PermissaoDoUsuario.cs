namespace Modelo
{
    public class PermissaoDoUsuario
    {
        public int PerId { get; set; }
        public int UseId { get; set; }
        public string PerNomeFrm { get; set; }
        public string PerDescricao { get; set; }
        public string Bloqueado { get; set; }
        public string  PerInserir { get; set; }
        public string PerAlterar { get; set; }
        public string PerExcluir { get; set; }
        public string PerImprimir { get; set; }

        public PermissaoDoUsuario()
        {

        }

        public PermissaoDoUsuario(int perId, int useId, string perNomeFrm, string perDescricao, string perInserir, string perAlterar, string perExcluir, string perImprimir)
        {
            PerId = perId;
            UseId = useId;
            PerNomeFrm = perNomeFrm;
            PerDescricao = perDescricao;
            PerInserir = perInserir;
            PerAlterar = perAlterar;
            PerExcluir = perExcluir;

        }

    }
}
