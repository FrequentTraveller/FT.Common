using System.Collections.Generic;
using System.Threading.Tasks;
using Consul;

namespace FT.Common.Consul
{
    public interface IConsulServicesRegistry
    {
        Task<AgentService> GetAsync(string name);
    }
}