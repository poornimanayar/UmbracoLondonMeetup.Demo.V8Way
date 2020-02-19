using LondonMeetup.Demo.V8Way.CodeSamples.ContentApps;
using Umbraco.Core.Composing;
using Umbraco.Web;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
   public class CustomCodeContentAppComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            // Append the content app to the collection
            composition.ContentApps().Append<CustomCodeContentApp>();
        }
    }
}