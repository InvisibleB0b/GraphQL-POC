using GraphQL_POC.Interfaces;
using GraphQL_POC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQL_POC.Repositories
{
    public class ErgastService : IErgastService
    {
        public async Task<List<Race>> GetRaces()
        {

            HttpClient client = new HttpClient();
            var clientResponse = await client.GetAsync("http://ergast.com/api/f1.json");
            clientResponse.EnsureSuccessStatusCode();

            var jsonstring = await clientResponse.Content.ReadAsStringAsync();

            BaseObj data = JsonConvert.DeserializeObject<BaseObj>(jsonstring);

            List<Race> races = data.MRData.RaceTable.Races;

            return races;

        }
    }
}