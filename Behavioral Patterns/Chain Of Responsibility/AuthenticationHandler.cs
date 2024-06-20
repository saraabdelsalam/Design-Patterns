

namespace Behavioral_Patterns.Chain_Of_Responsibility
{
    public class AuthenticationHandler : AbstractHandler
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Authentication handler processing request");
            // Perform authentication logic
        }
    }
}
