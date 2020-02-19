using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Controllers
{
    public class MyProductController : RenderMvcController
    {
        public ActionResult Product(ContentModel model, string id)
        {
            return this.View("Product", model);
        }
    }
}