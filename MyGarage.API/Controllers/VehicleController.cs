namespace MyGarage.API.Controllers
{
    using Domain.Entities;
    using Infrastructure.Data;
    using Application.Queries.Vehicles;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using MongoDB.Driver;

    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        readonly IMediator _mediator;

        public VehicleController(MongoDbService mongoDbService, IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Vehicle>> GetAll(CancellationToken cancellationToken) => 
            await _mediator.Send(new GetAllVehiclesQuery(), cancellationToken);
        
        [HttpGet("{id}")]
        public async Task<Vehicle?> GetById(string id, CancellationToken cancellationToken) => 
            await _mediator.Send(new GetVehicleByIdQuery(id), cancellationToken);
    }
}
