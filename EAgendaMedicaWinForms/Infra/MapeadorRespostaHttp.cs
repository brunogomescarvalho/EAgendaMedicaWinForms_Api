using EAgendaMedicaWinForms.Models.Autenticacao;
using FluentResults;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EAgendaMedicaWinForms.Infra
{
    public abstract class MapeadorRespostaHttp
    {
        protected JsonSerializerOptions? ObterConfiguracao()
        {
            return new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                ReferenceHandler = ReferenceHandler.Preserve,
                PropertyNamingPolicy = new LowerCaseNamingPolicy()

            };
        }
        private async Task<Result<(string dados, bool sucesso)>> ObterDadosDaRespostaEmJson(HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();

            JsonDocument respostaCompleta = JsonDocument.Parse(json);

            bool sucesso = respostaCompleta.RootElement.GetProperty("sucesso").GetBoolean();

            JsonElement dados = respostaCompleta.RootElement.GetProperty("dados");

            return Result.Ok((dados.ToString(), sucesso));

        }

        protected async Task<Result<string>> ProcessarResposta(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var result = await ObterDadosDaRespostaEmJson(response);

                return Result.Ok(result.Value.dados);
            }
            return Result.Fail(new Error(response.StatusCode.ToString()));
        }

        protected object ConverterParaObjeto<T>( string json)
        {
            return JsonSerializer.Deserialize<T>(json, ObterConfiguracao())!;
        }
    }
}