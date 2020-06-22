using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Dashboards;
using Umbraco.Web.Dashboards;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Dashboards
{
    [Weight(20)]
    public class MyExamineManagementDashboard : ExamineDashboard, IDashboard
    {
        public new IAccessRule[] AccessRules
        {
            get
            {
                var rules = new IAccessRule[]
                {
                    new AccessRule {Type = AccessRuleType.Deny, Value = "settingsOnly"}
                };
                return rules;
            }
        }
    }
}