

namespace Creational_Patterns.Prototype
{
    public class HrEmployee : EmployeePrototype
    {
        public override EmployeePrototype DeepCopy()
        {

            HrEmployee Hr = new HrEmployee();
            Hr = (HrEmployee)this.MemberwiseClone();
            Hr.Address = new Address(Hr.Address.Building, Hr.Address.Street, Hr.Address.City, Hr.Address.Country);
            Hr.Name = this.Name;
            return Hr;
        }

        public override EmployeePrototype ShallowCopy()
        {
            return (HrEmployee) this.MemberwiseClone();
        }
    }
}
