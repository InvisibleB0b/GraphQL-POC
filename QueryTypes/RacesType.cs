using GraphQL_POC.Models;
using GraphQL_POC.Repositories;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_POC.QueryTypes
{
    public class RacesType : ObjectType<Race>
    {

        protected override void Configure(IObjectTypeDescriptor<Race> descriptor)
        {
            descriptor
                .Field(r => r.Results)
                .ResolveWith<ErgastDriverService>((x) => x.GetDriversFromRace(default));
        }
    }
}
