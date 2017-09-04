namespace NaroPipes.Actions
{
    public class DataPackage
    {
        public DataPackage(string name)
        {
            SetInternalData(name, null);
        }

        public DataPackage(string name, object data)
        {
            SetInternalData(name, data);
        }

        public DataPackage(object data)
        {
            SetInternalData(string.Empty, data);
        }

        public string Text { get; private set; }
        public object Data { get; set; }

        private void SetInternalData(string name, object data)
        {
            Text = name;
            Data = data;
        }

        public T Get<T>()
        {
            return (T) Data;
        }
    }
}