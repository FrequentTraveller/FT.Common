using FT.Common.RabbitMq;
using FT.Common.Messages;
using System.Threading.Tasks;

namespace FT.Common.Handlers
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command, ICorrelationContext context);
    }
}