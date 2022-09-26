using OpenDotaApi.Console.Models;
using RestSharp;

namespace OpenDotaApi.Console.Services
{
    public class OpenDotaApiService
    {
        public readonly string ROOT_URL = "https://api.opendota.com/api/";

        public Team[] GetTop10Teams()
        {
            //TODO:
            //1. Корректно преобразовать json в наш тип Team
            //2. Выбрать первых 10.

            var client = new RestClient(ROOT_URL);

            var request = new RestRequest("teams", Method.Get);

            var queryResult = client.Execute<Team[]>(request).Data;

            var res = client.Get<Team[]>(request);

            return queryResult;
        }
    }
}
