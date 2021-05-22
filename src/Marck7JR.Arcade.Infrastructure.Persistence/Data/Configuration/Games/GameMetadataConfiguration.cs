#nullable disable

using Marck7JR.Arcade.Domain.Entities.Games;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marck7JR.Arcade.Infrastructure.Persistence.Data.Configuration.Games
{
    public class GameMetadataConfiguration : IEntityTypeConfiguration<GameMetadata>
    {
        public void Configure(EntityTypeBuilder<GameMetadata> builder)
        {
            builder
                .HasOne(x => x.Game)
                .WithMany(x => x.Metadatas);
        }
    }
}
