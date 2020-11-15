using SkateshopApi.Contracts;
using SkateshopApi.Interfaces;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SkateshopApi.Controllers
{
    public class UserController : ApiController
    {
        private ILogInOutService logInOutService;
        public UserController(ILogInOutService _logInOutService)
        {
            logInOutService = _logInOutService;
        }


        [EnableCors("http://localhost:4200", "*", "*")]
        [HttpPost]
        [ActionName("login")]
        public LogInOutResponse LogIn(LogInOutRequest req)
        {
            return logInOutService.LogIn(req);
        }

        [EnableCors("http://localhost:4200", "*", "*")]
        [HttpPost]
        [ActionName("logout")]
        public LogInOutResponse LogOut(LogInOutRequest req)
        {
            return logInOutService.LogOut(req);
        }
    }
}
