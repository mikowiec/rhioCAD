#region Usings

using System;
using System.Reflection;
using TreeData.NaroData;

#endregion

namespace TreeData.AttributeInterpreter.TypeHelpers
{
    internal interface IReadWritePropertyInterpreter
    {
        Type GetImplementedType();

        void Serialize(PropertyInfo propertyInfo, AttributeData data, object instance);
        void Deserialize(PropertyInfo propertyInfo, AttributeData data, object instance);
    }
}