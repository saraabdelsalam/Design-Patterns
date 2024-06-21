
namespace Behavioral_Patterns.Iterator
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
