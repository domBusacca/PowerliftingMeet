using System.Web.Http;
using PowerliftingMeet.BusinessLogic.Managers.Lifters;

namespace PowerliftingMeet.Services.WebApi.Controllers
{
    [RoutePrefix("api/lifter")]
    public class LiftersController : ApiController
    {
        private readonly ILifterManager _lifterManager;

        public LiftersController(ILifterManager lifterManager)
        {
            _lifterManager = lifterManager;
        }

        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(_lifterManager.GetLifter(id));
        }
    }
}
