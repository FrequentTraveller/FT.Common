using System.Threading.Tasks;
using FT.Common.Types;

namespace FT.Common.Dispatchers
{
    public interface IQueryDispatcher
    {
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}