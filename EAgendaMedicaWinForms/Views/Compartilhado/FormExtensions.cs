
namespace EAgendaMedicaWinForms.Views.Compartilhado
{
    public static class FormExtensions
    {
        public static void ConfigurarDialog(this Form form, bool alterarTamanho = true)
        {
            form.ShowIcon = false;
            form.ShowInTaskbar = true;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
          
            if(alterarTamanho)
            {
                form.MaximizeBox = false;
                form.MinimizeBox = false;
            }
        }

    }
}
