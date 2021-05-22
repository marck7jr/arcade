using Marck7JR.Arcade.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Marck7JR.Arcade.Application.Interfaces.Repositories
{
    public interface IRepository<TKey, TEntity>
        where TKey : notnull
        where TEntity : IEntity<Guid>
    {
        public ValueTask<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        public ValueTask<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
        public ValueTask<TEntity> GetAsync(TKey key, CancellationToken cancellationToken = default);
        public ValueTask<TEntity> ReadAsync(TEntity entity, CancellationToken cancellationToken = default);
        public ValueTask<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
