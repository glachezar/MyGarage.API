namespace Domain.Entities;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

public class BaseEntity
{
    [BsonId]
    [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
    public required string Id { get; set; }
}
