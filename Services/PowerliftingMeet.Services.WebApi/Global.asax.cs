using System.Web.Http;
using PowerliftingMeet.Ioc.WebApi;

namespace PowerliftingMeet.Services.WebApi
{
    /// <summary>
    /// 
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(UnityConfig.Configure);
        }
    }
}
