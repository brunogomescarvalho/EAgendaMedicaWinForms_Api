namespace EAgendaMedicaWinForms.Models.Autenticacao
{
    public class CadastrarUsuario
    {
        public CadastrarUsuario(string nome, string email, string senha, string confirmarSenha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            ConfirmarSenha = confirmarSenha;
        }

        public string Nome { get; }
        public string Email { get; }
        public string Senha { get; }
        public string ConfirmarSenha { get; }
    }
}
