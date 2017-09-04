#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using OccCode;

using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives3D
{
    public class BoxFunction : FunctionBase
    {
        public BoxFunction() : base(FunctionNames.Box)
        {
            // The 2 base points and direction that describe a rectangle
            Dependency.AddAttributeType(InterpreterNames.Axis3D);
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            // The height
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var axis = Dependency[0].Axis3D;
            var secondPoint = Dependency[1].TransformedPoint3D;
            var height = Dependency[2].Real;

            Shape = MakeBox(axis.GpAxis, secondPoint, height);

            return true;
        }

        /// <summary>
        ///   Builds a box receiving three points that describe the base rectangle and one being the height
        /// </summary>
        /// <param name = "axis"></param>
        /// <param name = "secondPoint"></param>
        /// <param name = "height"></param>
        /// <returns></returns>
        private static TopoDSShape MakeBox(gpAx1 axis, Point3D secondPoint, double height)
        {
            var face = OccShapeCreatorCode.BuildRectangle(axis.Location, secondPoint.GpPnt, axis.Direction);
            // Get the direction
            var dir = GeomUtils.ExtractDirection(face);
            var vector = new gpVec(dir);
            vector.Multiply(height);

            return new BRepPrimAPIMakePrism(face, vector, false, true).Shape;
        }
    }
}