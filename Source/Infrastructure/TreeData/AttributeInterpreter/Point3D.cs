#region Usings


#endregion

using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.ProjLib;
using NaroCppCore.Occ.gp;

namespace TreeData.AttributeInterpreter
{
    public struct Point3D
    {
        public Point3D(gpPnt pnt)
        {
            X = pnt.X;
            Y = pnt.Y;
            Z = pnt.Z;
        }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        //public Point3D(OCgp_Ax2 axis, double x, double y)
        //{
        //    var vxy = axis.XDirection().XYZ();
        //    vxy.SetLinearForm(x, vxy, y, axis.YDirection().XYZ(), axis.Location().XYZ());

        //    var point = new gpPnt(vxy);

        //    X = point.X();
        //    Y = point.Y();
        //    Z = point.Z();
        //}

        public gpPnt GpPnt
        {
            get { return new gpPnt(X, Y, Z); }
        }


        public bool IsEqual(Point3D point)
        {
            var dx = X - point.X;
            var dy = Y - point.Y;
            var dz = Z - point.Z;
            return (dx*dx + dy*dy + dz*dz <= Range*Range);
        }

        public double Distance(Point3D other)
        {
            return GpPnt.Distance(other.GpPnt);
        }

        public gpPnt2d ToPoint2D(gpAx2 ax2)
        {
            var pointPlane = new gpPln(new gpAx3(ax2));
            var point2D = ProjLib.Project(pointPlane, GpPnt);

            return point2D;
        }

        public Point3D AddCoordinate(Point3D distance)
        {
            var result = this;
            result.X += distance.X;
            result.Y += distance.Y;
            result.Z += distance.Z;
            return result;
        }

        public Point3D SubstractCoordinate(Point3D distance)
        {
            var result = this;
            result.X -= distance.X;
            result.Y -= distance.Y;
            result.Z -= distance.Z;
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0:0.000} {1:0.000} {2:0.000}",
                                 X,
                                 Y,
                                 Z);
        }

        #region Data members

        private static readonly double Range = Precision.Confusion;

        public double X;
        public double Y;
        public double Z;

        #endregion
    }
}