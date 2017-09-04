#region Usings

using System.Drawing;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using OccCode;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using NaroCppCore.Occ.Precision;

#endregion

namespace InteractiveEditor.GizmoHandlers
{
    public class RotateAxisHandler : GenericEditingShapeHandler
    {
        //private static readonly ILog Log = LogManager.GetLogger(typeof (RotateAxisHandler));
        private Point3D? _initialDraggingPosition;
        private double _previousAngle;

        public override int EditingPointsCount()
        {
            return 3;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            return FunctionNames.CircleHandle;
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
                default:
                    return Color.Red;
            }
        }

        public override gpAx2 GetPointLocation(int index)
        {
            var gizmoOrientation = new gpAx2();
            var nodeBuilder = new NodeBuilder(Node);

            var gravityCenter = GeomUtils.ExtractGravityCenter(nodeBuilder.Shape);

            switch (index)
            {
                case 0:
                    gizmoOrientation.Direction = gp.OX.Direction;
                    gizmoOrientation.XDirection = gp.OY.Direction;
                    break;
                case 1:
                    gizmoOrientation.Direction = gp.OY.Direction.Reversed;
                    gizmoOrientation.XDirection = gp.OZ.Direction;
                    break;
                case 2:
                    gizmoOrientation.Direction=gp.OZ.Direction.Reversed;
                    gizmoOrientation.XDirection=gp.OX.Direction;
                    break;
                default:
                    return null;
            }

            gizmoOrientation.Location = gravityCenter.GpPnt;
            return gizmoOrientation;
        }


        public override void StartDragging(Node handleNode)
        {
            base.StartDragging(handleNode);
            _initialDraggingPosition = null;
            _previousAngle = 0;
        }

        private void InitializeDragging(Mouse3DPosition vertex, TransformationInterpreter trsfInterpreter)
        {
            _initialDraggingPosition = new Point3D(vertex.Point.GpPnt);
            var nodeBuilder = new NodeBuilder(Node);
            var gravityCenter = GeomUtils.ExtractGravityCenter(nodeBuilder.Shape);
            trsfInterpreter.Pivot = gravityCenter.GpPnt;
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            var trsfInterpreter = Node.Set<TransformationInterpreter>();
            if (_initialDraggingPosition == null)
            {
                InitializeDragging(vertex, trsfInterpreter);
            }
            //Log.DebugFormat("@pivot {0} {1} {2}", trsfInterpreter.Pivot.X(), trsfInterpreter.Pivot.Y(), trsfInterpreter.Pivot.Z());

            var rotate = new gpPnt(0, 0, 0);
            var startDraggingVector = new gpVec(trsfInterpreter.Pivot, _initialDraggingPosition.Value.GpPnt);
            if (startDraggingVector.Magnitude <= gp.Resolution)
                return;
            var currentDraggingVector = new gpVec(trsfInterpreter.Pivot, vertex.Point.GpPnt);
            if (currentDraggingVector.Magnitude <= gp.Resolution)
                return;
            var currentGizmo = GetPointLocation(index);
            var rotationAxis = currentGizmo.Direction;

            if (rotationAxis.IsParallel(gp.OX.Direction, Precision.Angular))
            {
                var rotationAngle =
                    startDraggingVector.AngleWithRef(currentDraggingVector, new gpVec(gp.OX.Direction)) -
                    _previousAngle;
                _previousAngle = startDraggingVector.AngleWithRef(currentDraggingVector,
                                                                  new gpVec(gp.OX.Direction));
                rotate.X = GeomUtils.RadiansToDegrees(rotationAngle);
            }
            else if (rotationAxis.IsParallel(gp.OY.Direction, Precision.Angular))
            {
                var rotationAngle =
                    startDraggingVector.AngleWithRef(currentDraggingVector, new gpVec(gp.OY.Direction)) -
                    _previousAngle;
                _previousAngle = startDraggingVector.AngleWithRef(currentDraggingVector,
                                                                  new gpVec(gp.OY.Direction));
                rotate.Y = GeomUtils.RadiansToDegrees(rotationAngle);
            }
            else if (rotationAxis.IsParallel(gp.OZ.Direction, Precision.Angular))
            {
                var rotationAngle =
                    startDraggingVector.AngleWithRef(currentDraggingVector, new gpVec(gp.OZ.Direction)) -
                    _previousAngle;
                _previousAngle = startDraggingVector.AngleWithRef(currentDraggingVector,
                                                                  new gpVec(gp.OZ.Direction));
                rotate.Z = GeomUtils.RadiansToDegrees(rotationAngle);
            }
            //Log.DebugFormat("@rotation angle {0}", GeomUtils.RadiansToDegrees(rotationAngle));

            trsfInterpreter.Rotate = rotate;
        }
    }
}