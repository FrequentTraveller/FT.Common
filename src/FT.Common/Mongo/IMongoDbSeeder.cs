using System.Threading.Tasks;

namespace FT.Common.Mongo
{
    public interface IMongoDbSeeder
    {
        Task SeedAsync();
    }
}