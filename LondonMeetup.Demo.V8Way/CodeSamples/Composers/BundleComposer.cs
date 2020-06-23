using LondonMeetup.Demo.V8Way.CodeSamples.Components;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class BundleComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<BundleComponent>();
        }
    }
}