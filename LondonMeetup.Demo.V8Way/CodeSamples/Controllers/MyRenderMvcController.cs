using System.Web.Mvc;
using Umbraco.Core.Logging;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using ILogger = Umbraco.Core.Logging.ILogger;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Controllers
{
    public class MyRenderMvcController : RenderMvcController
    {
        private readonly ILogger _logger;

        public MyRenderMvcController(ILogger logger)
        {
            this._logger = logger;
        }

        public override ActionResult Index(ContentModel model)
        {
            //not doing much except for logging
            Logger.Info<MyRenderMvcController>("Something is being served");
            return base.Index(model);
        }
    }
}