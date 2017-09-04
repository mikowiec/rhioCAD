using Naro.Infrastructure.Interface;
using System;
using Naro.Infrastructure.Interface.Constants;
using Naro.Infrastructure.Interface.Naming;
using Naro.OCAFDrivers.Algo;
using OCNaroWrappers;
using TreeData.Functions;
using TreeData.NaroData;
using Naro.OCAFDrivers;

namespace NaroTestSuite.OccNoViewTests
{
	/// <summary>
	/// Contains a fast shape for most common of them
	/// </summary>
	public static class TestShapes
	{

		public static Node CreateLine(Node node, OCgp_Pnt point1, OCgp_Pnt point2)
		{
		    var result = TreeUtils.AddLineToNode(node, point1, point2);
		    return result;
		}

		public static Node CreateRectangle(Node node, OCgp_Pnt point1, OCgp_Pnt point2, OCgp_Pnt point3)
		{
		    TreeUtils.AddRectangleToNode(node, point1, point2, point3);
		    return node;
		}

		public static Node CreateEllipse(Node node, OCgp_Pnt point1, OCgp_Pnt point2, OCgp_Pnt point3)
		{
		    TreeUtils.AddEllipseToNode(node, point1, point2, point3);
		    return node;
		}
		
        public static Node CreateCircle(Node node, OCgp_Ax1 centerAxis, double radius)
        {
            TreeUtils.AddCircleToNode(node, centerAxis, radius);
            return node;
        }

		public static Node CreateSubShape(Node parentNode, Node referedShape, int face)
		{
            var builder = new NodeBuilder(parentNode, FunctionNames.SubShape);
            var node = builder.Node;

            builder.Dependency.Child(0).Reference = referedShape;
            builder.Dependency.Child(1).Integer = face;
            builder.Dependency.Child(2).Integer = 0;

            builder.ExecuteFunction();
		    return node;
		}

        public static Node CreateSphere(Node node, OCgp_Pnt center, double radius)
        {
            return Features.AddSphere(node, center, radius);
        }

        public static Node CreateBox(Node parentNode, OCgp_Ax1 axis, double dx, double dy, double dz)
        {
            return Features.AddBox(parentNode, axis, dx, dy, dz);
        }

        public static void CreateBoolean(Node node, Node shape1, Node shape2, int operation)
        {
            Features.AddBoolean(node, shape1, shape2, operation);
        }

        public static Node CreateCylinder(Node node, OCgp_Ax1 centerAxis, double radius, double height, double angle)
        {
            return Features.AddCylinder(node, centerAxis, radius, height, angle);
        }

        public static void CreateCone(Node node, OCgp_Ax1 centerAxis, double radius1, double radius2, double height, double angle)
        {
            Features.AddCone(node, centerAxis, radius1, radius2, height, angle);
        }

        public static void CreateTorus(Node node, OCgp_Ax1 centerAxis, double radius1, double radius2, double angle1, double angle2, double angle)
        {
            Features.AddTorus(node, centerAxis, radius1, radius2, angle1, angle2, angle);
        }

	    public static void CreateExtrude(Node node, Node referedShape, double height, ExtrusionTypes type)
		{
		    Features.Extrude(node, referedShape, height, ExtrusionTypes.ToDepth);
		}

		public static void CreateFillet(Node node, Node referedShape, double size)
		{
            Features.Fillet(node, referedShape, size);
		}

        public static Node CreateCut(Node node, Node referedShape, double height, CutTypes type)
        {
            return Features.Cut(node, referedShape, height, type);
        }
	}
}
