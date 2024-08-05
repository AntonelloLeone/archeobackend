namespace WebApplication1.exceptions
{
    public class NotFoundException: Exception
    {
        public NotFoundException(string message) : base(message) { }
    }
}
