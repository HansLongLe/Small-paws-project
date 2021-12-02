using System;
using System.Text.Json.Serialization;

namespace Client.Model
{
    public class AdoptRequest
    {
        [JsonPropertyName("requestId")]
        public int RequestId { get; set; }
        
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        
        [JsonPropertyName("animalId")]
        public int AnimalId { get; set; }
        
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        
        [JsonPropertyName("animalType")]
        public string AnimalType { get; set; }
        
        [JsonPropertyName("animalName")]
        public string AnimalName { get; set; }
        
        [JsonPropertyName("veterinarianId")]
        public int VeterinarianId { get; set; }
        
       [JsonPropertyName("approved")]
        public bool? Approved { get; set; }
    }
}