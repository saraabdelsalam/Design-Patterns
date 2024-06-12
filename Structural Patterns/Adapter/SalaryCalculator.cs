

namespace Structural_Patterns.Adapter
{
    public class SalaryCalculator
    {
        public double CalcSalary(Employee emp) => emp.Salary * 1.5;
    }
}
