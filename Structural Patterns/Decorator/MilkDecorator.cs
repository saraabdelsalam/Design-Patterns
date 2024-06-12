

namespace Structural_Patterns.Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffe) : base(coffe)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription()+ " With Milk ";
        }
        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }
    }
}
