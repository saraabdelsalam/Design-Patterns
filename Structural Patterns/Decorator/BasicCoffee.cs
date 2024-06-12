
namespace Structural_Patterns.Decorator
{
    public class BasicCoffee : ICoffee
    {
        public double GetCost()
        {
            return 20.0;
        }

        public string GetDescription()
        {
            return "Espresso Coffe";
        }
    }
}
