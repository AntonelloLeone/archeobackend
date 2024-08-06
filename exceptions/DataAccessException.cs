namespace WebApplication1.exceptions
{
    public class DataAccessException: Exception
    {
        public DataAccessException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
