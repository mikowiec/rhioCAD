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
    public class LineHintsFunction : FunctionBase
    {
        public LineHintsFunction()
            : base(FunctionNames.LineHints)
        {
            // Line reference
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Constraints references list
            Dependency.AddAttributeType(InterpreterNames.ReferenceList);
            // plane axis
            Dependency.AddAttributeType(InterpreterNames.Axis3D);

        }

        public override bool Execute()
        {
            if (Dependency[0].ReferenceBuilder.FunctionName != FunctionNames.LineTwoPoints)
                return false;
            var firstPoint = Dependency[0].ReferenceBuilder.Dependency[0].RefTransformedPoint3D;
            var secondPoint = Dependency[0].ReferenceBuilder.Dependency[1].RefTransformedPoint3D;
            if (firstPoint.IsEqual(secondPoint))
                return false;

            var wires = GetConstraintWires(firstPoint, secondPoint);
            if (wires.Count == 0)
                return false;
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

        private List<TopoDSWire> GetConstraintWires(Point3D firstPoint, Point3D secondPoint)
        {
            var axis2 = new gpAx2 { Axis = Dependency[2].TransformedAxis3D };
            var point3D = GeomUtils.ComputeMidPoint(firstPoint, secondPoint);
            var pointOnplane = point3D.ToPoint2D(axis2);

            var constraintTypes = GetConstraintTypes();


            var wires = new List<TopoDSWire>();
            var currentX = pointOnplane.X + 1;
            var currentY = pointOnplane.Y + 1;
            if (constraintTypes[2])
            {
                wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 1.5),
                         GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 1.5)));
                wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 1),
                         GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 1)));
                currentX += 1.5;
            }
            if (constraintTypes[3])
            {
                wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 1.5),
                               GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 1.5)));

                wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 0.5),
                               GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 1.5)));
                currentX += 1.5;
            }
            if (constraintTypes[0])
            {
                wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 2.5),
                               GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 2.5)));
                currentX += 1.5;
            }
            if (constraintTypes[1])
            {
                wires.Add(Wire(GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 0.5),
                    GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 1.5)));
                currentX += 1.5;
            }
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
            var constraintHints = new bool[] { false, false, false, false };
            var nodes = new List<Node>();
            for (int i = 0; i < Dependency[1].ReferenceList.Count;i++)
            {
                if (Dependency[1].ReferenceList[i].Node.Interpreters.Count == 0)
                {
                    //var index = Dependency[1].ReferenceList[i].Node.Index;
                    //var sketchNode = NodeBuilderUtils.FindSketchNode(Dependency[0].ReferenceBuilder.Node);
                    //var document = sketchNode.Root.Get<DocumentContextInterpreter>().Document;
                    //document.Root.Remove(index);
                    continue;
                }
                nodes.Add(Dependency[1].ReferenceList[i].Node);
            }
            foreach (var node in nodes)
            {
                switch (node.Get<FunctionInterpreter>().Name)
                {
                    case (Constraint2DNames.ParallelFunction):
                        constraintHints[2] = true;
                        break;
                    case (Constraint2DNames.PerpendicularFunction):
                        constraintHints[3] = true;
                        break;
                    case (Constraint2DNames.HorizontalFunction):
                        constraintHints[0] = true;
                        break;
                    case (Constraint2DNames.VerticalFunction):
                        constraintHints[1] = true;
                        break;
                }
            }
            return constraintHints;
        }
    }
}