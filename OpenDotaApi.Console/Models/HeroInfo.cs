using Newtonsoft.Json;
using OpenDotaApi.Console.Abstractions;

namespace OpenDotaApi.Console.Models
{
    public class HeroInfo : IHero
    {
        [JsonProperty("id")]
        public int HeroId { get; set; }

        [JsonProperty("name")]
        public string RockName { get; set; }

        [JsonProperty("localized_name")]
        public string FullName { get; set; }

        [JsonProperty("primary_attr")]
        public string PrimaryAttribute { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        public override string ToString()
        {
            return String.Format("{0,4} {1, 30}\t{2,12}\t{3,4}\t{4,24}",
                                        HeroId,
                                        RockName,
                                        FullName,
                                        PrimaryAttribute,
                                        string.Join(",", Roles));
        }
    }
}
