using Marck7JR.Arcade.Domain.Entities.Issuers;
using System;
using System.Collections.Generic;

namespace Marck7JR.Arcade.Domain.Entities.Games
{
    public class Game : Entity<Guid>
    {
        public Issuer? Issuer { get; set; }
        public Guid IssuerId { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<GameEntry>? Entries { get; set; }
    }
}
