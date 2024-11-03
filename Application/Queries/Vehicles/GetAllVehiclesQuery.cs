namespace Application.Queries.Vehicles;

using Application.Interfaces;
using Domain.Entities;
using MediatR;

public record GetAllVehiclesQuery() : IRequest<IEnumerable<Vehicle>>;

internal class GetAllVehiclesQueryHandler : IRequestHandler<GetAllVehiclesQuery, IEnumerable<Vehicle>>
{
    readonly IRepository<Vehicle> _vehicleRepository;

    public GetAllVehiclesQueryHandler(IRepository<Vehicle> vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    public async Task<IEnumerable<Vehicle>> Handle(GetAllVehiclesQuery request, CancellationToken cancellationToken)
    {
        return await _vehicleRepository.GetAllAsync(cancellationToken);
    }
}
