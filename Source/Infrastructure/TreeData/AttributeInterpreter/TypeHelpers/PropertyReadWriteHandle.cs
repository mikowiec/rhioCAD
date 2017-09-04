#region Usings

using System.Collections.Generic;
using System.Reflection;
using TreeData.NaroData;

#endregion

namespace TreeData.AttributeInterpreter.TypeHelpers
{
    internal class PropertyReadWriteHandle
    {
        private static readonly PropertyReadWriteHandle SingletonInstance = new PropertyReadWriteHandle();
        private readonly List<IReadWritePropertyInterpreter> _handlerList;

        private PropertyReadWriteHandle()
        {
            _handlerList = new List<IReadWritePropertyInterpreter>();
            Register(new IntPropertyHandler());
            Register(new DoublePropertyHandler());
            Register(new Point3DPropertyHandler());
            Register(new StringPropertyHandler());
        }

        public static PropertyReadWriteHandle Instance
        {
            get { return SingletonInstance; }
        }

        public void Register<T>(ReadWritePropertyInterpreter<T> serializerHelper)
        {
            _handlerList.Add(serializerHelper);
        }

        public void Serialize(PropertyInfo propertyInfo, object instance, AttributeData data)
        {
            foreach (var handle in _handlerList)
                if (handle.GetImplementedType() == propertyInfo.PropertyType)
                    handle.Serialize(propertyInfo, data, instance);
        }

        public void Deserialize(PropertyInfo propertyInfo, object instance, AttributeData data)
        {
            foreach (var handle in _handlerList)
                if (handle.GetImplementedType() == propertyInfo.PropertyType)
                    handle.Deserialize(propertyInfo, data, instance);
        }
    }
}