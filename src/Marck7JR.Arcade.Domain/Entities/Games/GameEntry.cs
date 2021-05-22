using Marck7JR.Arcade.Domain.Entities.Issuers;
using System;

namespace Marck7JR.Arcade.Domain.Entities.Games
{
    public class GameEntry : Entity<Guid>
    {
        public string? Arguments { get; set; }
        public Uri? ExecutablePath { get; set; }
        public string? ExternalId { get; set; }
        public Game? Game { get; set; }
        public Guid GameId { get; set; }
        public Issuer? Issuer { get; set; }
        public Guid IssuerId { get; set; }
        public bool IsInstalled { get; set; }
    }
}