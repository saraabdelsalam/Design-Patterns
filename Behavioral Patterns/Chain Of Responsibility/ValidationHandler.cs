

namespace Behavioral_Patterns.Chain_Of_Responsibility
{
    public class ValidationHandler : AbstractHandler
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Validation handler processing request");
            // Perform validation logic
        }
    }
}
