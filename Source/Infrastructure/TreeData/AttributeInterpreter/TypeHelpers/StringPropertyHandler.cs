#region Usings

using System.Reflection;
using TreeData.NaroData;

#endregion

namespace TreeData.AttributeInterpreter.TypeHelpers
{
    internal class StringPropertyHandler : ReadWritePropertyInterpreter<string>
    {
        public override void Serialize(PropertyInfo propertyInfo, AttributeData data, object instance)
        {
            var intValue = data.ReadAttributeString(propertyInfo.Name);
            propertyInfo.SetValue(this, intValue, null);
        }

        public override void Deserialize(PropertyInfo propertyInfo, AttributeData data, object instance)
        {
            var intValue = (string) propertyInfo.GetValue(this, null);
            data.WriteAttribute(propertyInfo.Name, intValue);
        }
    }
}