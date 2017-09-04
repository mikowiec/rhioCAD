#region Usings

using System;
using System.Collections.Generic;
using NaroConstants.Names;

#if !DEBUG
using log4net;
#endif

#endregion

namespace NaroPipes.Actions
{
    public class InputBase
    {
#if !DEBUG
        private static readonly ILog Log = LogManager.GetLogger(typeof(InputBase));
#endif

        public InputBase(string name)
        {
            Name = name;
            NotificationDataHandlers = new SortedDictionary<string, DataPackageHandler>();
        }

        internal virtual void Disconnect()
        {
            HasDataNotify = null;
        }

        public virtual void OnDisconnect()
        {
        }

        public virtual void OnRegister()
        {
        }

        public ActionsGraph ActionsGraph { get; set; }

        protected virtual void OnNotification(string name, DataPackage dataPackage)
        {
            IsNotificationHandled(name, dataPackage);
        }

        protected void AddNotificationHandler(string inputName, DataPackageHandler packageHandler)
        {
            NotificationDataHandlers[inputName] = null;
            NotificationDataHandlers[inputName] += packageHandler;
        }

        private void IsNotificationHandled(string inputName, DataPackage data)
        {
            DataPackageHandler packageHandler;
            if (NotificationDataHandlers.TryGetValue(inputName, out packageHandler))
                packageHandler(data);
        }

        private void OnNotification(string name)
        {
            OnNotification(name, new DataPackage(null));
        }

        public void Send(string name)
        {
            OnNotification(name);
        }

        public void Send(string name, DataPackage dataObject)
        {
            OnNotification(name, dataObject);
        }

        public string Name { get; private set; }


        protected void AddData(string name, object data)
        {
            var dataPackage = new DataPackage(name, data);
            SendDataPackage(dataPackage);
        }

        protected void AddData<T>(T objectData)
        {
            var dataPackage = new DataPackage(objectData);
            SendDataPackage(dataPackage);
        }

        private void SendDataPackage(DataPackage dataPackage)
        {
#if !DEBUG
            try
            {
#endif
            if (HasDataNotify != null)
                HasDataNotify(Name, dataPackage);
#if !DEBUG
            }
            catch (Exception ex)
            {
                Log.Debug(ex.Message);
            }
#endif
        }

        public virtual void OnConnect()
        {
        }

        protected DataPackage ReturnData { private get; set; }

        public DataPackage GetData(string objectName)
        {
            return GetData(objectName, new DataPackage(null));
        }

        public DataPackage GetData(string objectName, DataPackage dataObject)
        {
            OnNotification(objectName, dataObject);
            return ReturnData;
        }

        public T Get<T>()
        {
            return GetData(NotificationNames.GetValue).Get<T>();
        }

        public delegate void DataPackageHandler(DataPackage data);

        private SortedDictionary<string, DataPackageHandler> NotificationDataHandlers { get; set; }

        public delegate void HasDataEvent(String name, DataPackage data);

        public HasDataEvent HasDataNotify;

        public void Send(string name, object dataObject)
        {
            Send(name, new DataPackage(dataObject));
        }

        public void Send(string name, string dataText)
        {
            Send(name, new DataPackage(dataText));
        }
    }
}