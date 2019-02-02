using DFF.Common.RabbitMq;
using DFF.Common.Messages;
using System.Threading.Tasks;

namespace DFF.Common.Handlers
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event, ICorrelationContext context);
    }
}