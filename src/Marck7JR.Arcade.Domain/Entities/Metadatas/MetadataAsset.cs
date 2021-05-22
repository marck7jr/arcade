using System;

namespace Marck7JR.Arcade.Domain.Entities.Metadatas
{
    public enum MetadataAssetKind
    {
        Artwork,
        Cover,
        Screenshot,
        Video,
    }

    public enum MetadataAssetOrientation
    {
        Landscape,
        Portrait,
    }

    public class MetadataAsset : Entity<Guid>
    {
        public MetadataAssetKind Kind { get; set; }
        public Metadata? Metadata { get; set; }
        public Guid MetadataId { get; set; }
        public MetadataAssetOrientation Orientation { get; set; }
        public Uri? Uri { get; set; }
    }
}
