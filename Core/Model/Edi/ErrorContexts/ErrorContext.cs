namespace EdiFabric.Core.Model.Edi.ErrorContexts
{
    public abstract class ErrorContext
    {
        protected string Message { get; private set; }

        protected ErrorContext(string message)
        {
            Message = message;
        }
    }
}
