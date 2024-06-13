using Structural_Patterns.Bridge.Contracts;

namespace Structural_Patterns.Bridge.Implementations
{
    public class ChickenBurger : Burger
    {
        public ChickenBurger(ICombo combo) : base(combo) { }
        public override void GetDetails()
        {
            Console.WriteLine($"Chicken Burger with {combo.GetCombo()}");
        }
    }
}
