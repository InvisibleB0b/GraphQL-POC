using GraphQL_POC.Interfaces;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_POC.Models
{
    public class Race
    {
        public string series { get; set; }
        public string season { get; set; }
        public string round { get; set; }
        public string url { get; set; }
        public string raceName { get; set; }
        public Circuit Circuit { get; set; }
        public string date { get; set; }
        public List<Result>? Results { get; set; }
    }
}
