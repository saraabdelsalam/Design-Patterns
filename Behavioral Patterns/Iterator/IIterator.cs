
namespace Behavioral_Patterns.Iterator
{
    public interface IIterator<T>
    {
        T Next();
        T First();
        T CurrentItem();
        bool IsDone();

    }
}
