using EAgendaMedicaWinForms.Controllers;
using EAgendaMedicaWinForms.Infra;
using Microsoft.Extensions.DependencyInjection;

namespace EAgendaMedicaWinForms.Views.TelaPrincipal
{
    public class Ioc
    {
        ServiceProvider container;

        public Ioc()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<ServicoHttpAutenticacao>();
            services.AddTransient<ServicoHttpMedico>();
            services.AddTransient<ControladorAutenticacao>();
            services.AddTransient<ControladorMedico>();

            container = services.BuildServiceProvider();
        }

        public T Get<T>()
        {
            return container.GetService<T>()!;
        }
    }
}
