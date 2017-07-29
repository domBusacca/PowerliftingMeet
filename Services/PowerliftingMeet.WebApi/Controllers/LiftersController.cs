using System.Web.Http;

namespace PowerliftingMeet.WebApi.Controllers
{
    [RoutePrefix("api/lifter")]
    public class LiftersController : ApiController
    {
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("Lifter");
        }
    }
}
