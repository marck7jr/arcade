using System;

namespace Marck7JR.Arcade.Domain.Entities
{
    public interface IEntity<TKey>
        where TKey : notnull
    {
        public TKey? Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
