namespace ApplicationFramework.Application.Exceptions;

public class ApplicationException : Exception
{
    protected ApplicationException(string businessMessage, string code) : base(businessMessage)
    {
        Code = code;
    }
    public string? Code { get; }
    
}