using Marck7JR.Arcade.Application.Interfaces.Repositories;
using Marck7JR.Arcade.Domain.Entities;
using Marck7JR.Arcade.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Marck7JR.Arcade.Infrastructure.Persistence.Repositories
{
    public abstract class Repository<TKey, TEntity> : IRepository<TKey, TEntity>
        where TKey : notnull
        where TEntity : class, IEntity<TKey>
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        protected DbSet<TEntity> Entities => _applicationDbContext.Set<TEntity>();

        public virtual async ValueTask<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            var entry = await Entities.AddAsync(entity, cancellationToken);
            return entry.Entity;
        }

        public virtual ValueTask<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            Entities.Remove(entity);
            return ValueTask.FromResult(entity);
        }

        public virtual async ValueTask<TEntity> GetAsync(TKey key, CancellationToken cancellationToken = default)
        {
            var entity = await Entities.FindAsync(new object[] { key }, cancellationToken: cancellationToken);
            return entity;
        }

        public virtual IAsyncEnumerable<TEntity> GetAsyncEnumerable(CancellationToken cancellationToken = default)
        {
            return Entities.AsAsyncEnumerable();
        }

        public virtual IAsyncQueryable<TEntity> GetAsyncQueryable(CancellationToken cancellationToken = default)
        {
            return Entities.AsAsyncQueryable();
        }

        public virtual ValueTask<TEntity> ReadAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            return ValueTask.FromResult(entity);
        }

        public virtual async ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var count = await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return count;
        }

        public virtual ValueTask<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            Entities.Update(entity);
            return ValueTask.FromResult(entity);
        }
    }
}
