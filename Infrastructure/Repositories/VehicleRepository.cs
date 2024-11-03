namespace Infrastructure.Repositories;

using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using MongoDB.Driver;
using System;

public class VehicleRepository : IVehicleRepository
{
    private readonly IMongoCollection<Vehicle>? _entity;
    public VehicleRepository(MongoDbService context)
    {
        _entity = context.Database?.GetCollection<Vehicle>("vehicle");
    }

    public async Task<IEnumerable<Vehicle>> GetAllAsync(CancellationToken cancellationToken) =>
        await _entity.Find(FilterDefinition<Vehicle>.Empty).ToListAsync(cancellationToken);

    public Task<IEnumerable<Vehicle>> GetAllWithPredicateAsync(Func<Vehicle, bool> predicate, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<Vehicle?> GetByIdAsync(string id, CancellationToken cancellationToken) =>
        await _entity.Find(x => x.Id == id).FirstOrDefaultAsync(cancellationToken);

    public Task AddAsync(Vehicle entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public void Update(Vehicle entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Vehicle entity)
    {
        throw new NotImplementedException();
    }
}