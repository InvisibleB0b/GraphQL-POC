using GraphQL_POC.Models;
using HotChocolate;
using HotChocolate.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_POC.Interfaces
{
    public interface IErgastDriverService
    {

        public Task<List<Result>> GetDriversFromRace([Parent] Race race);
    }
}
