using System.Web.Mvc;
using LondonMeetup.Demo.V8Way.CodeSamples.Services;
using Umbraco.Web.Mvc;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Controllers
{
    public class DemoSurfaceController : SurfaceController
    {
        private readonly IMyService _myService;

        //inject my service DI works out the implementation
        public DemoSurfaceController(IMyService myInterface)
        {
            this._myService = myInterface;
        }

        // GET: DemoSurface
        public ActionResult GetVersions()
        {
            var versions = this._myService.GetVersions(this.CurrentPage.Id);
            return this.PartialView("GetVersions", versions);
        }
    }
}