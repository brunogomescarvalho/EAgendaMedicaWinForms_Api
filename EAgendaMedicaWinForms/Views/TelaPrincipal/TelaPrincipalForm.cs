using EAgendaMedicaWinForms.Controllers;
using EAgendaMedicaWinForms.Models.Autenticacao;
using EAgendaMedicaWinForms.Views.Autenticaco;
using EAgendaMedicaWinForms.Views.Compartilhado;


namespace EAgendaMedicaWinForms.Views.TelaPrincipal
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; private set; } = null!;

        public TelaLogin telaLogin;

        private ControladorBase controlador = null!;

        private Token? token;

        private readonly Ioc ioc;

        public TelaPrincipalForm()
        {
            Instancia = this;

            ioc = new Ioc();

            InitializeComponent();

            this.ConfigurarDialog(alterarTamanho: false);

            Logar();

            Show();
        }

        public void AlterarTextRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public string? ObterTokenLogado()
        {
            return token?.Chave;
        }

        public void SalvarToken(Token? token)
        {
            this.token = token;

            ExibirNomeUsuario();
        }

        public void ExibirNomeUsuario()
        {
            barraStatus.Text = "Usuário Logado: " + token!.UsuarioToken.Nome;
        }

        public void CadastrarNovoUsuario()
        {
            ioc.Get<ControladorAutenticacao>().Cadastrar(telaLogin);
        }

        private void Logar()
        {
            ioc.Get<ControladorAutenticacao>().Logar();
        }

        private async Task ConfigurarListagem()
        {
            labelRodape.Text = string.Empty;

            UserControl listagem = await controlador.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            painelRegistros.Controls.Clear();

            painelRegistros.Controls.Add(listagem);
        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
        private async Task ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            this.controlador = controlador;

            var configuracoes = this.controlador.ObterConfiguracaoToolbox();

            ConfigurarTooltips(configuracoes);

            ConfigurarBotoes(configuracoes);

            await ConfigurarListagem();

        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            LabelTipoCadastro.Text = configuracao.TipoCadastro;
            BtnInserir.ToolTipText = configuracao.TooltipInserir;
            BtnEditar.ToolTipText = configuracao.TooltipEditar;
            BtnExcluir.ToolTipText = configuracao.TooltipExcluir;

        }

        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            BtnInserir.Enabled = configuracao.InserirHabilitado;
            BtnEditar.Enabled = configuracao.EditarHabilitado;
            BtnExcluir.Enabled = configuracao.ExcluirHabilitado;

        }

        private async void ClicarNaAbaMedico_Click(object sender, EventArgs e)
        {
            await ConfigurarTelaPrincipal(ioc.Get<ControladorMedico>());
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            controlador.Cadastrar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }
    }
}
