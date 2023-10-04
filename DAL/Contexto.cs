using Microsoft.EntityFrameworkCore;


public class Contexto : DbContext
    {
        public DbSet<Aportes> aportes { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }

