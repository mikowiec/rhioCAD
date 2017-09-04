#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.OccNoViewTests
{
    /// <summary>
    ///   Contains a fast shape for most common of them
    /// </summary>
    public static class TestShapes
    {
        public static Node CreateLine(Document document, Point3D point1, Point3D point2)
        {
            var result = TreeUtils.AddLineToNode(document, point1, point2);
            return result.Node;
        }

        //public static Node CreateRectangle(Document document, Point3D point1, Point3D point2, gpDir direction)
        //{
        //   return TreeUtils.AddRectangleToNode(document, point1, point2, direction).Node;
        //}

        public static Node CreateEllipse(Document document, Point3D point1, Point3D point2, Point3D point3)
        {
            return TreeUtils.AddEllipseToNode(document, point1, point2, point3);
        }

        public static Node CreateCircle(Document document, Point3D coordinate, double radius)
        {
            return TreeUtils.AddCircleToNode(document, coordinate, radius);
        }

        public static Node CreateSubShape(Document document, Node referedShape, int face)
        {
            var builder = new NodeBuilder(document, FunctionNames.SubShape);
            var node = builder.Node;

            builder[0].Reference = referedShape;
            builder[1].Integer = face;
            builder[2].Integer = 0;

            builder.ExecuteFunction();
            return node;
        }

        public static Node CreateSphere(Document document, Point3D center, double radius)
        {
            return TreeUtils.AddSphere(document, center, radius);
        }

        public static Node CreateBox(Document document, gpAx1 axis, Point3D p3, double height)
        {
            return TreeUtils.AddBox(document, axis, p3, height);
        }

        public static void CreateBoolean(Document document, Node shape1, Node shape2, int operation)
        {
            TreeUtils.AddBoolean(document, shape1, shape2, operation);
        }

        public static Node CreateCylinder(Document document, gpAx1 centerAxis, double radius, double height,
                                          double angle)
        {
            return TreeUtils.AddCylinder(document, centerAxis, radius, height, angle);
        }

        public static void CreateCone(Document document, gpAx1 centerAxis, double radius1, double radius2,
                                      double height, double angle)
        {
            TreeUtils.AddCone(document, centerAxis, radius1, radius2, height, angle);
        }

        public static void CreateTorus(Document document, gpAx1 centerAxis, double radius1, double radius2)
        {
            TreeUtils.AddTorus(document, centerAxis, radius1, radius2);
        }

        public static Node CreateExtrude(Document document, SceneSelectedEntity referedShape, double height)
        {
            return TreeUtils.Extrude(document, referedShape, height, ExtrusionTypes.ToDepth).Node;
        }

        public static void CreateFillet(Document document, Node referedShape, int edge, double size)
        {
            TreeUtils.Fillet(document, referedShape, edge, size);
        }

        public static Node CreateCut(Document document, Node referedShape, double height, CutTypes type)
        {
            return TreeUtils.Cut(document, referedShape, height, type);
        }
    }
}