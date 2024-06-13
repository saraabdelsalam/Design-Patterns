using Structural_Patterns.Bridge.Contracts;

namespace Structural_Patterns.Bridge.Implementations
{
    public class VegatablesAndJuice : ICombo
    {
        public string GetCombo()
        {
            return "Vegatables & Juice Combo";
        }
    }
}
