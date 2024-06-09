using Creational_Patterns.Singleton;

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
            #endregion

            #region Structural Patterns
            #endregion

            #region Behavioral Patterns
            #endregion
        }
    }
}
