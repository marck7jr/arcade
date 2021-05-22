#nullable disable

using Marck7JR.Arcade.Domain.Entities.Games;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marck7JR.Arcade.Infrastructure.Persistence.Data.Configuration.Games
{
    public class GameEntryConfiguration : IEntityTypeConfiguration<GameEntry>
    {
        public void Configure(EntityTypeBuilder<GameEntry> builder)
        {
            builder
                .HasOne(x => x.Game)
                .WithMany(x => x.Entries);

            builder
                .Property(x => x.Uri)
                .HasConversion<string>();
        }
    }
}
