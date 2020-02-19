using LondonMeetup.Demo.V8Way.CodeSamples.Components;
using LondonMeetup.Demo.V8Way.CodeSamples.Examine;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class ProductIndexComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<ProductIndexComponent>();

            // we want to register the new indexes their own implementation
            // IUmbracoIndexesCreator is registered using the UmbracoIndexesCreator
            // which defines the internal, external and member indexes out of the box
            // we dont want to swap them out
            composition.RegisterUnique<ProductIndexCreator>();
        }
    }
}