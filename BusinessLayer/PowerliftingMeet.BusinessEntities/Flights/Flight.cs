using System.Collections.Generic;
using PowerliftingMeet.BusinessEntities.Lifters;

namespace PowerliftingMeet.BusinessEntities.Flights
{
    public class Flight
    {
        public string FlightName { get; set; }
        public List<Lifter> Lifters { get; set; }
    }
}
