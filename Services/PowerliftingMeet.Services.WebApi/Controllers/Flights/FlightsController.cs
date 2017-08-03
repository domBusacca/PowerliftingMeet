using System.Web.Http;
using PowerliftingMeet.BusinessLogic.Managers.Flights;

namespace PowerliftingMeet.Services.WebApi.Controllers.Flights
{
    /// <summary>
    /// Lifter api route. Potentially move under V1 folder space  
    /// Create custom controller selector for versioning based on header 
    /// </summary>
    [RoutePrefix("api/flights")]
    public class FlightsController : ApiController
    {
        private readonly IFlightManager _flightManager;

        /// <summary>
        /// 
        /// </summary>
        public FlightsController(IFlightManager flightManager)
        {
            _flightManager = flightManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{flightId:int}/prioritize")]
        public IHttpActionResult Prioritize(int flightId)
        {
            return Ok(_flightManager.PrioritizeFlight(flightId));
        }
    }
}
