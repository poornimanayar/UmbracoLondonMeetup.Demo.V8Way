using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Dashboards;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Dashboards
{
    [Weight(-5)]
    public class CustomCodeDashboard : IDashboard
    {
        public string Alias => "customCodeDashboard";

        public string[] Sections => new[]
        {
                Umbraco.Core.Constants.Applications.Content,
                Umbraco.Core.Constants.Applications.Settings
            };

        public string View => "/App_Plugins/MyCustomDashboards/MyCustomCodeDashboard/mycustomcodedashboard.html";

        // you can even specify permissions
        //in example access is granted to translator group and granted to admin 
        public IAccessRule[] AccessRules
        {
            get
            {
                var rules = new IAccessRule[]
                {
                    new AccessRule {Type = AccessRuleType.Deny, Value = Constants.Security.TranslatorGroupAlias},
                    new AccessRule {Type = AccessRuleType.Grant, Value = Constants.Security.AdminGroupAlias}
                };
                return rules;
            }
        }
    }
    
}
