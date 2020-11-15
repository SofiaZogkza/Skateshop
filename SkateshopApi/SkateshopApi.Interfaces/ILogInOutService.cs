using SkateshopApi.Contracts;
using System.Threading.Tasks;

namespace SkateshopApi.Interfaces
{
    public interface ILogInOutService
    {
        Task<LogInOutResponse> LogIn(LogInOutRequest req);
        Task<LogInOutResponse> LogOut(LogInOutRequest req);
    }
}
