using System.Web.Mvc;
using System.Web.Routing;
using LondonMeetup.Demo.V8Way.CodeSamples.Components;
using LondonMeetup.Demo.V8Way.CodeSamples.Controllers;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class NonUmbracoRouteComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            //custom controllers are not registered automatically to the DI container
            composition.Register<NonUmbracoPageController>();
                
            composition.Components().Append<NonUmbracoRouteComponent>(); ;
        }
    }
}