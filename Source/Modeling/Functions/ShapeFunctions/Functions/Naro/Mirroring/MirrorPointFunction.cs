#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Functions.Naro.Mirroring
{
    public class MirrorPointFunction : MirrorFunctionsCommon
    {
        public MirrorPointFunction()
            : base(FunctionNames.MirrorPoint)
        {
            // Profile
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Reference
            Dependency.AddAttributeType(InterpreterNames.Reference);
        }

        public override bool Execute()
        {
            var nodes = NodeBuilderUtils.CopyPaste(Dependency[0].ReferenceBuilder.Node);

            var nb = new NodeBuilder(Dependency[1].ReferenceBuilder.Node);
            var sketchNodes = new List<Node>();
            foreach (var point in nodes)
            {
                var transformation = point.Set<TransformationInterpreter>();
                transformation.CurrTransform.SetMirror(nb.Dependency[1].TransformedPoint3D.GpPnt);
                var node = NodeBuilderUtils.FindSketchNode(point);
                if (node != null)
                {
                    sketchNodes.Add(node);
                }
                var nb1 = new NodeBuilder(point);
                nb1.ExecuteFunction();
            }
          
            if (sketchNodes.Count > 0)
            {
                var document = sketchNodes[0].Root.Get<DocumentContextInterpreter>().Document;
                foreach (var sketchNode in sketchNodes)
                {
                    int shapeIndex = 0;
                    if (NodeUtils.SketchHas3DApplied(document, sketchNode, out shapeIndex))
                    {
                        sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, document);
                    }
                }
            }

            return true;
        }
    }
}