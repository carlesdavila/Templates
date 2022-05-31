namespace ApplicationFramework.Application.Exceptions;

internal class ValidationException : ApplicationException
{
    internal ValidationException(string message, string code) : base(message, code)
    {
    }
}