#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Algo;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace InteractiveEditor
{
    internal class CursorPolylineBuilder
    {
        private readonly Document _document;
        private readonly Point3D _firstPoint;
        private Point3D _lastPoint;

        public CursorPolylineBuilder(Document document, Point3D startCoordinate)
        {
            _document = document;
            _firstPoint = startCoordinate;
            _lastPoint = startCoordinate;
        }

        private Node LastCreatedShape { get; set; }

        public NodeBuilder Builder
        {
            get { return new NodeBuilder(LastCreatedShape); }
        }

        public void DrawTo(double x, double y, double z)
        {
            var newPoint = _lastPoint;
            newPoint.X += x;
            newPoint.Y += y;
            newPoint.Z += z;
            LastCreatedShape = TreeUtils.AddLineToNode(_document, _lastPoint, newPoint).Node;
            _lastPoint = newPoint;
            var result = AutoGroupLogic.TryAutoGroup(_document, LastCreatedShape);
            if (result != null)
                LastCreatedShape = result;
        }

        public void CloseShape()
        {
            LastCreatedShape = TreeUtils.AddLineToNode(_document, _lastPoint, _firstPoint).Node;
            var result = AutoGroupLogic.TryAutoGroup(_document, LastCreatedShape);
            if (result != null)
                LastCreatedShape = result;
        }
    }
}