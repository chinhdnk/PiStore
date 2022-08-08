namespace WebAPI.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message=null)
        {
            StatusCode = statusCode;
            ErrorMessage = message ?? GetDefaultMessageStatusCode(statusCode);
        }
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }

        private string GetDefaultMessageStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401=> "Authorized, you are not",
                404=> "Resource not found, it was not",
                500=> "Error are the path to dark site",
                _ => null
            };
        }
    }
}
