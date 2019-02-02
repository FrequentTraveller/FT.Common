using DFF.Common.RabbitMq;
using DFF.Common.Messages;
using System.Threading.Tasks;

namespace DFF.Common.Handlers
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command, ICorrelationContext context);
    }
}