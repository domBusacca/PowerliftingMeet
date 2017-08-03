using PowerliftingMeet.DataAccessEntities.Flights;

namespace PowerliftingMeet.DataAccessLayer.Repositories.Flights
{
    public class FlightRepository : IFlightRepository
    {
        public FlightDb GetFlight(int flightId)
        {
            return new FlightDb();
        }
    }
}
