using LondonMeetup.Demo.V8Way.CodeSamples.Components;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class ProductRouteComposer : IUserComposer
    {
        /// <summary>Compose.</summary>
        public void Compose(Composition composition)
        {
            composition.Components().Insert<ProductRouteComponent>();
        }
    }
}