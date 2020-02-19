using Umbraco.Core.Models.Sections;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Sections
{
    public class CustomCodeSection : ISection
    {
        /// <inheritdoc />
        public string Alias => "customCodeSection";

        /// <inheritdoc />
        public string Name => "Custom Code Section";
    }
}