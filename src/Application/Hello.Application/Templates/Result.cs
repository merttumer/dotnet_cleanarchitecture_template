namespace Hello.Application.Templates
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public List<string> Errors { get; set; } = new();

        public static Result<T> Ok(T? data)
        {
            return new Result<T>
            {
                Success = true,
                Data = data
            };
        }

        public static Result<T> Fail(List<string> errors)
        {
            return new Result<T>
            {
                Success = false,
                Errors = errors,
            };
        }
    }
}