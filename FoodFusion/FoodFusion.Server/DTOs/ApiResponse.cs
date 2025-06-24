namespace FoodFusion.Server.DTOs
{
    // Standardized API response structure.
    // T represents then Type of the response data
    public class ApiResponse<T>
    {
        // HTTP status code of the response.
        public int StatusCode { get; set; }

        // Indicates whether the request was successful.
        public bool IsSuccess { get; set; }

        // Response data in case successful
        public T Data { get; set; }

        // List of error messages, if any.
        public List<string> Errors { get; set; }

        public ApiResponse() 
        {
            IsSuccess = true;
            Errors = new List<string>();
        }

        public ApiResponse(int statusCode, T data)
        {
            StatusCode = statusCode;
            IsSuccess = true;
            Data = data;
            Errors = new List<string>();
        }

        public ApiResponse(int statusCode, List<string> errors)
        {
            StatusCode = statusCode;
            IsSuccess = false;
            Errors = errors;
        }

        public ApiResponse(int statusCode, string error)
        {
            StatusCode = statusCode;
            IsSuccess = false;
            Errors = new List<string> { error };
        }
    }
}
