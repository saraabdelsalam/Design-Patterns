

namespace Creational_Patterns.Singleton
{
    public class Counter
    {
        private static Counter instance;
        private static readonly object lockObject = new object();
        private int count = 0;

        private Counter() { }

        public static Counter GetInstance()
        {
            // Double-checked locking to ensure thread safety
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Counter();
                    }
                }
            }
            return instance;
        }

        public int Count => count;

        public void IncreaseCount()
        {
            lock (lockObject)
            {
                count++;
            }
        }
    }
}
