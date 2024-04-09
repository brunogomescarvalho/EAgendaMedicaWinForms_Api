using EAgendaMedicaWinForms.Models.Autenticacao;
using EAgendaMedicaWinForms.Views.TelaPrincipal;
using FluentResults;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace EAgendaMedicaWinForms.Infra
{


    public abstract class ServicoHttpBase : MapeadorRespostaHttp
    {
        readonly string url = "https://eagenda-medica-webapi-prod.onrender.com/api/";

        protected static string? Token => TelaPrincipalForm.Instancia.ObterTokenLogado();

        protected async Task<Result<string>> EnviarRequisicao<T>(T entidade, HttpMethod metodo, string rota, string? token = null)
        {
            try
            {
                string body = JsonSerializer.Serialize(entidade);

                var content = new StringContent(body, Encoding.UTF8, "application/json");

                using (var http = new HttpClient())
                {
                    if (token != null)
                        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var request = new HttpRequestMessage(metodo, url + rota)
                    {
                        Content = content
                    };

                    var response = await http.SendAsync(request);

                    return await ProcessarResposta(response);
                }
            }
            catch (Exception ex)
            {
                return Result.Fail(new Error(ex.Message));
            }
        }
    }
}
