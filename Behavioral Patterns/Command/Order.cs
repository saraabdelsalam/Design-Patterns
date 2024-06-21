

namespace Behavioral_Patterns.Command
{
    // Receiver
    public class Order
    {
        public int Id { get; } = Random.Shared.Next(1, 1000);

        private List<OrderLine> _lines = new();
        public IEnumerable<OrderLine> Lines => _lines.AsReadOnly();

        public void AddProduct(Product product, int quantity)
        {
            _lines.Add(new OrderLine { Id = product.Id, UnitPrice = product.UnitPrice, Quantity = quantity });
            Console.WriteLine($"Product {product.Name} added, Order now contains {_lines.Count} products");
        }
    }
}
