using RawRabbit.Configuration;

namespace DFF.Common.RabbitMq
{
    public class RabbitMqOptions : RawRabbitConfiguration
    {
        public string Namespace { get; set; }
    }
}