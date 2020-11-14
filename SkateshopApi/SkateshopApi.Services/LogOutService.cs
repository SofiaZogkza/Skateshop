using SkateshopApi.Contracts;
using SkateshopApi.Interfaces;

namespace SkateshopApi.Services
{
    public class LogOutService : ILogInOutService
    {

        //Log out

        // Change Indicator

        public LogInOutResponse LogOut(LogInOutRequest req)
        {
            if (req.LogInIndicator == true) // an ine LoggedIn
            {
                // The user exists
                req.LogInIndicator = false; // Indicator set to false = LoggedOut
                return new LogInOutResponse(true, null);
            }
            else
            {
                return new LogInOutResponse(false, "Already Logged Out");
            }
        }
    }
}
