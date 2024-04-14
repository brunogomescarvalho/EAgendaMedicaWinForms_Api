using EAgendaMedicaWinForms.Views.Compartilhado;

namespace EAgendaMedicaWinForms.Controllers
{
    public abstract class ControladorBase
    {
        public abstract Task<UserControl> ObterListagem();
        public abstract ConfiguracaoToolboxBase ObterConfiguracaoToolbox();
        public abstract Task Cadastrar();
        public abstract Task Editar();
        public abstract Task Excluir();
       

    }
}
