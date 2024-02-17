using Footsal.Entites.Playesr;
using Footsal.Entites.Teams;
using Microsoft.EntityFrameworkCore;

namespace Footsal.Persistence;

public class EFDataContext : DbContext
{
    public  DbSet<Team> Teams { get; set; }
    public DbSet<Player> Players{ get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=KarimFootsal;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFDataContext).Assembly);
    } 
}