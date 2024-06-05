namespace PropertyExplorerAPI.Wrapper
{
    public class ErrorDetails
    {
        public string ErrorMessage { get; set; }
        public string ErrorCode { get; set; }

        public ErrorDetails(string errorMessage, string errorCode)
        {
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
        }
    }
}
