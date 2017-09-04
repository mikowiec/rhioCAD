#region Usings

using System.Collections.Generic;
using OccCode;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.UI.Views.Rendering
{
    public class TriangleMesh
    {
        public TriangleMesh()
        {
            Points = new List<Point3D>();
            Triangles = new List<TriangleIds>();
        }

        public List<Point3D> Points { get; set; }
        public List<TriangleIds> Triangles { get; private set; }

        public void AddTriangle(int[] pointIndexes)
        {
            var triangle = new TriangleIds {V1 = pointIndexes[0], V2 = pointIndexes[1], V3 = pointIndexes[2]};
            Triangles.Add(triangle);
        }

        public int ComputePointId(Point3D pointFrom)
        {
            if (Points.Count == 0)
                return -1;
            var min = 0;
            var max = Points.Count - 1;
            int mid;
            Point3D pointMid;
            do
            {
                mid = (min + max)/2;
                pointMid = Points[mid];
                if (false == GeomUtils.PointComparer.IsGreater(pointMid, pointFrom))
                    min = mid + 1;
                else
                    max = mid - 1;
            } while (!pointMid.IsEqual(pointFrom) && (min <= max));
            if (pointMid.IsEqual(pointFrom))
                return mid;
            return -1;
        }

        public TriangleMesh Combine(TriangleMesh combineWith)
        {
            var result = new TriangleMesh();
            foreach (var point in Points)
                result.Points.Add(point);
            foreach (var point in combineWith.Points)
                result.Points.Add(point);

            foreach (var triangle in Triangles)
                result.Triangles.Add(triangle);
            var baseIndex = Points.Count;
            foreach (var triangle in combineWith.Triangles)
            {
                triangle.V1 += baseIndex;
                triangle.V2 += baseIndex;
                triangle.V3 += baseIndex;
                result.Triangles.Add(triangle);
            }
            return result;
        }
    }
}