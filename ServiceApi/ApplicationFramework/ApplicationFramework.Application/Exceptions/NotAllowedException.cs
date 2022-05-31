namespace ApplicationFramework.Application.Exceptions;

public class NotAllowedException : ApplicationException
{
    protected NotAllowedException(string businessMessage, string code = "NotAllowedException") : base(businessMessage, code)
    {
    }
}