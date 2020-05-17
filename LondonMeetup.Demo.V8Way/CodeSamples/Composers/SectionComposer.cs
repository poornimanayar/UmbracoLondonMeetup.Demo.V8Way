using LondonMeetup.Demo.V8Way.CodeSamples.Sections;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Umbraco.Web.Sections;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class SectionComposer : IUserComposer
    {
        /// <summary>Compose.</summary>
        public void Compose(Composition composition)
        {
            //insert a section at a particular position 4 (based on a zero index)
            composition.Sections().Insert<CustomCodeSection>(4);

            //last item in section collection
            // composition.Sections().Append<CustomCodeSection>();

            //insert after packages section
            // composition.Sections().InsertAfter<PackagesSection, CustomCodeSection>();

            //insert before packages section
            //composition.Sections().InsertBefore<SettingsSection, CustomCodeSection>();
        }
    }
}