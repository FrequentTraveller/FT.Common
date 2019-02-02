using System.Threading.Tasks;

namespace DFF.Common.Mongo
{
    public interface IMongoDbSeeder
    {
        Task SeedAsync();
    }
}