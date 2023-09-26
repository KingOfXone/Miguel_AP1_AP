using Microsoft.EntityFrameworkCore;

namespace Miguel_AP1_AP.DAL
{
public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
