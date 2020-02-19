using LondonMeetup.Demo.V8Way.CodeSamples.Controllers;
using Umbraco.Core.Composing;
using Umbraco.Web;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class SwapDefaultControllerComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.SetDefaultRenderMvcController<MyRenderMvcController>();
        }
    }
}