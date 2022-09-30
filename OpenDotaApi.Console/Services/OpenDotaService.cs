using Newtonsoft.Json;
using OpenDotaApi.Console.Abstractions;
using OpenDotaApi.Console.Models;
using RestSharp;

namespace OpenDotaApi.Console.Services
{
    public class OpenDotaService : IDotaService
    {
        public readonly string ROOT_URL = "https://api.opendota.com/api/";

        public IHero[] FindHeroesByName(string name)
        {
            var client = new RestClient(ROOT_URL);

            var request = new RestRequest("heroStats", Method.Get);

            var queryResult = client.Execute(request);

            HeroInfo[]? result = JsonConvert.DeserializeObject<HeroInfo[]>(queryResult.Content);

            result = result.Where(k => k.FullName.Contains(name, StringComparison.InvariantCultureIgnoreCase)).ToArray();

            return result;
        }

        public IHero[] GetTop10HeroesByAttribute(string attribute)
        {
            var client = new RestClient(ROOT_URL);

            var request = new RestRequest("heroStats", Method.Get);

            var queryResult = client.Execute(request);

            HeroInfo[]? result = JsonConvert.DeserializeObject<HeroInfo[]>(queryResult.Content);

            result = result.Where(hero => hero.PrimaryAttribute == attribute).Take(10).ToArray();

            return result;
        }

        public ITeam[] GetTopNTeams(int N)
        {
            var client = new RestClient(ROOT_URL);

            var request = new RestRequest("teams", Method.Get);

            var queryResult = client.Execute(request);

            Team[]? result = JsonConvert.DeserializeObject<Team[]>(queryResult.Content);

            result = result.Take(N).ToArray();

            return result;
        }
    }
}
