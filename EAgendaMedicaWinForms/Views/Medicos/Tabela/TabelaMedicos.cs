using EAgendaMedicaWinForms.Models.Medicos;
using EAgendaMedicaWinForms.Views.Compartilhado;

namespace EAgendaMedicaWinForms.Views.TelaPrincipal
{
    public partial class TabelaMedicos : UserControl
    {
        public TabelaMedicos()
        {
            InitializeComponent();

            CriarColunas();

            dataGridMedicos.ConfigurarGridSomenteLeitura();

            dataGridMedicos.ConfigurarGridZebrado();
        }


        public Guid ObterIdSelecionado()
        {
            return dataGridMedicos.SelecionarId();
        }

        public void AtualizarRegistros(List<ListarMedicos> medicos)
        {
            dataGridMedicos.Rows.Clear();

            foreach (var medico in medicos)
            {
                dataGridMedicos.Rows.Add(medico.Id, medico.NomeEPrefixo, medico.Crm);
            }
        }


        private void CriarColunas()
        {
            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn()
                {Name = "id", HeaderText = "Número",Visible = false },

                new DataGridViewTextBoxColumn()
                {Name = "nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn()
                {Name = "crm", HeaderText = "Crm"},


            };

            dataGridMedicos.Columns.AddRange(columns);
        }
    }
}


