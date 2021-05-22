#nullable disable

using Marck7JR.Arcade.Domain.Entities.Games;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marck7JR.Arcade.Infrastructure.Persistence.Data.Configuration.Games
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder
                .HasMany(x => x.Entries)
                .WithOne(x => x.Game);

            builder
                .HasMany(x => x.Metadatas)
                .WithOne(x => x.Game);
        }
    }
}
