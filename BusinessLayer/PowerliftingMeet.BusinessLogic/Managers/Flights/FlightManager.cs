using PowerliftingMeet.BusinessEntities.Flights;
using PowerliftingMeet.DataAccessLayer.Repositories.Flights;

namespace PowerliftingMeet.BusinessLogic.Managers.Flights
{
    public class FlightManager : IFlightManager
    {
        private readonly IFlightRepository _flightRepo;

        public FlightManager(IFlightRepository flightRepo)
        {
            _flightRepo = flightRepo;
        }

        public Flight PrioritizeFlight(int flightId)
        {
            var flightDb = _flightRepo.GetFlight(flightId);

            return new Flight();
        }
    }
}
