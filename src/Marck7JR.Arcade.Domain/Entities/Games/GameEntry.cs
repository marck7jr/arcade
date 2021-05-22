using System;

namespace Marck7JR.Arcade.Domain.Entities.Games
{
    public class GameEntry : Entity<Guid>
    {
        public string? Arguments { get; set; }
        public string? ExternalId { get; set; }
        public Game? Game { get; set; }
        public Guid GameId { get; set; }
        public GameIssuer? Issuer { get; set; }
        public Guid IssuerId { get; set; }
        public bool IsInstalled { get; set; }
        public Uri? Uri { get; set; }
    }
}