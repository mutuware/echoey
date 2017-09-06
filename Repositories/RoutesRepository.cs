using System.Collections.Generic;
using System.Threading.Tasks;
using Echoey.Contexts;
using Echoey.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Echoey.Repositories
{
    public class RoutesRepository : IRoutesRepository
    {
        RoutesContext _context;
        public RoutesRepository(RoutesContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EchoeyRoute>> GetAll()
        {
            return await _context.Routes.ToListAsync();
        }

        public async Task<EchoeyRoute> Get(int id)
        {
            return await _context.Routes.Where(x => x.Id == id).SingleOrDefaultAsync();
        }

        public async Task Add(EchoeyRoute route)
        {
            await _context.AddAsync(route);
            await _context.SaveChangesAsync();
        }

        public async Task<EchoeyRoute> Match(string url, string verb)
        {
            return await _context.Routes.Where(x => x.Url == url && x.Verb == verb).SingleOrDefaultAsync();
        }

    }
}
