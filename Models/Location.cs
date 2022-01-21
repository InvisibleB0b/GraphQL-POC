using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_POC.Models
{
    public class Location
    {
        public string? lat { get; set; }
        public string? @long { get; set; }
        public string? locality { get; set; }
        public string? country { get; set; }
    }
}
