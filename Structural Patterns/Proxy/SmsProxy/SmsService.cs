
namespace Structural_Patterns.Proxy.SmsProxy
{
    public abstract class SmsService
    {
        public abstract string SendSms(string userId, string phoneNumber, string message);
    }
}
