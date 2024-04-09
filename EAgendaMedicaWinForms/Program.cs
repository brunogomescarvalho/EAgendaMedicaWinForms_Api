using EAgendaMedicaWinForms.Views.TelaPrincipal;

namespace EAgendaMedicaWinForms
{
    public static class Program
    {
      
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
                  
            Application.Run(new TelaPrincipalForm());
        }
    }
}