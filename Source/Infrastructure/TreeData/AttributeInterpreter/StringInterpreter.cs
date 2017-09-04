#region Usings

using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class StringInterpreter : AttributeInterpreterBase
    {
        #region Properties

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnModified();
            }
        }

        #endregion

        #region Overridden methods

        public override void Serialize(AttributeData data)
        {
            data.WriteAttribute("Value", _value);
        }

        public override void Deserialize(AttributeData data)
        {
            Value = data.ReadAttributeString("Value");
        }

        #endregion

        #region Data members

        private string _value;

        #endregion
    }
}