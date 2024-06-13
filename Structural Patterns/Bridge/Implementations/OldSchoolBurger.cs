using Structural_Patterns.Bridge.Contracts;

namespace Structural_Patterns.Bridge.Implementations
{
    public class OldSchoolBurger : Burger
    {
        public OldSchoolBurger(ICombo combo) : base(combo) { }
        public override void GetDetails()
        {
            Console.WriteLine($"Old School Beef Burger with {combo.GetCombo()}");
        }
    }
}
