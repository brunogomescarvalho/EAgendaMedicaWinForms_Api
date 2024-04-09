using EAgendaMedicaWinForms.Views.Compartilhado;

namespace EAgendaMedicaWinForms.Views.Medicos
{
    internal class ConfiguracaoToolboxMedico : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Médicos";

        public override string TooltipInserir => "Inserir Médico";

        public override string TooltipEditar => "Editar Médico";

        public override string TooltipExcluir => "Excluir Médico";
    }
}

