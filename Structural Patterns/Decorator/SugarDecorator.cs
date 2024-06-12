
namespace Structural_Patterns.Decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffe) : base(coffe)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " With Suger ";
        }
        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }

    }
}
