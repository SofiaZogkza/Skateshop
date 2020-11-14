using SkateshopApi.Contracts;
using SkateshopApi.Interfaces;

namespace SkateshopApi.Services
{
    public class LogInOutService : ILogInOutService
    {
        // Validate me ti Registered List if the user is inside the list
        //                                if the user has indicator truye or false.
        // Change Indicator

        /* Return Messages:
         * 1. Wrong Username/password
         * 2. Already LoggedIn 
         * 3. Logout Error 
         * 
         * 
         */

        public LogInOutResponse LogIn(LogInOutRequest req)
        {
            if (req.LogInIndicator != true) // an den ine LoggedIn
            {
                //Search within the registered Users
                foreach (var loggedInUsers in ListOfLoggedInUsers.RegisteredUsers)
                {
                    if(loggedInUsers.UserName == req.UserName &&
                       loggedInUsers.Password == req.Password)
                    {
                        // The user exists
                        req.LogInIndicator = true; // Indicator set to true = LoggedIn
                        return new LogInOutResponse(true, null);
                    }
                }
                return new LogInOutResponse(false, "Wrong Username/Password");
            }
            else
            {
                return new LogInOutResponse(false, "Already Logged In");
            }
        }

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
