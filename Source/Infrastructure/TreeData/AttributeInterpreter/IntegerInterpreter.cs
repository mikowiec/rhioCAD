#region Usings

using TreeData.AttributeInterpreter.TypeHelpers;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class ObjectInterpreter : NaroDataInterpreter
    {
        public object Data { get; set; }
    }
    public class IntegerInterpreter : NaroDataInterpreter
    {
        #region Properties

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnModified();
            }
        }

        #endregion

        #region Data members

        private int _value;

        #endregion
    }
}