using Echoey.Models;
using Microsoft.EntityFrameworkCore;

namespace Echoey.Contexts
{
    public class RoutesContext : DbContext
    {
        public RoutesContext(DbContextOptions<RoutesContext> options)
            : base(options) { }

        public DbSet<EchoeyRoute> Routes { get; set; }


    }
}
