using System;
using System.Collections.Generic;

namespace Marck7JR.Arcade.Domain.Entities.Games
{
    public class GameIssuer : Entity<Guid>
    {
        public string? Name { get; set; }
        public virtual ICollection<GameEntry>? GameEntries { get; set; }
    }
}
