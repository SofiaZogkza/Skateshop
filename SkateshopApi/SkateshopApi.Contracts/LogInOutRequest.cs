using System.Collections.Generic;

namespace SkateshopApi.Contracts
{
    public class LogInOutRequest
    {
        public LogInOutRequest(string userName, string password, bool logInIndicator )
        {
            UserName = userName;
            Password = password;
            LogInIndicator = logInIndicator;
        }


        public string UserName { get; set; }
        public string Password { get; set; }
        public bool LogInIndicator { get; set; } // 1 Logged in, 2 Logged Out
    }

    public static class ListOfLoggedInUsers
    {
        public static List<LogInOutRequest> RegisteredUsers { get; set; } = new List<LogInOutRequest>
        {
            new LogInOutRequest("Sofia_zogkza@gmail.com", "Zogkza" , false),
            new LogInOutRequest("maria_zogkza@gmail.com", "123456" , false),
            new LogInOutRequest("george_zogkza@gmail.com", "65432" , false)
        };
    }
}
