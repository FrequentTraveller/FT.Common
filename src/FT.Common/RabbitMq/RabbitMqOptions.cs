using RawRabbit.Configuration;

namespace FT.Common.RabbitMq
{
    public class RabbitMqOptions : RawRabbitConfiguration
    {
        public string Namespace { get; set; }
    }
}