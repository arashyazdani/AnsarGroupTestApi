namespace Api.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "AnsarGroupErrorMessage: You have made a bad request.",
                401 => "AnsarGroupErrorMessage: You are not authorized.",
                404 => "AnsarGroupErrorMessage: It was not resource found.",
                500 => "AnsarGroupErrorMessage: Internal server error.",
                _ => null
            };
        }
    }
}