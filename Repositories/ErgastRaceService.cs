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
    public class ErgastRaceService : IErgastRaceService
    {
        static private readonly HttpClient http = new HttpClient();

        public async Task<List<Race>> GetRaces()
        {
            var clientResponse = await http.GetAsync("http://ergast.com/api/f1.json");
            clientResponse.EnsureSuccessStatusCode();

            var jsonstring = await clientResponse.Content.ReadAsStringAsync();

            BaseObj data = JsonConvert.DeserializeObject<BaseObj>(jsonstring);

            List<Race> races = data.MRData.RaceTable.Races;

            races = races.Select(r => { r.series = data.MRData.series; r.Id = $"{r.series} {r.season} {r.round}"; return r; }).ToList();

            return races;
        }

        public async Task<List<Race>> GetSpecificRaces(string series, string season, string round)
        {
            var clientResponse = await http.GetAsync($"http://ergast.com/api/{series}{(season == null ? "" : round == null ? $"/{season}" : $"/{season}/{round}")}.json");
            clientResponse.EnsureSuccessStatusCode();

            var jsonstring = await clientResponse.Content.ReadAsStringAsync();

            BaseObj data = JsonConvert.DeserializeObject<BaseObj>(jsonstring);

            List<Race> races = data.MRData.RaceTable.Races;

            races = races.Select(r => { r.series = data.MRData.series; r.Id = $"{r.series} {r.season} {r.round}"; return r; }).ToList();

            return races;
        }
    }
}