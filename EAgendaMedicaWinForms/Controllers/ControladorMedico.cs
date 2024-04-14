using EAgendaMedicaWinForms.Infra;
using EAgendaMedicaWinForms.Models.Medicos;
using EAgendaMedicaWinForms.Views.Compartilhado;
using EAgendaMedicaWinForms.Views.Medicos;
using EAgendaMedicaWinForms.Views.TelaPrincipal;
using FluentResults;

namespace EAgendaMedicaWinForms.Controllers
{
    public class ControladorMedico : ControladorBase
    {
        TabelaMedicos tabelaMedicos = null!;

        ServicoHttpMedico httpMedico;

        Guid Id = default;

        public ControladorMedico(ServicoHttpMedico httpMedico)
        {
            this.httpMedico = httpMedico;
        }

        public override async Task Cadastrar()
        {
            var telaCadastro = new TelaCadastrarMedico(new())
            {
                Text = "Cadastrar Médico"
            };

            telaCadastro.onGravarRegistro += httpMedico.Cadastrar;

            if (telaCadastro.ShowDialog() == DialogResult.OK)
            {
                await ObterListagem();
            }

        }

        public override async Task Editar()
        {
            Id = tabelaMedicos.ObterIdSelecionado();

            if (Id == default)
            {
                MessageBox.Show("Por favor, selecione um registro para editar", "Selecione um Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var medico = await httpMedico.SelecionarPorId(Id);

            var result = MessageBox.Show($"Confirma editar o(a) médico(a) '{medico.Value.Nome}' ?", "Editar Médico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            var tela = new TelaCadastrarMedico(medico.Value)
            {
                Text = "Editar Médico"
            };

            tela.onGravarRegistro += EditarMedico;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                await ObterListagem();
            }
        }

        private async Task<Result<CadastrarMedico>> EditarMedico(CadastrarMedico registro)
        {
            return await httpMedico.Editar(registro, Id);
        }

        public override async Task Excluir()
        {
            var idSelecionado = tabelaMedicos.ObterIdSelecionado();

            if (idSelecionado == default)
            {
                MessageBox.Show("Por favor, selecione um registro para excluir", "Selecione um Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var resposta = MessageBox.Show("Confirma excluír o registro selecionado?", "Excluír Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.OK)
            {
                var result = await httpMedico.Excluir(idSelecionado);

                if (result.IsSuccess)
                {
                    await ObterListagem();
                }
                else
                {
                    MessageBox.Show("Erro ao processar requisição", result.Errors[0].Message);
                }

            }
        }

        public override ConfiguracaoToolboxBase ObterConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxMedico();
        }

        public override async Task<UserControl> ObterListagem()
        {
            tabelaMedicos ??= new TabelaMedicos();

            await AtualizarMedicos();

            return tabelaMedicos;
        }

        private async Task AtualizarMedicos()
        {
            Thread.Sleep(1000);

            var result = await httpMedico!.SelecionarTodos();

            List<ListarMedicos> medicos = result.Value!;

            tabelaMedicos!.AtualizarRegistros(medicos);

            TelaPrincipalForm.Instancia.AlterarTextRodape(medicos.Count != 0 ? $"Exibindo {medicos.Count} médico(s)" : "Nenhum médico cadastrado até o momento");
        }
    }
}
