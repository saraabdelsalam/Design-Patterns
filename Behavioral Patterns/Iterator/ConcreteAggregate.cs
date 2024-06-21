
namespace Behavioral_Patterns.Iterator
{
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private readonly List<T> _items = new List<T>();
        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(_items);
        }
        public void AddItem(T item)
        {
            _items.Add(item);
        }
        public T this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
        public int Count
        {
            get { return _items.Count; }
        }
    }
}
