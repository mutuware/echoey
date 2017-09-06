using System.Collections.Generic;
using System.Threading.Tasks;
using Echoey.Models;

namespace Echoey.Repositories
{
    public interface IRoutesRepository
    {
        Task<IEnumerable<EchoeyRoute>> GetAll();
        Task<EchoeyRoute> Get(int id);
        Task Add(EchoeyRoute route);
        Task<EchoeyRoute> Match(string url, string verb);
    }
}