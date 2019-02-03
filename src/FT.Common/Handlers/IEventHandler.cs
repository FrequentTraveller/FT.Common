using FT.Common.RabbitMq;
using FT.Common.Messages;
using System.Threading.Tasks;

namespace FT.Common.Handlers
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event, ICorrelationContext context);
    }
}