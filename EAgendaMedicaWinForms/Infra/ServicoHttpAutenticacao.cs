using EAgendaMedicaWinForms.Models.Autenticacao;
using FluentResults;

namespace EAgendaMedicaWinForms.Infra
{
    public class ServicoHttpAutenticacao : ServicoHttpBase
    {
        public async Task<Result<Token?>> EfetuarLoginUsuario(LoginUsuario usuario)
        {
            var result = await EnviarRequisicao<LoginUsuario>(usuario,  HttpMethod.Post, "conta/autenticar");

            if (result.IsFailed)
                return Result.Fail(new Error(result.Reasons.FirstOrDefault()?.Message));

            return Result.Ok((Token)ConverterParaObjeto<Token>(result.Value))!;
        }

        public async Task<Result<Token?>> CadastrarUsuario(CadastrarUsuario usuario)
        {
            var result = await EnviarRequisicao<CadastrarUsuario>(usuario, HttpMethod.Post, "conta/registrar");

            if (result.IsFailed)
                return Result.Fail(new Error(result.Reasons.FirstOrDefault()?.Message));

            return Result.Ok((Token)ConverterParaObjeto<Token>(result.Value))!;
        }
    }
}

