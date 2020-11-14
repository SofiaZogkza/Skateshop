namespace SkateshopApi.Contracts
{
    public class LogInOutResponse
    {
        public LogInOutResponse(bool success, string errorMessage)
        {
            Success = success;
            ErrorMessage = errorMessage;
        }

        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
