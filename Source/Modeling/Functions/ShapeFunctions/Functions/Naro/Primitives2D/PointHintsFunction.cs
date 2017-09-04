#region Usings

using System.Collections.Generic;
using System.Drawing;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class PointHintsFunction : FunctionBase
    {
        public PointHintsFunction()
            : base(FunctionNames.PointHints)
        {
            // Point reference
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Constraints references list
            Dependency.AddAttributeType(InterpreterNames.ReferenceList);
            // plane axis
            Dependency.AddAttributeType(InterpreterNames.Axis3D);

        }

        public override bool Execute()
        {
            var point = Dependency[0].RefTransformedPoint3D;

            var wires = GetConstraintWires(point);
            TopoDSShape finalShape = wires[0];

            for (int i = 1; i < wires.Count; i++)
            {
                var sew = new BRepBuilderAPISewing(1.0e-06, true, true, true, false);
                sew.Add(finalShape);
                sew.Add(wires[i]);
                var messg = new MessageProgressIndicator();
                sew.Perform(messg);

                finalShape = sew.SewedShape;
            }

            Shape = finalShape;

            return true;
        }

        private List<TopoDSWire> GetConstraintWires(Point3D point)
        {
            var axis2 = new gpAx2 { Axis = Dependency[2].TransformedAxis3D };
            var pointOnplane = point.ToPoint2D(axis2);

            var constraintTypes = GetConstraintTypes();


            var wires = new List<TopoDSWire>();
            var currentX = pointOnplane.X + 1;
            var currentY = pointOnplane.Y + 1;
            //if (constraintTypes[2])
            //{
            //    wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 1.5),
            //             GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 1.5)));
            //    wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 1),
            //             GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 1)));
            //    currentX += 1.5;
            //}
            //if (constraintTypes[3])
            //{
            //    wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 1.5),
            //                   GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 1.5)));

            //    wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 0.5),
            //                   GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 1.5)));
            //    currentX += 1.5;
            //}
            //if (constraintTypes[0])
            //{
            //    wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 2.5),
            //                   GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 2.5)));
            //    currentX += 1.5;
            //}
            //if (constraintTypes[1])
            //{
            //    wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 0.5),
            //        GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 1.5)));
            //    currentX += 1.5;
            //}
            return wires;
        }

        private TopoDSWire Wire(Point3D firstPoint, Point3D secondPoint)
        {
            var aEdge2 = new BRepBuilderAPIMakeEdge(firstPoint.GpPnt, secondPoint.GpPnt).Edge;
            var wire = new BRepBuilderAPIMakeWire(aEdge2).Wire;
            return wire;
        }

        private bool[] GetConstraintTypes()
        {
            var constraintHints = new bool[] { false, false, false, false, false };
            var nodes = new List<Node>();
            for (int i = 0; i < Dependency[1].ReferenceList.Count;i++)
            {
                if (Dependency[1].ReferenceList[i].Node.Interpreters.Count == 0)
                {
                    continue;
                }
                nodes.Add(Dependency[1].ReferenceList[i].Node);
            }
            foreach (var node in nodes)
            {
                switch (node.Get<FunctionInterpreter>().Name)
                {
                    case (Constraint2DNames.PointOnArcFunction):
                        constraintHints[2] = true;
                        break;
                    case (Constraint2DNames.PointOnCircleFunction):
                        constraintHints[3] = true;
                        break;
                    case (Constraint2DNames.PointOnLineFunction):
                    case (Constraint2DNames.PointOnSegmentFunction):
                        constraintHints[0] = true;
                        break;
                    case (Constraint2DNames.PointOnPointFunction):
                        constraintHints[1] = true;
                        break;
                    case (Constraint2DNames.PointOnLineMidpointFunction):
                         constraintHints[4] = true;
                        break;
                }
            }
            return constraintHints;
        }
    }
}