using System;
using System.Collections.Generic;
using System.Net.Http.Formatting;
using Umbraco.Core;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Mvc;
using Umbraco.Web.Trees;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Controllers
{
    [Tree("customCodeSection", "customCodeSectionTreeAlias", TreeGroup = "customCodeSectionGroup", SortOrder = 1)]
    //This helps route the views associated with the tree to App_Plugins folder.
    //It defaults to /umbraco/views/customCodeSectionTreeAlias otherwise
    [PluginController("CustomCodeSectionArea")]
    public class CustomCodeSectionTreeController : TreeController
    {

        //create the root node and show a dashboard
        protected override TreeNode CreateRootNode(FormDataCollection queryStrings)
        {
            var root = base.CreateRootNode(queryStrings);

            //the code will look for a view in the App_Plugins/CustomCodeSectionArea/BackOffice/CustomCodeSectionTreeAlias
            root.RoutePath = $"customCodeSection/customCodeSectionTreeAlias/overview";

            // set the icon
            root.Icon = "icon-hearts";

            // could be set to false for a custom tree with a single node. Eg Log Viewer and Languages in settings section
            root.HasChildren = true;

            return root;
        }

        //Add child nodes to root tree
        protected override TreeNodeCollection GetTreeNodes(string id, FormDataCollection queryStrings)
        {
            // check if we're rendering the root node's children
            if (id == Constants.System.Root.ToString())
            {
                //hard coding a set of tree nodes
                Dictionary<int, string> trees = new Dictionary<int, string>
                {
                    { 1, "Tree 1" },
                    { 2, "Tree 2" }
                };

                var nodes = new TreeNodeCollection();

                foreach (var tree in trees)
                {

                    //the code will look for a view in the App_Plugins/CustomCodeSectionArea/BackOffice/customCodeSectionTreeAlias
                    //the view name is set to be the node name with the space removed eg for Tree 1 the view name will be tree1
                    var routePath = $"customCodeSection/customCodeSectionTreeAlias/{tree.Value.Replace(" ", "")}";

                    // add each node to the tree collection using the base CreateTreeNode method
                    var node = CreateTreeNode(tree.Key.ToString(), Constants.System.Root.ToString(), 
                        queryStrings, tree.Value, "icon-presentation", false, routePath);
                    
                    node.MenuUrl = null; // no context menu
                  
                    nodes.Add(node);
                   
                }

                return nodes;
            }

            throw new NotSupportedException();
        }

        protected override MenuItemCollection GetMenuForNode(string id, FormDataCollection queryStrings)
        {
            //no actions for any menu item
            return null;
        }
        
    }
}