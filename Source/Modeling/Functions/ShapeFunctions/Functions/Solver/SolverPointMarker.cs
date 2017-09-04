#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Prs3d;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Solver
{
    public class SolverPointMarker : FunctionBase
    {
        public SolverPointMarker()
            : base(FunctionNames.SolverPointMarker)
        {
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            Dependency.AddAttributeType(InterpreterNames.Real);
            Dependency.AddAttributeType(InterpreterNames.Integer);
        }

        public override bool Execute()
        {
            Parent.Get<DrawingAttributesInterpreter>().HasNoColor = true;
            var point3D = Dependency[0].TransformedPoint3D;
            var scale = Dependency[1].Real;
            var markerType = (AspectTypeOfMarker) Dependency[2].Integer;

            var col = Parent.Get<DrawingAttributesInterpreter>().Color;
            var color = ShapeUtils.GetOccColor(col);
            var cartesianPoint = new GeomCartesianPoint(point3D.X, point3D.Y, point3D.Z);
            var marker = new AISPoint(cartesianPoint);
            var drawer = marker.Attributes;
           // drawer.PointAspect((new Prs3dPointAspect(markerType, color, scale)));
            marker.UnsetSelectionMode();

            Interactive = marker;
            return true;
        }
    }
}