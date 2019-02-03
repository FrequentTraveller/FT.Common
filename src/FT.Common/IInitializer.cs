using System.Threading.Tasks;

namespace FT.Common
{
    public interface IInitializer
    {
        Task InitializeAsync();
    }
}