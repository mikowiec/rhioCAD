#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    internal class PolylineFunction : FunctionBase
    {
        public PolylineFunction()
            : base(FunctionNames.Polyline)
        {
        }

        private static TopoDSShape CreateLine(Point3D first, Point3D second)
        {
            if (first.IsEqual(second))
                return null;

            var aEdge = new BRepBuilderAPIMakeEdge(first.GpPnt, second.GpPnt).Edge;
            return new BRepBuilderAPIMakeWire(aEdge).Wire;
        }

        public override bool Execute()
        {
            if (Dependency.Count < 2)
                return false;
            var compoundShape = new TopoDSCompound();
            var shapeBuilder = new BRepBuilder();
            shapeBuilder.MakeCompound(compoundShape);
            var resShape = (TopoDSShape) compoundShape;
            var isFirstPoint = true;
            var second = new Point3D();
            foreach (var childNode in Dependency.Children)
            {
                var point3D = childNode.TransformedPoint3D;
                if (isFirstPoint)
                {
                    second = point3D;
                    isFirstPoint = false;
                    continue;
                }
                var first = second;
                second = point3D;
                var shapeCut = CreateLine(first, second);
                if (shapeCut != null)
                    shapeBuilder.Add(resShape, shapeCut);
            }

            Shape = resShape;

            return true;
        }
    }
}