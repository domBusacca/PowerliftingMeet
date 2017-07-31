using System.Web.Http;
using PowerliftingMeet.Ioc.WebApi;

namespace PowerliftingMeet.Services.WebApi
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
