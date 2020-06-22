using System;
using System.Linq;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Web.Actions;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Trees;


namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class RemoveTreeComponent : IComponent
    {
        public void Initialize()
        {
            TreeControllerBase.MenuRendering += this.MenuRendering;
        }

        private void MenuRendering(TreeControllerBase sender, MenuRenderingEventArgs e)
        {
            if(sender.TreeAlias == Constants.Trees.DocumentTypes 
               && sender.Security.CurrentUser.Name=="testdev")
            {
                e.Menu.Items.Clear();
            }
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}