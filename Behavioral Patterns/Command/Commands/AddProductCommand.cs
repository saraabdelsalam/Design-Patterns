
namespace Behavioral_Patterns.Command.Commands
{
    public class AddProductCommand : ICommand
    {
        private readonly Order _order;
        private readonly Product _product;
        private readonly int _quantity;
        public AddProductCommand(Order order, Product product, int quantity)
        {
            _order = order;
            _product = product;
            _quantity = quantity;
        }

        public void Execute()
        {
            _order.AddProduct(_product, _quantity); 
        }
    }
}
