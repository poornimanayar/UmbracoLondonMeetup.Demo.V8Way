using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class AttributeRoutingComponent :IComponent
    {
        public void Initialize()
        {
           GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
           
           RouteTable.Routes.MapMvcAttributeRoutes();
           
           RouteTable.Routes.MapRoute("NonUmbracoRoute", "non-umbraco-page", 
               new { controller = "NonUmbracoPage", action = "Index" });
        }

        public void Terminate()
        {
            
        }
    }
}