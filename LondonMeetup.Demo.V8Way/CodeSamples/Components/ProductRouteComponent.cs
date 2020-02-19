using System.Web.Routing;
using LondonMeetup.Demo.V8Way.CodeSamples.Handlers;
using Umbraco.Core.Composing;
using Umbraco.Web;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class ProductRouteComponent : IComponent
    {
        /// <summary>Initializes the component.</summary>
        public void Initialize()
        {
            //register my custom route and specify the handler (standard MVC)
             RouteTable.Routes.MapUmbracoRoute("ProductCustomRoute", "products/product/{sku}", new
            {
                controller = "MyProduct",
                action = "Product"
            }, new ProductsRouteHandler());
        }

        /// <summary>Terminates the component.</summary>
        public void Terminate()
        {
        }
    }
}