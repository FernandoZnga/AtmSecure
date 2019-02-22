using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AtmApp.Domain;

namespace AtmApp.Data
{
    public class AtmContext : DbContext
    {
        public ILoggerFactory MyLoggerFactory { get; private set; }
/*
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>()
                .HasKey(s => new { s.BattleId, s.SamuraiId });

            //modelBuilder.Entity<Samurai>()
            //    .Property(s => s.SecretIdentity).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
*/
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=AtmData;Trusted_Connection=True;");
        
    }
}
