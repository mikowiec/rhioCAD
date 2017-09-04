#region Usings

using System;
using NaroConstants.Names;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopoDS;
using OccCode;
using ShapeFunctions.Utils;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    /// <summary>
    ///   Generates a dimension shape.
    /// </summary>
    public class DimensionFunction : FunctionBase
    {
        public DimensionFunction()
            : base(FunctionNames.Dimension)
        {
            // Reference shape that contains the edge/circle
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Point where the text is located
            Dependency.AddAttributeType(InterpreterNames.Point3D);

            Dependency.AddAttributeType(InterpreterNames.Integer);

            //offset from the segment midpoint
            Dependency.AddAttributeType(InterpreterNames.Integer);

            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }

        public override void PreExecute()
        {
            Dependency[0].ConstraintType = ShapeOperations.Dimensionable;
        }

        public override bool Execute()
        {
            var referenceShape = ShapeUtils.ExtractSubShape(Dependency[0].ReferenceData);
            var refBuilder = new NodeBuilder(Dependency[0].Reference);
            var builder = Builder;
            builder.Visibility = refBuilder.Visibility;
            var textLocation = Dependency[1].TransformedPoint3D.GpPnt;
            var arrowType = Dependency[2].Integer == 1 ? DsgPrsArrowSide.DsgPrs_AS_NONE : DsgPrsArrowSide.DsgPrs_AS_BOTHAR;
            Point3D offset = new Point3D(textLocation);
            bool isOffset = false;

            if (Dependency[3].Integer == 1)
            {
                isOffset = true;
                Dependency[3].Integer = 0;
                var edge = TopoDS.Edge(referenceShape);
                var calculatedMidpoint = GeomUtils.CalculateEdgeMidPoint(edge);
                if (calculatedMidpoint != null)
                {
                    offset = new Point3D(textLocation.X - calculatedMidpoint.Value.X,
                                         textLocation.Y - calculatedMidpoint.Value.Y,
                                         textLocation.Z - calculatedMidpoint.Value.Z);
                    Dependency[4].Node.Set<Point3DInterpreter>().Value = offset;
                }
            }
            var interactive = DimensionUtils.CreateDependency(referenceShape, offset.GpPnt, arrowType, isOffset, Dependency[4].TransformedPoint3D.GpPnt);
            if (interactive == null)
                return false;
            Interactive = interactive;

            return true;
        }
    }
}