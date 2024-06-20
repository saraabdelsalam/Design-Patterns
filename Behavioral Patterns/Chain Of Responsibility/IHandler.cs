

namespace Behavioral_Patterns.Chain_Of_Responsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(Request request);
    }
}
