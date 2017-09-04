#region Usings
using MetaActionsInterface;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Actions;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Actions;
using NaroPipes.Constants;
using NaroUiBuilder;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using System.Linq;
using System.Drawing;
using ShapeFunctionsInterface.Utils;
#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    public class EndSketch : DrawingLiveShape
    {
        private ISketchButton _sketchButton;

        public EndSketch() : base(ModifierNames.EndSketch)
        {
        }

        public override void OnActivate()
        {
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            var uiBuilder = ActionsGraph[InputNames.UiBuilderInput].Get<UiBuilder>();
            var sketchControl = uiBuilder.GetItemAtPath("Ribbon/Modelling/Sketch/Sketch");
            
            _sketchButton = (ISketchButton) sketchControl;
            if (Document.Root.Get<DocumentContextInterpreter>().ActiveSketch != -1)
            {
                var sketchNode = Document.Root[Document.Root.Get<DocumentContextInterpreter>().ActiveSketch];

                // rebuild sketch faces             
                sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = null;
                var results = AutoGroupLogic.BuildAutoFaces(sketchNode, Document);
                Document.Transact();
                if (results.Count > 0)
                {
                    TopoDSShape finalShape = results[0];
                    // if there is more than one shape on the sketch, we need to sew the faces resulted from BuildAutoFaces
                    for (int i = 1; i < results.Count; i++)
                    {
                        if (results[i] == null)
                            continue;
                        var sew = new BRepBuilderAPISewing(1.0e-06, true, true, true, false);
                        sew.Add(finalShape);
                        sew.Add(results[i]);
                        var messg = new MessageProgressIndicator();
                        sew.Perform(messg);

                        finalShape = sew.SewedShape;
                    }

                    sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = finalShape;

                    // we need to set transparency to 1 (don't show) before we set it to hidden
                    sketchNode.Set<DrawingAttributesInterpreter>().Transparency = 1;
                    sketchNode.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
                }
                int index;
                NodeUtils.SetSketchTransparency(Document, sketchNode,
                                                NodeUtils.SketchHas3DApplied(Document, sketchNode, out index) ? ObjectVisibility.Hidden : ObjectVisibility.ToBeDisplayed);
            }
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, new DataPackage(null));
            Document.Root.Get<DocumentContextInterpreter>().ActiveSketch = -1;
            RemoveHighlightCurrentSketchNodes();
            Document.Commit("reset active sketch");
            _sketchButton.Unblock();
            if (ActionsGraph.PendingAction != null && ActionsGraph.PendingAction.Name == ModifierNames.None)
                Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode, TopAbsShapeEnum.TopAbs_FACE);
            ActionsGraph.SwitchAction(ModifierNames.None);
        }

        private void RemoveHighlightCurrentSketchNodes()
        {
            foreach (var node in Document.Root.ChildrenList)
            {
                var builder = new NodeBuilder(node);
                if (FunctionNames.GetSketchShapes().Contains(builder.FunctionName))
                    builder.Color = Color.DarkTurquoise;
            }
        }
    }
}