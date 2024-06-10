

namespace Creational_Patterns.Builder
{
    public interface IBuilder
    {
        void SetBrand();
        void AddRam();
        void AddCpu();
        void AddGraphicCard();
        void EndOperations();
        Product GetComputer();
    }
}
