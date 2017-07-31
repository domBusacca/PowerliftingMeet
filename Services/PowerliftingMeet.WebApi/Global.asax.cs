using PowerliftingMeet.Ioc.WebApi;
using System.Web.Http;

namespace PowerliftingMeet.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(UnityConfig.Configure);
        }
    }
}
