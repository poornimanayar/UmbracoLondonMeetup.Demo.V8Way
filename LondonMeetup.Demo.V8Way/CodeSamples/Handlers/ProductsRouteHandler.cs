using System.Linq;
using System.Web.Routing;
using Umbraco.Core.Composing;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Handlers
{
    public class ProductsRouteHandler : UmbracoVirtualNodeRouteHandler
    {
        protected override IPublishedContent FindContent(RequestContext requestContext, UmbracoContext umbracoContext)
        {

            //get the sku value from RouteData
            var sku = requestContext.RouteData.Values["sku"].ToString();

            // get the product content type
            var productContentType = umbracoContext.Content.GetContentType("product");

            //query the product nodes based on the sku value and return the node
            var product = umbracoContext.Content.GetByContentType(productContentType).FirstOrDefault(p => p.Value<string>("sku") == sku) as Product;

            //Logging
            Current.Logger.Info(typeof(ProductsRouteHandler), "I have detected a virtual node");

            return product;
        }
    }
}