
namespace Structural_Patterns.Decorator
{
    public class CoffeeDecorator : ICoffee
    {
        private readonly ICoffee _coffe;
        protected CoffeeDecorator(ICoffee coffe)
        {
            _coffe = coffe;
        }
        public virtual double GetCost()
        {
           return _coffe.GetCost();
        }

        public virtual string GetDescription()
        {
            return _coffe.GetDescription();
        }
    }
}
