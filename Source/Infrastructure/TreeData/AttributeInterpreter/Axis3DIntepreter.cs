#region Usings

using NaroCppCore.Occ.gp;
using TreeData.NaroData;

#endregion

namespace TreeData.AttributeInterpreter
{
    /// <summary>
    ///   GeometryInterpreter that processes an gpAx1 axis in 3D space.
    /// </summary>
    public class Axis3DInterpreter : Point3DInterpreter
    {
        #region Data members

        private Axis _value;

        #endregion

        #region Properties

        public new Point3D Value
        {
            get { return _value.Location; }
        }

        public Axis Axis
        {
            get { return _value; }
            set { _value = value; }
        }

        public gpAx1 GpAxis
        {
            get { return _value.GpAxis; }
            set
            {
                _value.GpAxis = value;
                OnModified();
            }
        }

        #endregion

        #region Overriden Methods

        public override void Serialize(AttributeData data)
        {
            // Write location
            data.WriteAttribute("Position", _value.Location);

            // Write direction
            data.WriteAttribute("DX", _value.Direction.X);
            data.WriteAttribute("DY", _value.Direction.Y);
            data.WriteAttribute("DZ", _value.Direction.Z);
        }

        public override void Deserialize(AttributeData data)
        {
            // Read location
            var position = data.ReadAttributePoint3D("Position");

            // Read direction
            var dx = data.ReadAttributeDouble("DX");
            var dy = data.ReadAttributeDouble("DY");
            var dz = data.ReadAttributeDouble("DZ");

            GpAxis = new gpAx1(position.GpPnt, new gpDir(dx, dy, dz));
        }

        #endregion
    }
}