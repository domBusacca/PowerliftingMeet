using PowerliftingMeet.BusinessEntities.Flights;

namespace PowerliftingMeet.BusinessLogic.Managers.Flights
{
    public interface IFlightManager
    {
        Flight PrioritizeFlight(int flightId);
    }
}
