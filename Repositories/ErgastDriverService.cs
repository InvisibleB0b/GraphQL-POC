using GraphQL_POC.Interfaces;
using GraphQL_POC.Models;
using HotChocolate;
using HotChocolate.Resolvers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQL_POC.Repositories
{
    public class ErgastDriverService : IErgastDriverService
    {
        static private readonly HttpClient http = new HttpClient();

        public async Task<List<Result>> GetDriversFromRace([Parent] Race race)
        {
            var clientResponse = await http.GetAsync($"http://ergast.com/api/{race.series}/{race.season}/{race.round}/results.json");
            clientResponse.EnsureSuccessStatusCode();

            var jsonstring = await clientResponse.Content.ReadAsStringAsync();

            BaseObj data = JsonConvert.DeserializeObject<BaseObj>(jsonstring);

            List<Result> results = data.MRData.RaceTable.Races.FirstOrDefault(r => r.raceName == race.raceName)?.Results;

            if (results == null)
            {
                results = new List<Result>();
            }

            return results;
        }
    }
}
