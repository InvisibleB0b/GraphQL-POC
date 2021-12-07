using GraphQL_POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQL_POC.Interfaces
{
    public interface IErgastRaceService
    {

        public Task<List<Race>> GetRaces();

        public Task<List<Race>> GetSpecificRaces(string series, string season, string round);
    }
}
