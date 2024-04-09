using EAgendaMedicaWinForms.Models.Autenticacao;
using EAgendaMedicaWinForms.Views.Compartilhado;
using EAgendaMedicaWinForms.Views.TelaPrincipal;
using FluentResults;

namespace EAgendaMedicaWinForms.Views.Autenticacao
{
    public delegate Task<Result<Token>> OnEnviarRegistro(CadastrarUsuario model);
    public partial class TelaCadastrarUsuarioForm : Form
    {
        public OnEnviarRegistro onCadastrarUsuario;
        public TelaCadastrarUsuarioForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private async void BtnCadastrar_Click(object sender, EventArgs e)
        {
            txtLoginCarregando.Text = "Aguarde, efetuando requisição";

            var nome = TxtNome.Text;
            var senha = TxtSenha.Text;
            var email = TxtEmail.Text;
            var confSenha = TxtConfirmaSenha.Text;

            var usuario = new CadastrarUsuario(nome,email,senha,confSenha);

            var result = await onCadastrarUsuario(usuario);

            if (result.IsFailed)
            {
                DialogResult = DialogResult.None;

                MessageBox.Show("Erro ao efetuar Login", result.Reasons.First().Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TelaPrincipalForm.Instancia.SalvarToken(result.Value);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
