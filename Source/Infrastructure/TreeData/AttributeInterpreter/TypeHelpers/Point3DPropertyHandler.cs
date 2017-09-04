#region Usings

using System.Reflection;
using TreeData.NaroData;

#endregion

namespace TreeData.AttributeInterpreter.TypeHelpers
{
    internal class Point3DPropertyHandler : ReadWritePropertyInterpreter<Point3D>
    {
        public override void Serialize(PropertyInfo propertyInfo, AttributeData data, object instance)
        {
            var intValue = data.ReadAttributePoint3D(propertyInfo.Name);
            propertyInfo.SetValue(this, intValue, null);
        }

        public override void Deserialize(PropertyInfo propertyInfo, AttributeData data, object instance)
        {
            var intValue = (Point3D) propertyInfo.GetValue(this, null);
            data.WriteAttribute(propertyInfo.Name, intValue);
        }
    }
}