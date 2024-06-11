

namespace Structural_Patterns.Proxy.SmsProxy
{
    public class SmsServiceProxy
    {
        private SmsService SmsService;
        private Dictionary<string,int> ConsumedSms = new Dictionary<string,int>();
        public string SendSms(string userId, string phoneNumber, string message)
        {
            if(SmsService is null)
            {
                SmsService = new ConcreteSmsService();
            }
            if(!ConsumedSms.ContainsKey(userId))
            {
                ConsumedSms.Add(userId, 1);
                return SmsService.SendSms(userId, phoneNumber, message);
            }
            else
            {
                var user = ConsumedSms.Where(x => x.Key == userId).FirstOrDefault();
                if (user.Value >= 3)
                {
                    return "You Have Exceeded The number of available sms to be sent";
                }
                else
                {
                    ConsumedSms[userId] = user.Value+1;
                    return SmsService.SendSms(userId,phoneNumber, message);
                }
            }
        }
    }
}
