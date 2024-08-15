using System.Text.Json.Serialization;

namespace ConsoleApp3
{
    public class Anime
    {
        [JsonPropertyName("mal_id")]
        public int MalId { get; set; }

        [JsonPropertyName("rank")]
        public int? Rank { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("score")]
        public double Score { get; set; }
    }
}