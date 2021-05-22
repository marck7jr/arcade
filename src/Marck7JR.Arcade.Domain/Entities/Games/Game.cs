using System;
using System.Collections.Generic;

namespace Marck7JR.Arcade.Domain.Entities.Games
{
    public class Game : Entity<Guid>
    {
        public virtual ICollection<GameEntry>? Entries { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<GameMetadata>? Metadatas { get; set; }
    }
}
