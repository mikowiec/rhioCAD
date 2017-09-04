#region Usings

using System;
using System.Reflection;
using TreeData.NaroData;

#endregion

namespace TreeData.AttributeInterpreter.TypeHelpers
{
    internal abstract class ReadWritePropertyInterpreter<T> : IReadWritePropertyInterpreter
    {
        #region IReadWritePropertyInterpreter Members

        public Type GetImplementedType()
        {
            return typeof (T);
        }

        public abstract void Serialize(PropertyInfo propertyInfo, AttributeData data, object instance);
        public abstract void Deserialize(PropertyInfo propertyInfo, AttributeData data, object instance);

        #endregion
    }
}