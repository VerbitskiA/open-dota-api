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

        public Team[] SortArray(Team[] teams, string key, bool asc)
        {
            switch (key)
            {
                case "Wins":
                    if (asc)
                    {
                        teams = teams.OrderBy(k => k.Wins).ToArray();
                    }
                    else
                    {
                        teams = teams.OrderByDescending(k => k.Wins).ToArray();
                    }
                    break;
                case "Rating":
                    if (asc)
                    {
                        teams = teams.OrderBy(k => k.Rating).ToArray();
                    }
                    else
                    {
                        teams = teams.OrderByDescending(k => k.Rating).ToArray();
                    }
                    break;
                case "Losses":
                    if (asc)
                    {
                        teams = teams.OrderBy(k => k.Losses).ToArray();
                    }
                    else
                    {
                        teams = teams.OrderByDescending(k => k.Losses).ToArray();
                    }
                    break;
                default:
                    break;
            }

            return teams;
        }
    }
}
