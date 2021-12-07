using GraphQL_POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_POC.Interfaces
{
    public interface IErgastService
    {
        public Task<List<Race>> GetRaces();
    }
}
