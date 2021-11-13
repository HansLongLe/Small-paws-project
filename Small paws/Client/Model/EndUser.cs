using System.Text.Json.Serialization;

namespace Client.Model
{
    public class EndUser
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("userName")]
        public string Username { get; set; }

        [JsonPropertyName("password")]

        public string Password { get; set; }
        
    }
}