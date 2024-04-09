namespace EAgendaMedicaWinForms.Models.Autenticacao
{
    public class LoginUsuario 
    {
        public LoginUsuario(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; }
        public string Senha { get; }
    }
}
