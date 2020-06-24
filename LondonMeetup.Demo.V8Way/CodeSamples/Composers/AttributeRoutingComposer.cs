using System.Web.Mvc;
using System.Web.Routing;
using LondonMeetup.Demo.V8Way.CodeSamples.Components;
using LondonMeetup.Demo.V8Way.CodeSamples.Controllers;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class AttributeRoutingComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<NonUmbracoPageController>();
                
            composition.Components().Append<AttributeRoutingComponent>(); ;
        }
    }
}