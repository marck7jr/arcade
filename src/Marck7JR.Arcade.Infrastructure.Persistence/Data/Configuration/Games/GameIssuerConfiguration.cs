#nullable disable

using Marck7JR.Arcade.Domain.Entities.Games;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marck7JR.Arcade.Infrastructure.Persistence.Data.Configuration.Games
{
    public class GameIssuerConfiguration : IEntityTypeConfiguration<GameIssuer>
    {
        public void Configure(EntityTypeBuilder<GameIssuer> builder)
        {
            builder
                .HasMany(x => x.GameEntries)
                .WithOne(x => x.Issuer);
        }
    }
}
