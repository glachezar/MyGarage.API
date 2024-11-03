namespace Application.Interfaces;

using Domain.Entities;

public interface IVehicleRepository
{
    Task<IEnumerable<Vehicle>> GetAllAsync(CancellationToken cancellationToken);

    Task<IEnumerable<Vehicle>> GetAllWithPredicateAsync(Func<Vehicle, bool> predicate, CancellationToken cancellationToken);

    Task<Vehicle?> GetByIdAsync(string id, CancellationToken cancellationToken);

    Task AddAsync(Vehicle entity, CancellationToken cancellationToken);

    void Update(Vehicle entity);

    void Delete(Vehicle entity);
}

