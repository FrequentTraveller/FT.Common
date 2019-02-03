using System.Threading.Tasks;
using FT.Common.Types;
using FT.Common.Messages;

namespace FT.Common.Dispatchers
{
    public interface IDispatcher
    {
        Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}