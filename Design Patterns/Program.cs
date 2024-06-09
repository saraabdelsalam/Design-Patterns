using Creational_Patterns.Singleton;
using System.Runtime;
using System;
using Creational_Patterns.Prototype;

namespace Design_Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Creational Patterns
            #region singleton
            Task task1 = Task.Factory.StartNew(() =>
            {
                Counter counter1 = Counter.GetInstance();
                counter1.IncreaseCount();
                Console.WriteLine("counter 1 :" + counter1.Count.ToString());
            });

            Task task2 = Task.Factory.StartNew(() =>
            {
                Counter counter2 = Counter.GetInstance();
                counter2.IncreaseCount();
                Console.WriteLine("counter 2 :" + counter2.Count.ToString());
             
            });
            Task.WaitAll(task1, task2); // Wait for both tasks to complete before exiting

            Console.WriteLine("Tasks completed.");
            #endregion

            #region Prototype
            HrEmployee emp1 = new HrEmployee
            {
                Id = 42,
                Name = "Jack Daniels",
                Address = new Address("11", "Wall Street", "New York", "USA")
            };

            EmployeePrototype emp2 = emp1.ShallowCopy();
            EmployeePrototype emp3 = emp1.DeepCopy();


            Console.WriteLine("Original values of emp1, emp2, emp3:");
            Console.WriteLine($"emp1 instance values:{emp1.ToString()} ");
       
            Console.WriteLine($"emp2 instance values:{emp2.ToString()}");
         
            Console.WriteLine($"emp3 instance values:{emp3.ToString()}");

            emp1.Address.Building = "8";
            emp1.Address.Street = "Brooklyn";
            emp1.Address.City = "Brooklyn City";
            emp1.Address.Country = "USA";
            Console.WriteLine("\nValues of emp1, emp2 and emp3 after changes to emp1:");
            Console.WriteLine($"emp1 instance values:{emp1.ToString()} ");
            Console.WriteLine($"emp2 instance values (reference values have changed):{emp2.ToString()}");  
            Console.WriteLine($"emp3 instance values (everything was kept the same): {emp3.ToString()}");

            emp2.Address.City = "San Francisco";

            Console.WriteLine("\nValues of emp1, emp2, and emp3 after changes to emp2:");
            Console.WriteLine($"emp1 instance values (changes should reflect in emp2):{emp1.ToString()}");
            Console.WriteLine($"emp2 instance values:{emp2.ToString()}");
            Console.WriteLine($"emp3 instance values (no changes should reflect): {emp3.ToString()}");

            #endregion
            #endregion

            #region Structural Patterns
            #endregion

            #region Behavioral Patterns
            #endregion
        }
    }
}
