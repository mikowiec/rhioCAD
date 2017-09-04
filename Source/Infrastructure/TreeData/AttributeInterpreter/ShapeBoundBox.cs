#region Usings

using System;
using NaroCppCore.Occ.Bnd;
using NaroCppCore.Occ.gp;


#endregion

namespace TreeData.AttributeInterpreter
{
    public class ShapeBoundBox
    {
        public Point3D Coordinate { get; set; }
        public Point3D Dimensions { get; set; }

        public BndBox BndBox
        {
            get
            {
                var result = new BndBox();
                result.Set(Coordinate.GpPnt, new gpDir(Dimensions.GpPnt.XYZ));
                return result;
            }
        }

        public ShapeBoundBox Combine(ShapeBoundBox boundBox)
        {
            var firstPoint = Coordinate;
            var lastPoint = boundBox.Coordinate;
            var minCoordinate = MinCoordinate(firstPoint, lastPoint);

            firstPoint = firstPoint.AddCoordinate(Dimensions);
            lastPoint = lastPoint.AddCoordinate(boundBox.Dimensions);
            var dimensions = ComputeDimensions(firstPoint, lastPoint, minCoordinate);
            return new ShapeBoundBox {Coordinate = minCoordinate, Dimensions = dimensions};
        }

        /// <summary>
        ///   Returns False if the boundBox intersects or is inside current
        /// </summary>
        public bool IsOut(ShapeBoundBox boundBox)
        {
            try
            {
                return BndBox.IsOut(boundBox.BndBox);
            }
            catch
            {
                return true;
            }
        }

        private static Point3D ComputeDimensions(Point3D firstPoint, Point3D lastPoint, Point3D minCoordinate)
        {
            var maxCoordinate = MaxCoordinate(firstPoint, lastPoint);
            return maxCoordinate.SubstractCoordinate(minCoordinate);
        }

        private static Point3D MinCoordinate(Point3D firstPoint, Point3D lastPoint)
        {
            var coordinateX = Math.Min(firstPoint.X, lastPoint.X);
            var coordinateY = Math.Min(firstPoint.Y, lastPoint.Y);
            var coordinateZ = Math.Min(firstPoint.Z, lastPoint.Z);
            return new Point3D(coordinateX, coordinateY, coordinateZ);
        }

        private static Point3D MaxCoordinate(Point3D firstPoint, Point3D lastPoint)
        {
            var coordinateX = Math.Max(firstPoint.X, lastPoint.X);
            var coordinateY = Math.Max(firstPoint.Y, lastPoint.Y);
            var coordinateZ = Math.Max(firstPoint.Z, lastPoint.Z);
            return new Point3D(coordinateX, coordinateY, coordinateZ);
        }
    }
}