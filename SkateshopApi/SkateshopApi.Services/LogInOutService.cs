using SkateshopApi.Contracts;
using SkateshopApi.Interfaces;
using System;
using System.Threading.Tasks;

namespace SkateshopApi.Services
{
    public class LogInOutService : ILogInOutService
    {
        // Validate with Registered List if the user is inside the list
        //                               if the user has indicator truye or false.
        // Change Indicator

        /* Return Messages:
         * 1. Wrong Username/password
         * 2. Already LoggedIn 
         * 3. Logout Error 
         * 
         * 
         */

        public async Task<LogInOutResponse> LogIn(LogInOutRequest req)
        {
            
            if (req.LogInIndicator != true) // If user is not LoggedIn
            {
                var response = await SearchIfUserIsRegistered(req);
                
                return response;
            }
            else
            {
                return new LogInOutResponse(false, "Already Logged In");
            }
        }

        public async Task<LogInOutResponse> LogOut(LogInOutRequest req)
        {
            Task.Delay(3).Wait();
            if (req.LogInIndicator == true) // If user is LoggedIn
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

        private static async Task<LogInOutResponse> SearchIfUserIsRegistered(LogInOutRequest req)
        {
            //Search within the registered Users
            foreach (var loggedInUsers in ListOfLoggedInUsers.RegisteredUsers)
            {
                if (loggedInUsers.UserName == req.UserName &&
                   loggedInUsers.Password == req.Password)
                {
                    // The user exists
                    req.LogInIndicator = true; // Indicator set to true = LoggedIn
                    return new LogInOutResponse(true, null);
                }
            }
            return new LogInOutResponse(false, "Wrong Username/Password");
        }

    }
}
