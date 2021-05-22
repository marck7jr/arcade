using Marck7JR.Arcade.Domain.Entities.Games;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Marck7JR.Arcade.Infrastructure.Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNull] DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Game>? Games { get; set; }
        public DbSet<GameEntry>? GameEntries { get; set; }
        public DbSet<GameIssuer>? GameIssuers { get; set; }
        public DbSet<GameMetadata>? GameMetadatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
