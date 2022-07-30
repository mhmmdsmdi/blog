using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Blog.Repository;

public interface IRepository<TEntity> where TEntity : class
{
    DbSet<TEntity> Entities { get; }
    IQueryable<TEntity> Table { get; }
    IQueryable<TEntity> TableNoTracking { get; }

    Task<IDbContextTransaction> CreateTransactionAsync();

    void Add(TEntity entity, bool saveNow = true);

    Task SaveChangesAsync(CancellationToken cancellationToken);

    void SaveChanges();

    Task AddAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true);

    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);

    void AddRange(IEnumerable<TEntity> entities, bool saveNow = true);

    Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true);

    void Attach(TEntity entity);

    void Delete(TEntity entity, bool saveNow = true);

    Task DeleteAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true);

    void DeleteRange(IEnumerable<TEntity> entities, bool saveNow = true);

    Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true);

    void Detach(TEntity entity);

    TEntity GetById(params object[] ids);

    ValueTask<TEntity?> GetByIdAsync(CancellationToken cancellationToken, params object[] ids);

    void Update(TEntity entity, bool saveNow = true);

    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true);

    void UpdateRange(IEnumerable<TEntity> entities, bool saveNow = true);

    Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true);
}