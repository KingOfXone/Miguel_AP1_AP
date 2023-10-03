using Microsoft.EntityFrameworkCore;
using Miguel_AP1_AP.Models;

namespace Miguel_AP1_AP.DAL
{
public class Contexto : DbContext
    {
        public DbSet<Aportes> aportes { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
