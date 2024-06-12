

namespace Structural_Patterns.Decorator
{
    public class CaramelFlavorDecorator : CoffeeDecorator
    {
        public CaramelFlavorDecorator(ICoffee coffe) : base(coffe)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " With Caramel";
        }
        public override double GetCost()
        {
            return base.GetCost() + 1;
        }
    }
}
