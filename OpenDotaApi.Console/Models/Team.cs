using Newtonsoft.Json;
using OpenDotaApi.Console.Abstractions;

namespace OpenDotaApi.Console.Models
{
    public class Team : ITeam
    {
        [JsonProperty("team_id")]
        public int TeamId { get; set; }

        [JsonProperty("name")]
        public string FullName { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("last_match_time")]
        public int LastMatchTime { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        public override string ToString()
        {
            return String.Format("{0,24}{1, 11}\t{2,8}\t{3,8}\t{4,8}\t{5,15}",
                                        FullName,
                                        Tag,
                                        Rating,
                                        Wins,
                                        Losses,
                                        LastMatchTime);
        }
    }
}
