using EAgendaMedicaWinForms.Models.Medicos;
using FluentResults;

namespace EAgendaMedicaWinForms.Infra
{
    public class ServicoHttpMedico : ServicoHttpBase
    {
        public ServicoHttpMedico() { }

        public async Task<Result<List<ListarMedicos>?>> SelecionarTodos()
        {
            var result = await EnviarRequisicao<ListarMedicos>(default!,  HttpMethod.Get, "medicos", Token);

            if (result.IsFailed)
                return new Error(result.Reasons.First()!.Message);

            return Result.Ok((List<ListarMedicos>)ConverterParaObjeto<List<ListarMedicos>>(result.Value))!;
        }

        public async Task<Result<CadastrarMedico>>Cadastrar(CadastrarMedico medico)
        {
            var result = await EnviarRequisicao<CadastrarMedico>(medico, HttpMethod.Post, "medicos", Token);

            if (result.IsFailed)
                return new Error(result.Reasons.First()!.Message);

            return Result.Ok((CadastrarMedico)ConverterParaObjeto<CadastrarMedico>(result.Value))!;

        }
        public async Task<Result<CadastrarMedico>> SelecionarPorId( Guid id)
        {
            var result = await EnviarRequisicao<CadastrarMedico>(default!, HttpMethod.Get, $"medicos/{id}", Token);

            if (result.IsFailed)
                return new Error(result.Reasons.First()!.Message);

            return Result.Ok((CadastrarMedico)ConverterParaObjeto<CadastrarMedico>(result.Value))!;
        }

        public async Task<Result<CadastrarMedico>>Editar(CadastrarMedico medico, Guid id)
        {
            var result = await EnviarRequisicao<CadastrarMedico>(medico, HttpMethod.Put, $"medicos/{id}", Token);

            if (result.IsFailed)
                return new Error(result.Reasons.First()!.Message);

            return Result.Ok((CadastrarMedico)ConverterParaObjeto<CadastrarMedico>(result.Value))!;
        }

        public async Task<Result<string>>Excluir(Guid id)
        {
            var result = await EnviarRequisicao<ListarMedicos>(default!, HttpMethod.Delete, $"medicos/{id}", Token);

            if (result.IsFailed)
                return new Error(result.Reasons.First()!.Message);

            return Result.Ok("Médico excluído com sucesso")!;

        }
    }
}
