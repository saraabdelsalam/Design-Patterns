

namespace Behavioral_Patterns.Chain_Of_Responsibility
{
    public class AuthorizationHandler : AbstractHandler
    {
        protected override void ProcessRequest(Request request)
        {

            Console.WriteLine("Authorization handler processing request");
            // Perform authorization logic
        }
    }
}
