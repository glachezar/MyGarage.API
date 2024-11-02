namespace Application.Queries.Vehicles;

using Application.Interfaces;
using Domain.Entities;
using MediatR;

public record GetAllVehiclesQuery() : IRequest<IEnumerable<Vehicle>>
{
}

public record GetAllVehiclesQueryHandler(IMongoDbService mongoDbService) : IRequestHandler<GetAllVehiclesQuery, IEnumerable<Vehicle>>
{
    public async Task<IEnumerable<Vehicle>> Handle(GetAllVehiclesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
