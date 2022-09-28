using Newtonsoft.Json;
using OpenDotaApi.Console.Models;
using RestSharp;

namespace OpenDotaApi.Console.Services
{
    public class OpenDotaApiService
    {
        public readonly string ROOT_URL = "https://api.opendota.com/api/";

        public Team[] GetTopNTeams(int N)
        {
            var client = new RestClient(ROOT_URL);

            var request = new RestRequest("teams", Method.Get);
            
            var queryResult = client.Execute(request);

            Team[] result = JsonConvert.DeserializeObject<Team[]>(queryResult.Content);

            result = result.Take(N).ToArray();

            return result;
        }
    }
}
