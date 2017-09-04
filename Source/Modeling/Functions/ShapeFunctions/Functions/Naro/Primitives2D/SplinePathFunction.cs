#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.TopoDS;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class SplinePathFunction : FunctionBase
    {
        public SplinePathFunction()
            : base(FunctionNames.SplinePath)
        {
            //Point count
            AddDependency(InterpreterNames.Integer);
        }

        public override bool Execute()
        {
            Ensure.AreEqual(Dependency[0].Integer%3, 1);
            while (Dependency[0].Integer != Dependency.Count - 1)
                AddDependency(InterpreterNames.Point3D);
            var pointList = new Point3D[4];
            var items = Dependency[0].Integer;

            var compoundShape = new TopoDSCompound();
            var shapeBuilder = new BRepBuilder();
            shapeBuilder.MakeCompound(compoundShape);
            var startIndex = 0;
            while (startIndex < items - 1)
            {
                pointList[0] = Dependency[startIndex + 1].TransformedPoint3D;
                pointList[1] = Dependency[startIndex + 2].TransformedPoint3D;
                pointList[2] = Dependency[startIndex + 3].TransformedPoint3D;
                pointList[3] = Dependency[startIndex + 4].TransformedPoint3D;

                var shape = SplineUtils.BuildSplineWire(pointList);
                shapeBuilder.Add(compoundShape, shape);
                startIndex += 3;
            }

            Shape = compoundShape;

            return true;
        }
    }
}