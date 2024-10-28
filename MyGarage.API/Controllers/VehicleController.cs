namespace MyGarage.API.Controllers
{
    using Domain.Entities;
    using Infrastructure.Data;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using MongoDB.Driver;

    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IMongoCollection<Vehicle>? _vehicles;
        public VehicleController(MongoDbService mongoDbService)
        {
            _vehicles = mongoDbService.Database?.GetCollection<Vehicle>("vehicle");
        }

        [HttpGet]
        public async Task<IEnumerable<Vehicle>> Get()
        {
            return await _vehicles.Find(FilterDefinition<Vehicle>.Empty).ToListAsync();
        }
    }
}
