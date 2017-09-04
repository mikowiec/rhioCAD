#region Usings

using System.Drawing;
using log4net;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using OccCode;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;

#endregion

namespace InteractiveEditor.GizmoHandlers
{
    public class ScaleAxisHandler : GenericEditingShapeHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (ScaleAxisHandler));
        private Point3D? _previousDraggingPosition;

        public override int EditingPointsCount()
        {
            return 6;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            return index <= 2 ? FunctionNames.AxisHandle : FunctionNames.TriangleHandle;
        }

        public override Color GetHandleColor(int index)
        {
            switch (index)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.DarkGreen;
                case 2:
                    return Color.Blue;
                case 3:
                    return Color.Red;
                case 4:
                    return Color.DarkGreen;
                case 5:
                    return Color.Blue;
                default:
                    return Color.Red;
            }
        }

        public override gpAx2 GetPointLocation(int index)
        {
            var gizmoOrientation = new gpAx2();
            switch (index)
            {
                case 0:
                    gizmoOrientation.Direction = (gp.OZ.Direction);
                    gizmoOrientation.XDirection = (gp.OX.Direction);
                    break;
                case 1:
                    gizmoOrientation.Direction = (gp.OZ.Direction.Reversed);
                    gizmoOrientation.XDirection = (gp.OY.Direction);
                    break;
                case 2:
                    gizmoOrientation.Direction =(gp.OX.Direction.Reversed);
                    gizmoOrientation.XDirection=(gp.OZ.Direction);
                    break;
                case 3:
                    gizmoOrientation.Direction = (gp.OZ.Direction);
                    gizmoOrientation.XDirection = (gp.OX.Direction);
                    break;
                case 4:
                    gizmoOrientation.Direction = (gp.OX.Direction);
                    gizmoOrientation.XDirection=(gp.OY.Direction);
                    break;
                case 5:
                    gizmoOrientation.Direction=(gp.OY.Direction);
                    gizmoOrientation.XDirection=(gp.OZ.Direction);
                    break;
                default:
                    return null;
            }

            gizmoOrientation.Location = (Node.Set<TransformationInterpreter>().Translate);
            return gizmoOrientation;
        }

        public override void StartDragging(Node handleNode)
        {
            base.StartDragging(handleNode);
            _previousDraggingPosition = null;
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            var handle = GetPointLocation(index);
            var handlerDirection = handle.XDirection;
            var trsfInterpreter = Node.Set<TransformationInterpreter>();

            if (_previousDraggingPosition == null)
            {
                var projectedInitial = GeomUtils.ProjectPointOnLine(new Point3D(handle.Location), handlerDirection,
                                                                    vertex.Point);
                _previousDraggingPosition = new Point3D(projectedInitial.Value.GpPnt);
                return;
            }

            var projectedVertex = GeomUtils.ProjectPointOnLine(_previousDraggingPosition.Value, handlerDirection,
                                                               vertex.Point);
            var increase = true;
            if (handlerDirection.IsParallel(gp.OX.Direction, Precision.Angular))
            {
                if (projectedVertex.Value.X < _previousDraggingPosition.Value.X)
                {
                    increase = false;
                }
            }
            else if (handlerDirection.IsParallel(gp.OY.Direction, Precision.Angular))
            {
                if (projectedVertex.Value.Y < _previousDraggingPosition.Value.Y)
                {
                    increase = false;
                }
            }
            else if (handlerDirection.IsParallel(gp.OZ.Direction, Precision.Angular))
            {
                if (projectedVertex.Value.Z < _previousDraggingPosition.Value.Z)
                {
                    increase = false;
                }
            }

            var scaleAmount = 0.03;
            if (increase)
            {
                trsfInterpreter.Scale = 1 + scaleAmount;
            }
            else
            {
                trsfInterpreter.Scale = 1 - scaleAmount;
            }
            _previousDraggingPosition = projectedVertex;
        }
    }
}