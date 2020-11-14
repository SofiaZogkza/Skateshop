using SkateshopApi.Contracts;
using System.Threading.Tasks;

namespace SkateshopApi.Interfaces
{
    public interface ILogInOutService
    {
        LogInOutResponse LogIn(LogInOutRequest req);
        LogInOutResponse LogOut(LogInOutRequest req);
    }
}
