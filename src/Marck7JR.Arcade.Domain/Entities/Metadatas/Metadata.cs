using Marck7JR.Arcade.Domain.Entities.Issuers;
using System;
using System.Collections.Generic;

namespace Marck7JR.Arcade.Domain.Entities.Metadatas
{
    public class Metadata : Entity<Guid>
    {
        public virtual ICollection<MetadataAsset>? Assets { get; set; }
        public virtual ICollection<MetadataCompany>? Companies { get; set; }
        public MetadataAsset? Cover { get; set; }
        public Guid CoverId { get; set; }
        public string? Description { get; set; }
        public MetadataCompany? DevelopedBy { get; set; }
        public Guid DevelopedById { get; set; }
        public string? ExternalId { get; set; }
        public virtual ICollection<MetadataGenre>? Genres { get; set; }
        public Issuer? Issuer { get; set; }
        public Guid IssuerId { get; set; }
        public string? Name { get; set; }
        public double? Rating { get; set; }
        public MetadataCompany? PublishedBy { get; set; }
        public Guid PublishedById { get; set; }
        public DateTime ReleasedAt { get; set; }
        public string? Summary { get; set; }
        public virtual ICollection<MetadataTag>? Tags { get; set; }
    }
}
