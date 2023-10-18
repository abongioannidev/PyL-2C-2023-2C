namespace Entidades
{
    public class NumeroInvalidoException : Exception
    {
        public NumeroInvalidoException(string? message) : base(message)
        {
        }

        public NumeroInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}