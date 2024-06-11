

namespace Structural_Patterns.Proxy.SmsProxy
{
    public class ConcreteSmsService : SmsService
    {
        public override string SendSms(string userId, string phoneNumber, string message)
        {
            return $"CustomerId {userId}, sms sent to {phoneNumber}";
        }
    }
}
