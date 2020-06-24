using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class NonUmbracoRouteComponent : IComponent
    {
        public void Initialize()
        {
            RouteTable.Routes.MapRoute("NonUmbracoRoute", "non-umbraco-page", 
               new { controller = "NonUmbracoPage", action = "Index" });
        }

        public void Terminate()
        {
            
        }
    }
}