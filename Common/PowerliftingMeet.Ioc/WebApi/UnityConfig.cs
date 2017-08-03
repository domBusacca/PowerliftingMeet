using System;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.WebApi;
using PowerliftingMeet.BusinessLogic.Managers.Flights;
using PowerliftingMeet.BusinessLogic.Managers.Lifters;
using PowerliftingMeet.DataAccessLayer.Repositories.Flights;
using PowerliftingMeet.DataAccessLayer.Repositories.Lifters;

namespace PowerliftingMeet.Ioc.WebApi
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    /// // TODO: Think of moving UnityConfig and WebHosting into separate project so we don't have duplicate assembly references in two projects
    public class UnityConfig
    {
        /// <summary>
        /// Configures the Unity container.
        /// </summary>
        /// <param name="config">WebAPI http configuration object.</param>
        public static void Configure(HttpConfiguration config)
        {
            var container = new Lazy<IUnityContainer>(() =>
            {
                var unityContainer = new UnityContainer();
                ConfigureContainer(unityContainer);
                return unityContainer;
            });

            config.DependencyResolver = new UnityHierarchicalDependencyResolver(container.Value);
        }

        /// <summary>
        /// Actually configure the container.
        /// </summary>
        /// <param name="container">The container.</param>
        private static void ConfigureContainer(UnityContainer container)
        {
            // Business Layer
            container.RegisterType<ILifterManager, LifterManager>();
            container.RegisterType<IFlightManager, FlightManager>();

            // Data Access Layer
            container.RegisterType<ILifterRepository, LifterRepository>();
            container.RegisterType<IFlightRepository, FlightRepository>();
        }
    }
}
