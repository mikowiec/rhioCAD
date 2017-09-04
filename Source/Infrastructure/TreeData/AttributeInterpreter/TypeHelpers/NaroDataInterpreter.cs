#region Usings

using System.Reflection;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter.TypeHelpers
{
    public abstract class NaroDataInterpreter : AttributeInterpreterBase
    {
        private readonly bool _notifyModified;

        protected NaroDataInterpreter()
        {
            _notifyModified = true;
        }

        protected NaroDataInterpreter(bool notifyModified)
        {
            _notifyModified = notifyModified;
        }

        public override void Serialize(AttributeData data)
        {
            var propertyInfos = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var propertyInfo in propertyInfos)
                PropertyReadWriteHandle.Instance.Serialize(propertyInfo, this, data);
        }

        public override void Deserialize(AttributeData data)
        {
            var propertyInfos = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var propertyInfo in propertyInfos)
                PropertyReadWriteHandle.Instance.Deserialize(propertyInfo, this, data);
            if (_notifyModified)
                OnModified();
        }
    }
}