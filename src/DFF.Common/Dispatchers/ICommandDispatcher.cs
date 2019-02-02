using System.Threading.Tasks;
using DFF.Common.Messages;

namespace DFF.Common.Dispatchers
{
    public interface ICommandDispatcher
    {
        Task SendAsync<T>(T command) where T : ICommand;
    }
}