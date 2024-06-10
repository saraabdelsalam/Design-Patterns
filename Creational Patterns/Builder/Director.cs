
namespace Creational_Patterns.Builder
{
    public class Director
    {
        IBuilder? _builder;
        public void Construct(IBuilder builder)
        {
            _builder = builder;
            _builder.SetBrand();
            _builder.AddRam();
            _builder.AddCpu();
            _builder.AddGraphicCard();
            _builder.EndOperations();

        }
    }
}
