

namespace Structural_Patterns.Composite
{
    public class Employee : IEmployee
    {
        private string _name { get; set; }
        private string _position { get; set; }
        public Employee(string name, string position)
        {
            _name = name;
            _position = position;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{_name} works as {_position}");
        }
    }
}
