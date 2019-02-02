using System.Threading.Tasks;

namespace DFF.Common
{
    public interface IInitializer
    {
        Task InitializeAsync();
    }
}