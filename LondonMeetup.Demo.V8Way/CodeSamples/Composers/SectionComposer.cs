using LondonMeetup.Demo.V8Way.CodeSamples.Sections;
using Umbraco.Core.Composing;
using Umbraco.Web;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class SectionComposer : IUserComposer
    {
        /// <summary>Compose.</summary>
        public void Compose(Composition composition)
        {
            //insert a section at a particular position
            composition.Sections().Insert<CustomCodeSection>(4);
        }
    }
}