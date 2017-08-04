using System.Collections.Generic;
using PowerliftingMeet.BusinessEntities.Lifters;

namespace PowerliftingMeet.BusinessEntities.Flights
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightName { get; set; }
        public List<Lifter> Lifters { get; set; }
    }
}
