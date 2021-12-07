using GraphQL_POC.Interfaces;
using GraphQL_POC.Models;
using HotChocolate;
using HotChocolate.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQL_POC.Queries
{
    [ExtendObjectType("Query")]
    public class RacesQuery
    {
        public async Task<List<Race>> GetRaces([Service] IErgastService serive) => await serive.GetRaces();
    }
}
