using System;
using System.Collections.Generic;

namespace Marck7JR.Arcade.Domain.Entities.Metadatas
{
    public class MetadataGenre : Entity<Guid>
    {
        public string? Name { get; set; }
        public virtual ICollection<Metadata>? Metadatas { get; set; }
    }
}
