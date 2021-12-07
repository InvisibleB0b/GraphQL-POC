using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_POC.Models
{
    public class Result
    {
        public string number { get; set; }
        public string position { get; set; }
        public string positionText { get; set; }
        public string points { get; set; }
        public Driver Driver { get; set; }
        public string grid { get; set; }
        public string laps { get; set; }
        public string status { get; set; }
        public Time Time { get; set; }
        public FastestLap FastestLap { get; set; }
    }
    public class FastestLap
    {
        public string rank { get; set; }
        public string lap { get; set; }
        public Time Time { get; set; }
        public AverageSpeed AverageSpeed { get; set; }
    }
    public class Driver
    {
        public string driverId { get; set; }
        public string permanentNumber { get; set; }
        public string code { get; set; }
        public string url { get; set; }
        public string givenName { get; set; }
        public string familyName { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
    }

    public class Constructor
    {
        public string constructorId { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }
    }

    public class Time
    {
        public string millis { get; set; }
        public string time { get; set; }
    }

    public class AverageSpeed
    {
        public string units { get; set; }
        public string speed { get; set; }
    }
}
