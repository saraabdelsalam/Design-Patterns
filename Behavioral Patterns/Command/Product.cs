

namespace Behavioral_Patterns.Command
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int StockBalance { get; set; }

        public Product(int id, string name, double unitPrice, int stockBalance)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            StockBalance = stockBalance;
        }
        public void AddStock(int quantity)
        {
            StockBalance += quantity;
            Console.WriteLine($"Product {Name} Stock Balance Changed To {StockBalance}");
        }
    }
}
