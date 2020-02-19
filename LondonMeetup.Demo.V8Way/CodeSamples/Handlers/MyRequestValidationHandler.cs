using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Serilog;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Handlers
{
    public class MyRequestValidationHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            // I want it to log only when I call this api, otherwise it will do for every single call made
            if (requestMessage.RequestUri.AbsolutePath.InvariantContains("umbraco/api/testapi"))
            {
                Current.Logger.Info(typeof(MyRequestValidationHandler),"I have been in the request handler");
            }

            return await base.SendAsync(requestMessage, cancellationToken);
        }
    }
}