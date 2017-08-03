﻿using System.Web.Http;
using PowerliftingMeet.BusinessLogic.Managers.Lifters;

namespace PowerliftingMeet.Services.WebApi.Controllers.Lifters
{
    /// <summary>
    /// Lifter api route. Potentially move under V1 folder space  
    /// Create custom controller selector for versioning based on header 
    /// </summary>
    [RoutePrefix("api/lifters")]
    public class LiftersController : ApiController
    {
        private readonly ILifterManager _lifterManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lifterManager"></param>
        public LiftersController(ILifterManager lifterManager)
        {
            _lifterManager = lifterManager;
        }

        /// <summary>
        /// Get endpoint for retrieving single lifter by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(_lifterManager.GetLifter(id));
        }
    }
}
