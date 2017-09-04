#region Usings

using System;
using ConstraintsModule.Primitives;
using TreeData.AttributeInterpreter;

#endregion

namespace ConstraintsModule.Mappings.Shapes
{
    public class ArcSolverObjectMapper : ShapeSolverObjectMapping
    {
        protected override void MapToSolver()
        {
            //var arcCenter = MappedReference<Point>(0);
            //var startPoint = MappedReference<Point>(1);
            //var endPoint = MappedReference<Point>(2);

            //var radius = SketchSolverUtils.Distance(arcCenter, startPoint);
            //var startAngle = Math.Asin(startPoint.Y.Value/radius);
            //var endAngle = Math.Asin(endPoint.Y.Value/radius);

            //var refCenter = MappedReference<Point>(0);
            //var refRadius = new DoubleRefObject(radius);
            //var refStartAngle = new DoubleRefObject(startAngle);
            //var refEndAngle = new DoubleRefObject(endAngle);
            //_parameters.Add(refEndAngle);
            //_parameters.Add(refRadius);
            //_parameters.Add(refStartAngle);
            //var arc = new Arc
            //              {Center = refCenter, EndAngle = refEndAngle, Radius = refRadius, StartAngle = refStartAngle};
            //MapSelf(arc);
        }

        protected override void UnmapFromSolver()
        {
            //var arc = UnmapSelf<Arc>();

            //var arcStartPoint = new Point3D(arc.Radius.Value*Math.Sin(arc.StartAngle.Value),
            //                                arc.Radius.Value*Math.Cos(arc.StartAngle.Value), 0);
            //var arcEndPoint = new Point3D(arc.Radius.Value*Math.Sin(arc.EndAngle.Value),
            //                              arc.Radius.Value*Math.Cos(arc.EndAngle.Value), 0);
            //var startPoint = _coordinateTranslator.ConvertToGlobal(arcStartPoint);
            //var endPoint = _coordinateTranslator.ConvertToGlobal(arcEndPoint);
            //var centerSolverPoint = arc.Center;
            //var centerPoint =
            //    _coordinateTranslator.ConvertToGlobal(new Point3D(centerSolverPoint.X.Value, centerSolverPoint.Y.Value,
            //                                                      0));
            //_builder[0].RefTransformedPoint3D = centerPoint;
            //_builder[1].RefTransformedPoint3D = startPoint;
            //_builder[2].RefTransformedPoint3D = endPoint;
        }
    }
}