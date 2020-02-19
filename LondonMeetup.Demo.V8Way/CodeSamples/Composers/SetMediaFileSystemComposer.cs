using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.IO;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Composers
{
    public class SetMediaFileSystemComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            //commented out since this is only a reference
            //composition.SetMediaFileSystem(() => new PhysicalFileSystem("~/your-folderorpath-name"));
        }
    }
}

