using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Marck7JR.Arcade.Infrastructure.Persistence.Data.Design
{
    public class DesignTimeApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            SqliteConnectionStringBuilder stringBuilder = new()
            {
                DataSource = typeof(DesignTimeApplicationDbContextFactory).Assembly.GetName().Name
            };

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite(stringBuilder.ConnectionString);

            return new(optionsBuilder.Options);
        }
    }
}
