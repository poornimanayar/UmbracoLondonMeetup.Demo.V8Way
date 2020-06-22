using System;
using System.Linq;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Events;
using Umbraco.Core.Logging;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class MyMemberSaveEventComponent : IComponent
    {
        //this is Umbraco.Core.Logging, I had a rip-my-hair-apart moment!!!!!
        private readonly ILogger _logger;

        public MyMemberSaveEventComponent(ILogger logger)
        {
            this._logger = logger;
        }


        // initialize: runs once when Umbraco starts
        public void Initialize()
        {
            MemberService.Saved += this.MemberService_Saved;
        }

        private void MemberService_Saved(IMemberService sender, SaveEventArgs<IMember> e)
        {
            foreach (var member in e.SavedEntities)
            {
                this._logger.Info<MyPublishEventComponent>("member {member} has been saved and event fired!", member.Name);
            }
        }

        // terminate: runs once when Umbraco stops
        public void Terminate()
        { }
    }
}