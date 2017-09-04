#region Usings

using System;
using System.Drawing;
using System.Windows.Media.Media3D;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Bnd;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopExp;
using NaroCppCore.Occ.TopoDS;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace TreeData.AttributeInterpreter
{
    public static class ShapeUtils
    {
        public static bool HasShape(Node node)
        {
            var interpreter = node.Get<TopoDsShapeInterpreter>();
            if (interpreter == null)
                return false;
            return interpreter.Shape != null;
        }

        public static gpTrsf ExtractPlaneMirrorTransform(gpPln plane)
        {
            var transform = new gpTrsf();
            transform.SetMirror(plane.Position.Ax2);
            return transform;
        }

        public static gpPln ExtractPlaneFromFaceShape(TopoDSShape targetFace)
        {
            var face = TopoDS.Face(targetFace);
            var surf = BRepTool.Surface(face);
            var pl = new GeomPlane(new gpAx3());
            pl = surf.Convert<GeomPlane>();
            //surf.DownCast(ref pl);
            var faceElementAdaptor = new BRepAdaptorSurface(face, true);
            //TO DO: Investigate why this is not working
            Ensure.AreEqual(faceElementAdaptor.GetType, GeomAbsSurfaceType.GeomAbs_Plane);
            return pl.Pln;
        }

        public static BndBox ExtractBndBox(TopoDSShape topoDsShape)
        {
            var shape = new AISShape(topoDsShape);
            try
            {
                var bndBox = shape.BoundingBox;

                return bndBox;
            }
            catch
            {
                return null;
            }
        }

        public static ShapeBoundBox ExtractBoundingBox(TopoDSShape topoDsShape)
        {
            if (topoDsShape == null)
                return null;

            var bndBox = ExtractBndBox(topoDsShape);
            if (bndBox == null)
                return null;
            var aXMin = 0d;
            var aYMin = 0d;
            var aZMin = 0d;
            var aXMax = 0d;
            var aYMax = 0d;
            var aZMax = 0d;
            bndBox.Get(ref aXMin, ref aYMin, ref aZMin, ref aXMax, ref aYMax, ref aZMax);
            var coordinate = new Point3D(aXMin, aYMin, aZMin);
            var dimensions = new Point3D(aXMax - aXMin, aYMax - aYMin, aZMax - aZMin);
            var result = new ShapeBoundBox {Coordinate = coordinate, Dimensions = dimensions};
            return result;
        }

        public static TopoDSShape ExtractShape(Node node)
        {
            var topoDsShapeInterpreter = node == null ? null : node.Get<TopoDsShapeInterpreter>();
            return topoDsShapeInterpreter == null ? null : topoDsShapeInterpreter.Shape;
        }

        public static TopoDSShape ExtractSubShape(
            Node nodeShape,
            int facePosition,
            TopAbsShapeEnum shapeType)
        {
            return ExtractSubShape(ExtractShape(nodeShape), facePosition, shapeType);
        }

        public static TopoDSShape ExtractSubShape(SceneSelectedEntity sceneSelectedEntity)
        {
            return ExtractSubShape(sceneSelectedEntity.Node,
                                   sceneSelectedEntity.ShapeCount,
                                   sceneSelectedEntity.ShapeType);
        }

        public static TopoDSShape ExtractSubShape(
            TopoDSShape originalShape,
            int facePosition,
            TopAbsShapeEnum shapeType)
        {
            if (originalShape == null)
                return null;
            // Find the face
            var baseEx = new TopExpExplorer();
            baseEx.Init(originalShape, shapeType, TopAbsShapeEnum.TopAbs_SHAPE);

            while (baseEx.More && (facePosition != 1))
            {
                baseEx.Next();
                facePosition--;
            }
            //if (!baseEx.More())
            //    return null;
            TopoDSShape shape = null;
            switch (shapeType)
            {
                case TopAbsShapeEnum.TopAbs_VERTEX:
                    shape = TopoDS.Vertex(baseEx.Current);
                    break;
                case TopAbsShapeEnum.TopAbs_EDGE:
                    shape = TopoDS.Edge(baseEx.Current);
                    break;
                case TopAbsShapeEnum.TopAbs_WIRE:
                    shape = TopoDS.Wire(baseEx.Current);
                    break;
                case TopAbsShapeEnum.TopAbs_FACE:
                    shape = TopoDS.Face(baseEx.Current);
                    break;
                case TopAbsShapeEnum.TopAbs_SOLID:
                case TopAbsShapeEnum.TopAbs_COMPOUND:
                    return originalShape;
            }
            return shape;
        }

        public static gpPnt ExtractShapesPoint(TopoDSShape shape, int pointIndex)
        {
            return ConvertShapeToPoint(ExtractSubShape(shape, pointIndex, TopAbsShapeEnum.TopAbs_VERTEX));
        }

        public static gpPnt ExtractShapesPoint(Node shape, int pointIndex)
        {
            return ConvertShapeToPoint(ExtractSubShape(shape, pointIndex, TopAbsShapeEnum.TopAbs_VERTEX));
        }

        public static gpPnt ConvertShapeToPoint(TopoDSShape shape)
        {
            return shape == null ? null : BRepTool.Pnt(TopoDS.Vertex(shape));
        }

        public static bool IsPlanarFace(TopoDSShape shape)
        {
            TopoDSFace face;
            try
            {
                if ((shape.IsNull) || (shape.ShapeType != TopAbsShapeEnum.TopAbs_FACE))
                {
                    return false;
                }
                face = TopoDS.Face(shape);
            }
            catch
            {
                return false;
            }
            var aFaceElementAdaptor = new BRepAdaptorSurface(face, true);
            var surfaceType = aFaceElementAdaptor.GetType;
            return (surfaceType == GeomAbsSurfaceType.GeomAbs_Plane);
        }

        public static QuantityColor GetOccColor(Color col)
        {
            var color = new QuantityColor();
            var r = col.R/255.0;
            var g = col.G/255.0;
            var b = col.B/255.0;
            color.SetValues(r, g, b, QuantityTypeOfColor.Quantity_TOC_RGB);
            return color;
        }

        public static Color FromWpfColor(System.Windows.Media.Color color)
        {
            return Color.FromArgb(color.R, color.G, color.B);
        }

        public static System.Windows.Media.Color ToWpfColor(Color color)
        {
            return System.Windows.Media.Color.FromRgb(color.R, color.G, color.B);
        }

        public static Color ComputeRandomColor()
        {
            var random = new Random();
            var r = (byte) random.Next(255);
            var g = (byte) random.Next(255);
            var b = (byte) random.Next(255);
            return Color.FromArgb(r, g, b);
        }


        public static Vector3D PointToVector(gpPnt point)
        {
            var direction = point.XYZ;
            var result = new Vector3D(direction.X, direction.Y, direction.Z);

            return result;
        }

        public static Vector3D AxisToVector(gpAx1 axis)
        {
            var direction = axis.Direction.XYZ;
            var result = new Vector3D(direction.X, direction.Y, direction.Z);

            return result;
        }
    }
}