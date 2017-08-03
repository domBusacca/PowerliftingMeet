using PowerliftingMeet.DataAccessEntities.Flights;

namespace PowerliftingMeet.DataAccessLayer.Repositories.Flights
{
    public interface IFlightRepository
    {
        FlightDb GetFlight(int flightId);
    }
}
