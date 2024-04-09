using EAgendaMedicaWinForms.Infra;
using EAgendaMedicaWinForms.Views.Autenticacao;
using EAgendaMedicaWinForms.Views.Autenticaco;
using EAgendaMedicaWinForms.Views.TelaPrincipal;

namespace EAgendaMedicaWinForms.Controllers
{
    public class ControladorAutenticacao
    {
        ServicoHttpAutenticacao httpAutenticacao;

        public ControladorAutenticacao(ServicoHttpAutenticacao httpAutenticacao)
        {
            this.httpAutenticacao = httpAutenticacao;
        }

        public void Logar()
        {
            var telaLogin = new TelaLogin();

            telaLogin.fazerLoginDelegate += httpAutenticacao.EfetuarLoginUsuario!;

            TelaPrincipalForm.Instancia.telaLogin = telaLogin;

            telaLogin.ShowDialog();
        }


        public void Cadastrar(TelaLogin telaLogin)
        {
            var telaCadastro = new TelaCadastrarUsuarioForm();

            telaCadastro.onCadastrarUsuario += httpAutenticacao.CadastrarUsuario!;

            telaCadastro.ShowDialog();

            if (telaCadastro.DialogResult == DialogResult.OK)
            {
                TelaPrincipalForm.Instancia.Show();

                telaLogin.Close();
            }

            else
            {
                telaLogin.EfetuouCadastro = false;
            }
        }
    }
}
