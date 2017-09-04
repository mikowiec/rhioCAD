#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroPipes.Constants;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Implements the Revolve modifier.
    /// </summary>
    public class Revolve : ModifierTwoShapesCommon
    {
        public Revolve() : base(ModifierNames.Revolve)
        {
            FirstMessage = ModelingResources.RevolveStep1;
            SecondMessage = ModelingResources.RevolveStep2;
        }

        protected override bool ApplyFunction()
        { 
            var builder = new NodeBuilder(Document, FunctionNames.Revolve);
            var sketchNode = AutoGroupLogic.FindSketchNode(FirstShape);
            Node node = FirstShape;
            if (sketchNode != null)
            {
               if (sketchNode.Children[2].Get<MeshTopoShapeInterpreter>() == null)
                {
                    var tempFace = AutoGroupLogic.RebuildSketchFace(sketchNode, Document);
                    if (tempFace != null)
                    {
                        sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = tempFace;
                        NodeUtils.SetSketchTransparency(Document, sketchNode, ObjectVisibility.Hidden);
                        sketchNode.Set<DrawingAttributesInterpreter>().Transparency = 1;
                        sketchNode.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
                        Document.Commit("Sketch face generated");
                        node = sketchNode;
                    }
                }
               else
               {
                   node = sketchNode;
               }
            }
            builder[0].Reference = node;
            builder[1].Reference = SecondShape;
            builder[2].Real = 360.0;
            if (builder.ExecuteFunction())
            {
                AddNodeToTree(builder.Node);
                if(node==sketchNode)
                    NodeUtils.SetSketchTransparency(Document, sketchNode, ObjectVisibility.Hidden);
                return true;
            }
            return false;
        }

        protected override void DocumentCommitReason()
        {
            Document.Commit("Apply Revolve");
        }
    }
}