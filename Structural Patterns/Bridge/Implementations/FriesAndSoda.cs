using Structural_Patterns.Bridge.Contracts;

namespace Structural_Patterns.Bridge.Implementations
{
    public class Fries_Soda : ICombo
    {
        public string GetCombo()
        {
            return "Fries & Soda Combo";
        }
    }
}
