namespace Application.Queries.Vehicles;

using Application.Interfaces;
using Domain.Entities;
using MediatR;

public record GetVehicleByIdQuery(string id) : IRequest<Vehicle?>;

internal class GetVehicleByIdQueryHandler : IRequestHandler<GetVehicleByIdQuery, Vehicle?>
{
    readonly IVehicleRepository _vehicleRepository;

    public GetVehicleByIdQueryHandler(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    public async Task<Vehicle?> Handle(GetVehicleByIdQuery request, CancellationToken cancellationToken)
    {
        return await _vehicleRepository.GetByIdAsync(request.id, cancellationToken);
    }
}
