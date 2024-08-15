using System.Text.Json.Serialization;

namespace ConsoleApp3
{
    public class TopAnimeResponse
    {
        [JsonPropertyName("data")]
        public Anime[] Top { get; set; }
    }
}