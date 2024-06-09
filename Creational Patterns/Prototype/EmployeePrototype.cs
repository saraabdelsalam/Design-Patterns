
namespace Creational_Patterns.Prototype
{
    public abstract class EmployeePrototype
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Address Address { get; set; }
        public abstract EmployeePrototype ShallowCopy();
        public abstract EmployeePrototype DeepCopy();

        public override string ToString()
        {
            return
            $@"
               Id: {this.Id}
               Name: {this.Name}
               Address: {this.Address.Building},{this.Address.Street},{this.Address.City},{this.Address.Country}";
        }
    }
}
