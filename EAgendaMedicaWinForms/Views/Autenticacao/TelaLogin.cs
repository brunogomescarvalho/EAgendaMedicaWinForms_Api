using EAgendaMedicaWinForms.Models.Autenticacao;
using EAgendaMedicaWinForms.Views.Compartilhado;
using EAgendaMedicaWinForms.Views.TelaPrincipal;
using FluentResults;

public delegate Task<Result<Token>> FazerLoginDelegate(LoginUsuario model);

namespace EAgendaMedicaWinForms.Views.Autenticaco
{
    public partial class TelaLogin : Form
    {

        public LoginUsuario usuario;

        public FazerLoginDelegate fazerLoginDelegate;

        public bool EfetuouCadastro = false;

        public TelaLogin()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private async void BtnEntrar_Click(object sender, EventArgs e)
        {
            txtLoginCarregando.Text = "Aguarde, efetuando requisição...";

            var senha = txtSenha.Text;
            var email = txtEmail.Text;

            var result = await fazerLoginDelegate(new LoginUsuario(email, senha));

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

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && EfetuouCadastro == false)
            {
                Environment.Exit(0);
            }
        }

        private void LinkCadastrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EfetuouCadastro = true;

            TelaPrincipalForm.Instancia.CadastrarNovoUsuario();
        }
    }
}

