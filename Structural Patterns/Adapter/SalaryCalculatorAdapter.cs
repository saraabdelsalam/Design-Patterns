

namespace Structural_Patterns.Adapter
{
    public class SalaryCalculatorAdapter : SalaryCalculator
    {
        private Employee _employee;
        public double CalculateSalary(MachineOperator _operator)
        {
            _employee = new Employee();
            _employee.Salary = _operator.Salary;
            return base.CalcSalary(_employee);
        }
    }
}
