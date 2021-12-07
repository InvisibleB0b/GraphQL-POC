using GraphQL_POC.Models;
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
                .Field(r => r.Results);
        }
    }
}
