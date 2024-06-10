

namespace Creational_Patterns.Factory
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override IChair BuyChair()
        {
            return new ModernChair();
        }

        public override ISofa BuySofa()
        {
            return new ModernSofa();
        }
    }
}
