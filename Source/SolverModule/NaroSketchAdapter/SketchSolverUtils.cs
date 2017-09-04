#region Usings

using ConstraintsModule.Primitives;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchAdapter
{
    public static class SketchSolverUtils
    {
        public static double Distance(Point p1, Point p2)
        {
            return new Point3D(p1.X.Value, p1.Y.Value, 0).Distance(new Point3D(p2.X.Value, p2.Y.Value, 0));
        }
    }
}