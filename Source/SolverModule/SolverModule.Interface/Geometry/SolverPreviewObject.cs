#region Usings

using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    public abstract class SolverPreviewObject
    {
        protected SolverPreviewObject(Point3D point)
        {
            Point = point;
        }

        public Point3D Point { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public abstract void Preview(Document document);
    }
}