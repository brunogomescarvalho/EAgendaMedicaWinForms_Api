using System.Text.Json;

namespace EAgendaMedicaWinForms.Infra
{
    public class LowerCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return name.ToLower();
        }
    }
}
