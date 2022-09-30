using Newtonsoft.Json;

namespace OpenDotaApi.Console.Models
{
    public class HeroInfo
    {
        [JsonProperty("id")]
        public int IdHero { get; set; }

        [JsonProperty("name")]
        public string RockName { get; set; }

        [JsonProperty("localized_name")]
        public string NormalName { get; set; }

        [JsonProperty("roles")]
        public string Roles { get; set; }
        
        
    }
}
