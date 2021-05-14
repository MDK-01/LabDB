using System.Data.Entity;

namespace DBApp.Models
{
    public class GameContext : DbContext
    {
        public GameContext(): base("ConnectionString")
        {
        }

        public DbSet<Game> Games { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>();
        }
    }
}