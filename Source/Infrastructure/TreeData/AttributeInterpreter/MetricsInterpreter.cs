#region Usings

using TreeData.AttributeInterpreter.TypeHelpers;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class MetricsInterpreter : NaroDataInterpreter
    {
        #region Properties

        public double ScaleMm
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