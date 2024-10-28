namespace Domain.Entities;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Vehicle
{
    [BsonId]
    [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
    public required string Id { get; set; }

    [BsonElement("make"), BsonRepresentation(BsonType.String)]
    public required string Make { get; set; }

    [BsonElement("model"), BsonRepresentation(BsonType.String)]
    public required string Model { get; set; }

    [BsonElement("vin"), BsonRepresentation(BsonType.String)]
    public required string Vin { get; set; }

    [BsonElement("licensePlate"), BsonRepresentation(BsonType.String)]
    public string? LicensePlate { get; set; }
}
