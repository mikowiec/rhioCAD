#region Usings

using System.Reflection;
using TreeData.NaroData;

#endregion

namespace TreeData.AttributeInterpreter.TypeHelpers
{
    internal class IntPropertyHandler : ReadWritePropertyInterpreter<int>
    {
        public override void Serialize(PropertyInfo propertyInfo, AttributeData data, object instance)
        {
            var intValue = (int) propertyInfo.GetValue(instance, null);
            data.WriteAttribute(propertyInfo.Name, intValue);
        }

        public override void Deserialize(PropertyInfo propertyInfo, AttributeData data, object instance)
        {
            var intValue = data.ReadAttributeInteger(propertyInfo.Name);
            propertyInfo.SetValue(instance, intValue, null);
        }
    }
}