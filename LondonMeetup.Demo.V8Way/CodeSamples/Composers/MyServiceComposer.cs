using LondonMeetup.Demo.V8Way.CodeSamples.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class MyServiceComposer :IUserComposer
    {
        /// <summary>Register my implementation.</summary>
        public void Compose(Composition composition)
        {
            composition.Register<IMyService, MyService>();
        }
    }
}