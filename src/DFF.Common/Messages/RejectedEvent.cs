using Newtonsoft.Json;

namespace DFF.Common.Messages
{
    public class RejectedEvent : IRejectedEvent
    {
        public string Reason { get; }

        public string Code { get; }

        [JsonConstructor]
        public RejectedEvent(string reason, string code)
        {
            Reason = reason;
            Code = code;
        }
    }
}
