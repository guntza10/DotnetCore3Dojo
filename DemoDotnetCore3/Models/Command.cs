using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace DemoDotnetCore3.Models
{
    public class Command
    {
        [BsonId]
        public string Id { get; set; }
        [Required(ErrorMessage = "HowTo is required!")]
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
    }
}