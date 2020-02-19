using System.Web.Http;
using System.Web.Http.Cors;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class CorsComponent :IComponent
    {
        /// <summary>Initializes the component.</summary>
        public void Initialize()
        {
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            GlobalConfiguration.Configuration.EnableCors(corsAttr);
        }

        /// <summary>Terminates the component.</summary>
        public void Terminate()
        {
        }
    }
}
