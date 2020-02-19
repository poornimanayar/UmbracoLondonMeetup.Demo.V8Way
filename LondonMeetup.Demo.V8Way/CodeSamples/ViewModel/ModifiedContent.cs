using Newtonsoft.Json;

namespace LondonMeetup.Demo.V8Way.CodeSamples.ViewModel
{
    public class ModifiedContent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}