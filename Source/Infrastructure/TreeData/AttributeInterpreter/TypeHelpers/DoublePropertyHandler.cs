#region Usings

using System.Reflection;
using TreeData.NaroData;

#endregion

namespace TreeData.AttributeInterpreter.TypeHelpers
{
    internal class DoublePropertyHandler : ReadWritePropertyInterpreter<double>
    {
        public override void Serialize(PropertyInfo propertyInfo, AttributeData data, object instance)
        {
            var doubleValue = (double) propertyInfo.GetValue(instance, null);
            data.WriteAttribute(propertyInfo.Name, doubleValue);
        }

        public override void Deserialize(PropertyInfo propertyInfo, AttributeData data, object instance)
        {
            var intValue = data.ReadAttributeDouble(propertyInfo.Name);
            propertyInfo.SetValue(instance, intValue, null);
        }
    }
}