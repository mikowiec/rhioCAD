#region Usings

using System.Collections.Generic;
using NaroConstants.Names;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class SplineFunction : FunctionBase
    {
        public SplineFunction() : base(FunctionNames.Spline)
        {
        }

        public override bool Execute()
        {
            var count = Parent.Children.Count;
            if (count <= 1)
                return false;
            var pointList = new List<Point3D>();
            for (var i = 1; i < count; i++)
                pointList.Add(Parent[i].Get<Point3DInterpreter>().Value);

            var wire = SplineUtils.BuildSplineWire(pointList);
            Shape = wire;

            return true;
        }
    }
}