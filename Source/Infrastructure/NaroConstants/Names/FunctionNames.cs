using System.Collections.Generic;

namespace NaroConstants.Names
{
    /// <summary>
    ///   Constants for function names.
    /// </summary>
    public static class FunctionNames
    {
        public const string WireTwoPoints = "WireTwoPoints";
        public const string LineHints = "LineHints";
        public const string PointHints = "PointHints";
        public const string TexturedShape = "TexturedShape";
        public const string LineTwoPoints = "Line";
        public const string DottedLine = "DottedLine";
        public const string LineMarker = "LineMarker";
        public const string SplinePath = "SplinePath";
        public const string ThreePointsRectangle = "RectangleThreePoints";
        public const string Paralleogram = "Paralleogram";
        public const string Sewing = "Sewing";
        public const string Evolved = "Evolved";
        public const string Box = "Box";
        public const string Box1P = "Box1p";
        public const string Arrow = "Arrow";
        public const string Arc = "Arc";
        public const string Arc3P = "Arc3p";
        public const string Boolean = "Boolean";
        public const string Circle = "Circle";
        public const string Ellipse = "Ellipse";
        public const string Cone = "Cone";
        public const string Cut = "Cut";
        public const string Cylinder = "Cylinder";
        public const string Extrude = "Extrude";
        public const string Fillet = "Fillet";
        public const string Fillet2D = "Fillet2D";
        public const string Mesh = "Mesh";
        public const string Polyline = "Polyline";
        public const string Point = "Point";
        public const string Rectangle = "Rectangle";
        public const string Sphere = "Sphere";
        public const string Spline = "Spline";
        public const string SubShape = "SubShape";
        public const string Torus = "Torus";
        public const string Face = "Face";
        public const string CircularPattern = "CircularPattern";
        public const string ArrayPattern = "ArrayPattern";
        public const string FixedSizeConstraint = "FixedSizeConstraint";
        public const string RangeSizeConstraint = "RangeSizeConstraint";
        public const string CoLocationConstraint = "CoLocationConstraint";
        public const string Pipe = "Pipe";
        public const string Plane = "Plane";
        public const string Revolve = "Revolve";
        public const string FaceFuse = "FaceFuse";
        public const string Dimension = "Dimension";
        public const string PointsDimension = "PointsDimension";
        public const string Offset = "Offset";
        public const string Offset3D = "Offset3D";
        public const string AngleDraft = "AngleDraft";
        public const string MirrorPoint = "MirrorPoint";
        public const string MirrorLine = "MirrorLine";
        public const string MirrorPlane = "MirrorPlane";
        public const string Trim = "Trim";
        public const string Extend = "Extend";
        public const string CircleRangeConstraint = "CircleRadiusConstraint";

        public const string RectangleWidthConstraint = "RectangleWidthConstraint";
        public const string RectangleHeightConstraint = "RectangleHeightConstraint";
        public const string LineLengthConstraint = "LineLengthConstraint";
        public const string EllipseMajorRadiusConstraint = "EllipseMajorRadiusConstraint";
        public const string EllipseMinorRadiusConstraint = "EllipseMinorRadiusConstraint";

        public const string BoxHeightConstraint = "BoxHeightConstraint";


        public const string EdgeDistanceConstraint = "EdgeDistanceConstraint";
        public const string PointToPointConstraint = "PointToPointConstraint";
        public const string PointToEdgeConstraint = "PointToEdgeConstraint";

        public const string DefineDrawingPlane = "DefineDrawingPlane";

        public const string SphereRadiusConstraint = "SphereRadiusConstraint";

        public const string TorusMajorRangeConstraint = "TorusMajorRangeConstraint";
        public const string TorusMinorRangeConstraint = "TorusMinorRangeConstraint";

        public const string ConeMinorRadiusConstraint = "ConeMinorRadiusConstraint";
        public const string ConeMajorRadiusConstraint = "ConeMajorRadiusConstraint";
        public const string ConeHeightConstraint = "ConeHeightConstraint";

        public const string CylinderHeightConstraint = "CylinderHeightConstraint";
        public const string CylinderRadiusConstraint = "CylinderRadiusConstraint";

        public const string ExtrudeHeightConstraint = "ExtrudeHeightConstraint";
        public const string CutHeightConstraint = "CutHeightConstraint";

        public const string VerticalLine = "VerticalLine";
        public const string HorizontalLine = "HorizontalLine";

        // Editing handles
        public const string BoxEditingHandle = "BoxEditingHandle";
        public const string ArrowEditingHandle = "ArrowEditingHandle";
        public const string AxisHandle = "AxisHandle";
        public const string PlaneHandle = "PlaneHandle";
        public const string TriangleHandle = "TriangleHandle";
        public const string CircleHandle = "CircleHandle";
        public const string Circle2DHandle = "Circle2DHandle";
        public const string Rectangle2DHandle = "Rectangle2DHandle";
        public const string Triangle2DHandle = "Triangle2DHandle";

        //Solver hint shapes
        public const string SolverPointMarker = "SolverPointMarker";
        public const string SolverLineMarker = "SolverLineMarker";

        public const string Sketch = "Sketch";

        public static IEnumerable<string> GetSolids()
        {
            yield return Sphere;
            yield return Cone;
            yield return Torus;
            yield return Cylinder;
            yield return Box;
            yield return Boolean;
            yield return Plane;
        }
        public static IEnumerable<string> GetSketchShapes()
        {
            yield return LineTwoPoints;
            yield return Point;
            yield return Spline;
            yield return SplinePath;
            yield return Rectangle;
            yield return Circle;
            yield return Ellipse;
            yield return Arc;
            yield return Arc3P;
            yield return ThreePointsRectangle;
       
        }
    }
}