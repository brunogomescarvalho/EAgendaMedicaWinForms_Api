namespace EAgendaMedicaWinForms.Models.Autenticacao
{
    public class Token 
    {
        public string Chave { get; set; }
        public UsuarioToken UsuarioToken { get; set; }
        public string DataExpiracao { get; set; }
    }
}
