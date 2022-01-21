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
                .ImplementsNode()
                .IdField(f => f.Id)
                .ResolveNode(async (context, id) =>
                {
                    List<string> identifiers = id.Split(" ").ToList();

                    List<Race> race = await context.Service<ErgastRaceService>().GetSpecificRaces(identifiers[0], identifiers[1], identifiers[2]);

                    return race[0];
                });

            descriptor
                .Field(r => r.Results)
                .ResolveWith<ErgastDriverService>((x) => x.GetDriversFromRace(default));
        }
    }
}
