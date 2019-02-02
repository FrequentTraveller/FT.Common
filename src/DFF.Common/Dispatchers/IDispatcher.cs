using System.Threading.Tasks;
using DFF.Common.Types;
using DFF.Common.Messages;

namespace DFF.Common.Dispatchers
{
    public interface IDispatcher
    {
        Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}