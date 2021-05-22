using System;

namespace Marck7JR.Arcade.Domain.Entities.Metadatas
{
    public class MetadataCompany : Entity<Guid>
    {
        public string? Name { get; set; }
    }
}