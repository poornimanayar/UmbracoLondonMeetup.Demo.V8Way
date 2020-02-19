using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Core.Models.ContentEditing;
using Umbraco.Core.Models.Membership;

namespace LondonMeetup.Demo.V8Way.CodeSamples.ContentApps
{
    public class CustomCodeContentApp : IContentAppFactory
    {
        public ContentApp GetContentAppFor(object source, IEnumerable<IReadOnlyUserGroup> userGroups)
        {
            // do not show if logged in user is not in the admin group
            if (userGroups.All(x => x.Alias.ToLowerInvariant() != Umbraco.Core.Constants.Security.AdminGroupAlias))
                return null;

            // only show app on content items
            if (source is IContent)
            {
                var contentApp = new ContentApp
                {
                    Alias = "customCodeContentApp",
                    Name = "Custom Code Content App",
                    Icon = "icon-hearts",
                    View = "/App_Plugins/ContentApps/CustomCodeContentApp/view.html",
                    Weight = 0
                };

                return contentApp;
            }

            return null;
        }

        
    }
}