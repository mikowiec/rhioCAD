#region Usings

using System.Collections.Generic;

#endregion

namespace Naro.Infrastructure.Library.Qos
{
    public class QosFactory
    {
        private static readonly QosFactory SingletonInstance = new QosFactory();
        private readonly SortedDictionary<string, QosLock> _locks = new SortedDictionary<string, QosLock>();

        private QosFactory()
        {
        }

        public static QosFactory Instance
        {
            get { return SingletonInstance; }
        }

        public QosLock Create(string qosIndex, int lockTime, string qualityMessage)
        {
            var qosLock = new QosLock(lockTime, qualityMessage);
            _locks[qosIndex] = qosLock;
            return qosLock;
        }

        public QosLock Get(string qosIndex)
        {
            QosLock value;
            return _locks.TryGetValue(qosIndex, out value) ? value : null;
        }
    }
}