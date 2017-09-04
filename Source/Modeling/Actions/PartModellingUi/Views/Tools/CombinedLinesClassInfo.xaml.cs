#region Usings

using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace PartModellingUi.Views.Tools
{
    public class CombinedLinesClassInfo
    {
        public readonly Point3D CommonPoint;
        private NodeBuilder _destLine;
        private bool _firstReversed;
        private bool _secondReversed;
        private NodeBuilder _sourceLine;

        public CombinedLinesClassInfo(Point3D commonPoint, NodeBuilder sourceLine, NodeBuilder destLine)
        {
            CommonPoint = commonPoint;
            _sourceLine = sourceLine;
            _destLine = destLine;
            _firstReversed = CommonPoint.IsEqual(sourceLine[0].RefTransformedPoint3D);
            _secondReversed = !CommonPoint.IsEqual(destLine[0].RefTransformedPoint3D);
        }

        public double Angle
        {
            get
            {
                Point3D a, b, c, d;

                GetEdges(_sourceLine, _firstReversed, out a, out b);
                GetEdges(_destLine, _secondReversed, out c, out d);
                Ensure.IsTrue(b.IsEqual(c));
                return GeomUtils.GetPointAngle(a, b, c);
            }
        }

        public void Combine(double angle, bool reversedBase)
        {
            Point3D a, b, c, d;
            if (reversedBase)
                ReverseBuilders();
            GetEdges(_sourceLine, _firstReversed, out a, out b);
            GetEdges(_destLine, _secondReversed, out c, out d);
            Ensure.IsTrue(b.IsEqual(c));
            var angleCoordinate = GeomUtils.GetAnglePointPosition(a, b, d, angle);
            _destLine[_secondReversed ? 0 : 1].RefTransformedPoint3D = angleCoordinate;
        }

        private void ReverseBuilders()
        {
            var auxbuilder = _sourceLine;
            _sourceLine = _destLine;
            _destLine = auxbuilder;

            var auxReversed = _firstReversed;
            _firstReversed = !_secondReversed;
            _secondReversed = !auxReversed;
        }

        private static void GetEdges(NodeBuilder builder, bool firstReversed, out Point3D a, out Point3D b)
        {
            a = builder[0].RefTransformedPoint3D;
            b = builder[1].RefTransformedPoint3D;
            if (!firstReversed) return;
            var aux = b;
            b = a;
            a = aux;
        }
    }
}