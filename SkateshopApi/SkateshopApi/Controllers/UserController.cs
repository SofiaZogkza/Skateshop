using SkateshopApi.Contracts;
using SkateshopApi.Interfaces;
using System.Threading.Tasks;
using System.Web.Http;

namespace SkateshopApi.Controllers
{
    public class UserController : ApiController
    {
        private ILogInOutService logInOutService;
        public UserController(ILogInOutService _logInOutService)
        {
            logInOutService = _logInOutService;
        }


        [HttpPost]
        [ActionName("login")]
        public LogInOutResponse LogIn(LogInOutRequest req)
        {
            return logInOutService.LogIn(req);
        }

        [HttpPost]
        [ActionName("logout")]
        public LogInOutResponse LogOut(LogInOutRequest req)
        {
            return logInOutService.LogOut(req);
        }
    }
}
