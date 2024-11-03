namespace MyGarage.API.Controllers
{
    using Domain.Entities;
    using Infrastructure.Data;
    using Application.Queries.Vehicles;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using MongoDB.Driver;

    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IMongoCollection<Vehicle>? _vehicles;
        readonly IMediator _mediator;
        public VehicleController(MongoDbService mongoDbService, IMediator mediator)
        {
            _vehicles = mongoDbService.Database?.GetCollection<Vehicle>("vehicle");
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Vehicle>> Get()
        {
            return await _vehicles.Find(FilterDefinition<Vehicle>.Empty).ToListAsync();
        }

        [HttpGet]
        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            return await _mediator.Send(new GetAllVehiclesQuery());
        }
    }
}
