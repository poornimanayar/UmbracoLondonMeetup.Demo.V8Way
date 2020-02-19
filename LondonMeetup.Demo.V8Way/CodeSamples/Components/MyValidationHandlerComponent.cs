using System.Web.Http;
using LondonMeetup.Demo.V8Way.CodeSamples.Handlers;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class MyValidationHandlerComponent : IComponent
    {
       /// <summary>Initializes the component.</summary>
        public void Initialize()
        {
            GlobalConfiguration.Configuration.MessageHandlers.Add(new MyRequestValidationHandler());
        }

        /// <summary>Terminates the component.</summary>
        public void Terminate()
        {
        }
    }
}