#region Usings

using NaroCppCore.Occ.gp;

#endregion


namespace TreeData.AttributeInterpreter
{
    public struct Axis
    {
        private Point3D _direction;
        private Point3D _location;

        public Axis(Point3D location, Point3D direction)
        {
            _location = location;
            _direction = direction;
        }

        public Axis(gpAx1 axis) : this()
        {
            GpAxis = axis;
        }

        public Point3D Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public Point3D Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }

        public gpAx1 GpAxis
        {
            set
            {
                Location = new Point3D(value.Location);
                var xyz = value.Direction.XYZ;
                Direction = new Point3D(new gpPnt(xyz));
            }
            get { return new gpAx1(Location.GpPnt, new gpDir(Direction.GpPnt.XYZ)); }
        }
    }
}