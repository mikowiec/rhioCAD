#region Usings

using System.Collections.Generic;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepMesh;
using NaroCppCore.Occ.Poly;
using NaroCppCore.Occ.TColgp;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopExp;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.TopoDS;
using OccCode;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.UI.Views.Rendering
{
    public static class Triangulation
    {
        public static TriangleMesh Process(TopoDSShape shapeFused)
        {
            var result = new TriangleMesh();
            var builder = new BRepBuilder();
            var comp = new TopoDSCompound();
            builder.MakeCompound(comp);
            BRepMesh.Mesh(shapeFused, 1);
            var ex = new TopExpExplorer(shapeFused,
                                           TopAbsShapeEnum.TopAbs_FACE,
                                           TopAbsShapeEnum.TopAbs_SHAPE);
            while (ex.More)
            {
                var shapeResult = new TriangleMesh();
                var face = TopoDS.Face(ex.Current);
                var location = new TopLocLocation();
                var facing = BRepTool.Triangulation(face, location);
                var tab = new TColgpArray1OfPnt(1, facing.NbNodes);
              //  facing.Nodes(tab);
                var tri = new PolyArray1OfTriangle(1, facing.NbTriangles);
              //  facing.Triangles(tri);
                var triCount = facing.NbTriangles;
                var listPoints = new List<Point3D>();
                for (var i = 1; i <= triCount; i++)
                {
                    var trian = tri.Value(i);
                    int index1 = 0, index2 = 0, index3 = 0;
                    trian.Get(ref index1, ref index2, ref index3);

                    var firstPoint = new Point3D(tab.Value(index1));
                    var secondPoint = new Point3D(tab.Value(index2));
                    var thirdPoint = new Point3D(tab.Value(index3));
                    listPoints.Add(firstPoint);
                    listPoints.Add(secondPoint);
                    listPoints.Add(thirdPoint);
                }
                shapeResult.Points.Clear();
                foreach (var point in listPoints)
                    shapeResult.Points.Add(point);
                shapeResult.Points = GeomUtils.SortAndCompactListPoints(shapeResult.Points);
                var triangleIndex = 0;
                var triangleArray = new int[3];
                foreach (var point in listPoints)
                {
                    triangleArray[triangleIndex] = shapeResult.ComputePointId(point);
                    triangleIndex = (triangleIndex + 1)%3;
                    if (triangleIndex == 0)
                        shapeResult.AddTriangle(triangleArray);
                }
                ex.Next();
                result = result.Combine(shapeResult);
            }
            return result;
        }
    }
}