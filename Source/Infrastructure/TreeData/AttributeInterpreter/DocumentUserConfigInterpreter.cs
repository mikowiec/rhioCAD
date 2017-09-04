#region Usings

using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class DocumentUserConfigInterpreter : AttributeInterpreterBase
    {
        private double _unitMmScale;

        public double UnitMmScale
        {
            set
            {
                _unitMmScale = value;
                OnModified();
            }
        }

        public override void Serialize(AttributeData data)
        {
            data.WriteAttribute("UnitMmScale", _unitMmScale);
        }

        public override void Deserialize(AttributeData data)
        {
            UnitMmScale = data.ReadAttributeDouble("UnitMmScale");
        }
    }
}