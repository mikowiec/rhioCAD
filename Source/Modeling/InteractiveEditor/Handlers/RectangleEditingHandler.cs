#region Usings

using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using OccCode;

using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using NaroCppCore.Occ.Precision;

#endregion

namespace InteractiveEditor.Handlers
{
    public class RectangleEditingHandler : GenericEditingShapeHandler
    {
        private const int DistanceToObject = 1;
        private gpDir _secondPointProjectionDirection;

        public override int EditingPointsCount()
        {
            return 6;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            return index <= 1 ? FunctionNames.BoxEditingHandle : FunctionNames.ArrowEditingHandle;
        }

        // The rectangle is like the following:
        //   vertex2------vertex3
        //   vertex1------vertex4
        public override gpAx2 GetPointLocation(int index)
        {
            var firstPoint = Dependency[0].TransformedPoint3D;
            var secondPoint = Dependency[1].TransformedPoint3D;
            var thirdPoint = Dependency[2].TransformedPoint3D;

            var vectorV2V1 = new gpVec(secondPoint.GpPnt, firstPoint.GpPnt);
            var vectorV2V3 = new gpVec(secondPoint.GpPnt, thirdPoint.GpPnt);
            var rectangleNormalVector = vectorV2V1.Crossed(vectorV2V3);
            var rectangleNormalDirection = new gpDir(rectangleNormalVector);

            var rectangleCenter = new gpPnt((firstPoint.X + thirdPoint.X)/2, (firstPoint.Y + thirdPoint.Y)/2,
                                               (firstPoint.Z + thirdPoint.Z)/2);
            vectorV2V3.Normalize();
            vectorV2V1.Normalize();
            vectorV2V3.Multiply(DistanceToObject);
            vectorV2V1.Multiply(DistanceToObject);

            var leftArrowVector = vectorV2V3.Reversed;
            var leftArrowMidPoint = GeomUtils.ComputeMidPoint(firstPoint, secondPoint);
            var leftArrowPoint = GeomUtils.BuildTranslation(leftArrowMidPoint, leftArrowVector);
            var leftArrowAxis = new gpAx2(leftArrowPoint.GpPnt, rectangleNormalDirection)
                                    {XDirection = (new gpDir(leftArrowVector))};

            var topArrowVector = vectorV2V1.Reversed;
            var topArrowMidPoint = GeomUtils.ComputeMidPoint(secondPoint, thirdPoint);
            var topArrowPoint = GeomUtils.BuildTranslation(topArrowMidPoint, topArrowVector);
            var topArrowAxis = new gpAx2(topArrowPoint.GpPnt, rectangleNormalDirection);
            topArrowAxis.XDirection = (new gpDir(topArrowVector));

            var bottomArrowPoint = new gpPnt(2*rectangleCenter.X - topArrowPoint.X,
                                                2*rectangleCenter.Y - topArrowPoint.Y,
                                                2*rectangleCenter.Z - topArrowPoint.Z);
            var bottomArrowAxis = new gpAx2(bottomArrowPoint, rectangleNormalDirection);
            bottomArrowAxis.XDirection = (new gpDir(topArrowVector.Reversed));

            var rightArrowPoint = new gpPnt(2*rectangleCenter.X - leftArrowPoint.X,
                                               2*rectangleCenter.Y - leftArrowPoint.Y,
                                               2*rectangleCenter.Z - leftArrowPoint.Z);
            var rightArrowAxis = new gpAx2(rightArrowPoint, rectangleNormalDirection);
            rightArrowAxis.XDirection = new gpDir(leftArrowVector.Reversed);

            var pointLocation = new gpAx2();
            pointLocation.Direction = rectangleNormalDirection;

            switch (index)
            {
                case 0:
                    pointLocation.Location = (firstPoint.GpPnt);
                    pointLocation.XDirection = (new gpDir(vectorV2V3));
                    return pointLocation;
                case 1:
                    pointLocation.Location = (thirdPoint.GpPnt);
                    pointLocation.XDirection = (new gpDir(vectorV2V3));
                    return pointLocation;
                case 2:
                    return leftArrowAxis;
                case 3:
                    return topArrowAxis;
                case 4:
                    return rightArrowAxis;
                case 5:
                    return bottomArrowAxis;
                default:
                    return null;
            }
        }

        public override void StartDragging(Node handleNode)
        {
            _secondPointProjectionDirection = null;
            base.StartDragging(handleNode);
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            var firstPoint = Dependency[0].TransformedPoint3D;
            var secondPoint = Dependency[1].TransformedPoint3D;
            var thirdPoint = Dependency[2].TransformedPoint3D;

            if (firstPoint.IsEqual(vertex.Point) || secondPoint.IsEqual(vertex.Point) ||
                thirdPoint.IsEqual(vertex.Point))
            {
                return;
            }

            if (firstPoint.IsEqual(new Point3D(0, 0, 0)))
            {
                var projectionOnP1P2 = GeomUtils.ProjectPointOnLine(firstPoint,
                                                                    new gpDir(new gpVec(firstPoint.GpPnt,
                                                                                              secondPoint.GpPnt)),
                                                                    vertex.Point);
                if (projectionOnP1P2 != null)
                {
                    if (projectionOnP1P2.Value.Distance(firstPoint) < Precision.Confusion)
                    {
                        return;
                    }
                }
                var projectionOnP2P3 = GeomUtils.ProjectPointOnLine(secondPoint,
                                                                    new gpDir(new gpVec(secondPoint.GpPnt,
                                                                                              thirdPoint.GpPnt)),
                                                                    vertex.Point);
                if (projectionOnP2P3 != null)
                {
                    if (projectionOnP2P3.Value.Distance(secondPoint) < Precision.Confusion)
                    {
                        return;
                    }
                }
            }

            var vectorV2V1 = new gpVec(secondPoint.GpPnt, firstPoint.GpPnt);
            var vectorV2V3 = new gpVec(secondPoint.GpPnt, thirdPoint.GpPnt);
            if (vectorV2V1.IsParallel(vectorV2V3, Precision.Angular))
            {
                return;
            }

            var rectangleNormalVector = vectorV2V1.Crossed(vectorV2V3);
            if (rectangleNormalVector.Magnitude < Precision.Confusion)
            {
                return;
            }

            switch (index)
            {
                case 0:
                    SetFirstPointDraggingHandle(thirdPoint, vertex);
                    break;
                case 1:
                    SetSecondPointDraggingHandle(vectorV2V1, vertex, secondPoint);
                    break;
                case 2:
                    SetLeftArrowDraggingHandle(firstPoint, vertex, thirdPoint);
                    break;
                case 3:
                    SetTopArrowDraggingHandle(thirdPoint, vertex, firstPoint);
                    break;
                case 4:
                    SetRightArrowDraggingHandle(vertex);
                    break;
                case 5:
                    SetBottomArrowDraggingHandle(firstPoint, vertex);
                    break;
            }
        }

        private void SetBottomArrowDraggingHandle(Point3D firstPoint, Mouse3DPosition vertex)
        {
            var firstRectanglePoint = GetPointLocation(0);
            var projectionDragging = GeomUtils.ProjectPointOnLine(firstPoint, firstRectanglePoint.YDirection,
                                                                  vertex.Point);
            var sPoint = Dependency[1].TransformedPoint3D;
            var tPoint = Dependency[2].TransformedPoint3D;
            Dependency[0].TransformedPoint3D = (Point3D) projectionDragging;
            Dependency[1].TransformedPoint3D = sPoint;
            Dependency[2].TransformedPoint3D = tPoint;
        }

        private void SetRightArrowDraggingHandle(Mouse3DPosition vertex)
        {
            var thirdRectanglePoint = GetPointLocation(1);
            var projectionDragging = GeomUtils.ProjectPointOnLine(
                new Point3D(thirdRectanglePoint.Location), thirdRectanglePoint.XDirection,
                vertex.Point);
            Dependency[2].TransformedPoint3D = (Point3D) projectionDragging;
        }

        private void SetTopArrowDraggingHandle(Point3D thirdPoint, Mouse3DPosition vertex, Point3D firstPoint)
        {
            var thirdRectanglePoint = GetPointLocation(1);
            var firstRectanglePoint = GetPointLocation(0);
            var thirdPointProjectionDragging = GeomUtils.ProjectPointOnLine(thirdPoint, thirdRectanglePoint.YDirection,
                                                                            vertex.Point);
            var secondPointProjectionDragging = GeomUtils.ProjectPointOnLine(firstPoint,
                                                                             firstRectanglePoint.YDirection,
                                                                             vertex.Point);
            Dependency[2].TransformedPoint3D = (Point3D) thirdPointProjectionDragging;
            Dependency[1].TransformedPoint3D = (Point3D) secondPointProjectionDragging;
        }

        private void SetLeftArrowDraggingHandle(Point3D firstPoint, Mouse3DPosition vertex, Point3D thirdPoint)
        {
            var thirdRectanglePoint = GetPointLocation(1);
            var firstRectanglePoint = GetPointLocation(0);
            var firstPointProjectionDragging = GeomUtils.ProjectPointOnLine(firstPoint, firstRectanglePoint.XDirection,
                                                                            vertex.Point);
            var secondPointProjectionDragging = GeomUtils.ProjectPointOnLine(thirdPoint,
                                                                             thirdRectanglePoint.XDirection,
                                                                             vertex.Point);
            var tPoint = Dependency[2].TransformedPoint3D;
            Dependency[0].TransformedPoint3D = (Point3D) firstPointProjectionDragging;
            Dependency[1].TransformedPoint3D = (Point3D) secondPointProjectionDragging;
            Dependency[2].TransformedPoint3D = tPoint;
        }

        private void SetSecondPointDraggingHandle(gpVec vectorV2V1, Mouse3DPosition vertex, Point3D secondPoint)
        {
            if (_secondPointProjectionDirection == null)
            {
                _secondPointProjectionDirection = new gpDir(vectorV2V1);
            }
            var secondPointProjectionPlane = new gpPln(vertex.Point.GpPnt, _secondPointProjectionDirection);
            var secondProjectedPoint = GeomUtils.ProjectPointOnPlane(secondPoint.GpPnt, secondPointProjectionPlane,
                                                                     Precision.Confusion);
            Dependency[1].TransformedPoint3D = new Point3D(secondProjectedPoint);
            Dependency[2].TransformedPoint3D = vertex.Point;
        }

        private void SetFirstPointDraggingHandle(Point3D thirdPoint, Mouse3DPosition vertex)
        {
            var thirdRectanglePoint = GetPointLocation(1);
            var secondPointProjectionDragging = GeomUtils.ProjectPointOnLine(thirdPoint,
                                                                             thirdRectanglePoint.XDirection,
                                                                             vertex.Point);
            var tPoint = Dependency[2].TransformedPoint3D;
            Dependency[0].TransformedPoint3D = vertex.Point;
            Dependency[1].TransformedPoint3D = (Point3D) secondPointProjectionDragging;
            Dependency[2].TransformedPoint3D = tPoint;
        }
    }
}