
namespace EAgendaMedicaWinForms.Models.Medicos
{
    public class ListarMedicos 
    {
        public string Id { get; set; }
        public string NomeEPrefixo { get; set; }
        public string Crm { get; set; }
       
        public ListarMedicos()
        {
                
        }
    }

    public class CadastrarMedico 
    {
        public PrefixoMedico Prefixo { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }

        public CadastrarMedico()
        {
           
        }
        public CadastrarMedico(PrefixoMedico prefixo, string nome, string crm)
        {
            Prefixo = prefixo;
            Nome = nome;
            Crm = crm;
        }
    }

    public enum PrefixoMedico
    {
        Dr,
        Dra
    }
}
