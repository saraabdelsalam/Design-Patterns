

namespace Behavioral_Patterns.Command.Commands
{
    public class AddStockCommand : ICommand
    {
        private readonly Product _product;
        private readonly int _quantity;
        public AddStockCommand(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public void Execute()
        {
            _product.AddStock(_quantity);
        }
    }
}
