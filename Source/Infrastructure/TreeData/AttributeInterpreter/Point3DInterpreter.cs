#region Usings

using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class Point3DInterpreter : AttributeInterpreterBase
    {
        #region Properties

        public Point3D Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnModified();
            }
        }

        #endregion

        #region Overriden methods

        public override void Serialize(AttributeData data)
        {
            data.WriteAttribute("Pos", _value.GpPnt);
        }

        public override void Deserialize(AttributeData data)
        {
            Value = data.ReadAttributePoint3D("Pos");
        }

        #endregion

        #region Data members

        private Point3D _value;

        #endregion
    }
}