namespace Infrastructure.Repositories;

using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using MongoDB.Driver;

public class Repository<T> : IRepository<T>
    where T : BaseEntity
{
    private readonly IMongoCollection<T>? _entity;
    public Repository(MongoDbService context)
    {
        _entity = context.Database?.GetCollection<T>(typeof(T).Name);
    }
    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken) =>
        await _entity.Database.GetCollection<T>(typeof(T).Name)
        .Find(FilterDefinition<T>.Empty).ToListAsync(cancellationToken);

    public Task<IEnumerable<T>> GetAllWithPredicateAsync(Func<T, bool> predicate, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(T entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }
}