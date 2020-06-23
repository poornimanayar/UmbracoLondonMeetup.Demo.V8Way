using System.Web.Http;
using System.Web.Optimization;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class BundleComponent : IComponent
    {
        public void Initialize()
        {
            BundleTable.Bundles.Add(new StyleBundle("~/bundles/styles").Include(
                "~/css/umbraco-starterkit-style.css"));
            
            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/scripts").Include("~/scripts/umbraco-starterkit-app.js"));
            
            BundleTable.EnableOptimizations = true;
        }

        public void Terminate()
        {
            throw new System.NotImplementedException();
        }
    }
}