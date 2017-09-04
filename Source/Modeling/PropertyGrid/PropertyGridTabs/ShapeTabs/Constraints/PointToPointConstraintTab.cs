#region Usings

using System;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using TreeData.AttributeInterpreter;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class PointToPointConstraintTab : GridTabBase
    {
        public PointToPointConstraintTab()
            : base("Point to point constraint")
        {
        }


        private void GetRelativeOffset(ref object resultvalue)
        {
            resultvalue = Builder[2].TransformedPoint3D;
        }

        private void SetRelativeOffset(object data)
        {
            BeginUpdate();
            Builder[2].Node.Set<Point3DInterpreter>().Value = (Point3D) data;
            EndVisualUpdate("Updated offset");
        }

        private void GetLength(ref object resultvalue)
        {
            resultvalue = ComputeDistanceFromOrigin(Builder[2].Node.Get<Point3DInterpreter>().Value);
        }

        private static double ComputeDistanceFromOrigin(Point3D point)
        {
            var x2 = point.X*point.X;
            var y2 = point.Y*point.Y;
            var z2 = point.Z*point.Z;
            return Math.Sqrt(x2 + y2 + z2);
        }

        private void SetLength(object data)
        {
            var point = Builder[2].Node.Get<Point3DInterpreter>().Value;
            var originalLength = ComputeDistanceFromOrigin(point);
            var newLength = (double) data;
            var scaleFactor = newLength/originalLength;
            var newPoint = point;
            newPoint.X *= scaleFactor;
            newPoint.Y *= scaleFactor;
            newPoint.Z *= scaleFactor;
            BeginUpdate();
            Builder[2].Node.Set<Point3DInterpreter>().Value = newPoint;
            EndVisualUpdate("Updated length");
        }

        protected override void BuildInterface()
        {
            var lengthProperty = new DoublePropertyTabItem();
            lengthProperty.OnSetValue += SetLength;
            lengthProperty.OnGetValue += GetLength;
            PropertyListGenerator.AddProperty("Length", lengthProperty);

            var pointProperty = new Point3DPropertyTabItem();
            pointProperty.OnSetValue += SetRelativeOffset;
            pointProperty.OnGetValue += GetRelativeOffset;
            PropertyListGenerator.AddProperty("Relative Offset", pointProperty);
        }
    }
}