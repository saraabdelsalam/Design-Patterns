

namespace Creational_Patterns.Builder
{
    public class Product
    {
        private LinkedList<string> parts;

        public Product()
        {
            parts = new LinkedList<string>();
        }
        public void Add(string part)
        {
            parts.AddLast(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct completed as below :");
            foreach (string part in parts)
                Console.WriteLine(part);
            Console.WriteLine("\n");
        }
    }
}
