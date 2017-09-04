#region Usings

using System;
using System.Collections.Generic;
using MetaActionsInterface;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class ExplodeFace : DrawingAction3D
    {
        public ExplodeFace() : base(ModifierNames.ExplodeFace)
        {
        }

        public override void OnActivate()
        {
            // Get the selected Node
            var selectedNode = NodeBuilderUtils.IdentifySelectedObjectLabel(Document.Root);
            if (selectedNode == null)
            {
                return;
            }

            // Check that the selected object is a group
            var func = selectedNode.Set<FunctionInterpreter>();
            if (func.Name != FunctionNames.Face)
            {
                return;
            }

            // Disable the notifications
            var referenceInterpreter = func.Dependency[0].Node.Get<ReferenceListInterpreter>();
            if (referenceInterpreter != null)
            {
                referenceInterpreter.Disable();
            }

            var nodeList = func.Dependency[0].ReferenceList;

            foreach (var sceneNode in nodeList)
            {
                var node = sceneNode.Node;
                // Display the Nodes that compose the group
                node.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.ToBeDisplayed;
                node.Remove<TreeViewVisibilityInterpreter>();
                node.Get<NamedShapeInterpreter>().Shape = node.Get<NamedShapeInterpreter>().Shape;
            }

            func.Dependency[0].ReferenceList = new List<SceneSelectedEntity>();

            if (referenceInterpreter != null)
            {
                referenceInterpreter.Enable();
            }

            // Hide the group Node
            NodeUtils.Hide(selectedNode);
            selectedNode.Set<TreeViewVisibilityInterpreter>();
            selectedNode.Get<NamedShapeInterpreter>().Shape = selectedNode.Get<NamedShapeInterpreter>().Shape;

            // Reload the tree view
            TreeView.LoadTree(Document.Root);
            // Clear the property view

            // Finish the transaction
            Document.Commit(String.Format("Apply ungroup"));

            UpdateView();

            // Change back to selection mode
            BackToNeutralModifier();
        }
    }
}