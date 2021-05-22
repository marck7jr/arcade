using System;

namespace Marck7JR.Arcade.Domain.Entities.Games
{
    public enum GameMetadataProvider
    {
        IGDB
    }

    public class GameMetadata : Entity<Guid>
    {
        public string? ExternalId { get; set; }
        public Game? Game { get; set; }
        public Guid? GameId { get; set; }
        public GameMetadataProvider Provider { get; set; }
        public byte[]? RawData { get; set; }
    }
}
