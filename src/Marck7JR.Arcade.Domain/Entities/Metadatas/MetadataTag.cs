using System;

namespace Marck7JR.Arcade.Domain.Entities.Metadatas
{
    public class MetadataTag : Entity<Guid>
    {
        public string? Name { get; set; }
    }
}