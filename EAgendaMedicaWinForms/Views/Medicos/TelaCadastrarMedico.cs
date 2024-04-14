

using EAgendaMedicaWinForms.Controllers;
using EAgendaMedicaWinForms.Models.Medicos;
using EAgendaMedicaWinForms.Views.Compartilhado;
using EAgendaMedicaWinForms.Views.TelaPrincipal;

namespace EAgendaMedicaWinForms.Views.Medicos
{
    public partial class TelaCadastrarMedico : Form
    {
        public CadastrarMedico medico;

        public Guid Id = default;

        public OnGravarRegistro<CadastrarMedico> onGravarRegistro;

        public TelaCadastrarMedico(CadastrarMedico medico)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.medico = medico;

            radioDr.Checked = medico.Prefixo == PrefixoMedico.Dr;
            radioDra.Checked = medico.Prefixo == PrefixoMedico.Dra;
            txtNome.Text = medico.Nome;
            txtCrm.Text = medico.Crm;
        }

        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            medico.Prefixo = radioDr.Checked ? PrefixoMedico.Dr : PrefixoMedico.Dra;
            medico.Nome =    txtNome.Text;
            medico.Crm =     txtCrm.Text;

            var resultado = await onGravarRegistro(medico);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AlterarTextRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
