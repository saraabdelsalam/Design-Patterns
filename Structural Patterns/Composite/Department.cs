
namespace Structural_Patterns.Composite
{
    public class Department : IEmployee
    {
        private List<IEmployee> _employees = new List<IEmployee>();

        public void AddEmployee(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            _employees.Remove(employee);
        }

        public void ShowDetails()
        {
            foreach (var employee in _employees)
            {
                employee.ShowDetails();
            }
        }
    }
}
