using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace WorkoutCounter.Models
{
    public class Counter
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Value { get; set; }
    }
}
