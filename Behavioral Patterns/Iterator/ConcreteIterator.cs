

namespace Behavioral_Patterns.Iterator
{
    public class ConcreteIterator<T> : IIterator<T>
    {
        private readonly List<T> _collection;
        private int _currentIndex = 0;
        public ConcreteIterator(List<T> collection)
        {
            _collection = collection;
        }
        public T CurrentItem()
        {
            if (!IsDone())
            {
                return _collection[_currentIndex];
            }
            else
            {
                return default(T);
            }
        }

        public T First()
        {
            _currentIndex = 0;
            return _collection[_currentIndex];
        }

        public bool IsDone()
        {
            return _currentIndex >= _collection.Count;
        }

        public T Next()
        {
            _currentIndex++;
            if (!IsDone())
            {
                return _collection[_currentIndex];
            }
            else
            {
                return default(T);
            }
        }
    }
}
