

namespace Creational_Patterns.Factory
{
    public class Client
    {
        private IChair chair;
        private ISofa sofa;
        public Client(FurnitureFactory factory)
        {
            chair = factory.BuyChair();
            sofa = factory.BuySofa();
        }
        public void UseFurniture()
        {
            chair.Chair();
            sofa.Sofa();
        }
    }
}
