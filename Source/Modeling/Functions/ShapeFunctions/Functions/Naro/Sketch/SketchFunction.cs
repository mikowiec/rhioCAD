
#region Usings

using System.Linq;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
#endregion

namespace ShapeFunctions.Functions.Naro.Sketch
{
    public class SketchFunction : FunctionBase
    {
        public SketchFunction() : base(FunctionNames.Sketch)
        {
            // Sketch location and normal on it
            Dependency.AddAttributeType(InterpreterNames.Axis3D);
            // list of sketch faces
            Dependency.AddAttributeType(InterpreterNames.MeshTopoShape);
            //ref to node on whose face it's build
            Dependency.AddAttributeType(InterpreterNames.Reference);
            //face on which sketch is built
            Dependency.AddAttributeType(InterpreterNames.Integer);
        }

        public static bool CheckValidSketch(Axis planeNormal)
        {
            return !planeNormal.Direction.IsEqual(new Point3D(0, 0, 0));
        }

        public override bool Execute()
        {
            var sketchNormal = Dependency[0].Axis3D;
            var shape = Dependency[1].Shape;
            UpdatePoints(); 
            Shape = shape;
            return true;
        }

        private void UpdatePoints()
        {
            var root = this.Builder.Node.Root;
            var pointNodes = from node in root.ChildrenList
                             let builder = new NodeBuilder(node)
                             where builder.FunctionName == FunctionNames.Point
                             let currentSketchNode = AutoGroupLogic.FindSketchNode(node)
                             where currentSketchNode.Index == this.Builder.Node.Index
                             select node;
            var points = pointNodes.ToList();
            var sketchAx2 = new gpAx2 { Axis = NodeBuilderUtils.GetTransformedAxis(Builder) };
            var sketchPlane = new gpPln(new gpAx3(sketchAx2));
            foreach (var point in points)
            {
                var nb = new NodeBuilder(point);
                var current = nb[1].TransformedPoint3D;
                var projectedPlane = GeomUtils.ProjectPointOnPlane(current.GpPnt, sketchPlane, Precision.Confusion);
                nb[1].TransformedPoint3D = new Point3D(projectedPlane);
                nb.ExecuteFunction();
            }
        }
    }
}
