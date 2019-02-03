using System.Threading.Tasks;
using FT.Common.Messages;

namespace FT.Common.Dispatchers
{
    public interface ICommandDispatcher
    {
        Task SendAsync<T>(T command) where T : ICommand;
    }
}