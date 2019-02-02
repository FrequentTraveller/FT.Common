using System.Threading.Tasks;
using DFF.Common.Types;

namespace DFF.Common.Dispatchers
{
    public interface IQueryDispatcher
    {
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}