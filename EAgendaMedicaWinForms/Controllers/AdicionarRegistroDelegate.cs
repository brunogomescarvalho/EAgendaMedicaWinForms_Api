using FluentResults;

namespace EAgendaMedicaWinForms.Controllers
{
    public delegate Task<Result<T>> OnGravarRegistro<T>(T registro);
}
