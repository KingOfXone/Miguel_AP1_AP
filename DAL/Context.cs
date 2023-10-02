
using Microsoft.EntityFrameworkCore;
using Miguel_AP1_AP.BLL;
namespace Miguel_AP1_AP.DAL
{
public class Contexto : DbContext
    {
        public DbSet<AportesBll> aportes { get; set; } 
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
