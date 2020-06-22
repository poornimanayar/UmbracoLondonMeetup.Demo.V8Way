using LondonMeetup.Demo.V8Way.CodeSamples.Dashboards;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Umbraco.Web.Dashboards;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class DashboardComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Dashboards().Remove<SettingsDashboard>();
            composition.Dashboards().Remove<ExamineDashboard>().Add<MyExamineManagementDashboard>();
        }
    }
}