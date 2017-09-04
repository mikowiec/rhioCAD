#region Usings

using TreeData.AttributeInterpreter.TypeHelpers;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class RealInterpreter : NaroDataInterpreter
    {
        #region Properties

        public double Value
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

        private double _value;

        #endregion
    }
}