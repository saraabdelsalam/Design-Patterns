

namespace Behavioral_Patterns.Chain_Of_Responsibility
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual void Handle(Request request)
        {
            ProcessRequest(request);
            if (this._nextHandler is not null)
            {
               this._nextHandler.Handle(request);
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
        protected abstract void ProcessRequest(Request request);
    }
}
