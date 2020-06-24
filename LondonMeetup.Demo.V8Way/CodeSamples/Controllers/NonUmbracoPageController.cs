using System.Web.Mvc;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Controllers
{
    public class NonUmbracoPageController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View("~/Views/NonUmbracoPage.cshtml");
        }
    }
}