namespace design_patterns.ChainOfResponsibility
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
                return _nextHandler.Handle(request);
            else
                return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }
    }
}