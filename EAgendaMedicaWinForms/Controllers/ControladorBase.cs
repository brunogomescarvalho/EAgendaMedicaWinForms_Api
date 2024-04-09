using EAgendaMedicaWinForms.Views.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAgendaMedicaWinForms.Controllers
{
    public abstract class ControladorBase
    {
        public abstract Task<UserControl> ObterListagem();
        public abstract ConfiguracaoToolboxBase ObterConfiguracaoToolbox();
        public abstract Task Cadastrar();
        public abstract Task Excluir();
       

    }
}
