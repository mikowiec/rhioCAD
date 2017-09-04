#region Usings

using System.Collections.Generic;
using TreeData.AttributeInterpreter.TypeHelpers;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace Extensions.NotificationTree
{
    public class NotificationInterpreter : NaroDataInterpreter
    {
        #region Delegates

        public delegate void NotificationEvent(Node pathNode);

        #endregion

        private string _folderPath;
        private NotificationEvent _notify;

        private string FolderPath
        {
            get { return _folderPath; }
            set
            {
                _folderPath = value;
                OnModified();
            }
        }

        private Node GetNodePath(LinkedList<string> pathItems)
        {
            if (pathItems.Count == 0)
                return Parent;

            var firstPathItem = pathItems.First.Value;
            foreach (var node in Parent.Children.Values)
            {
                var interpreter = node.Set<NotificationInterpreter>();
                if (firstPathItem != interpreter.FolderPath) continue;
                pathItems.RemoveFirst();
                return GetNodePath(pathItems);
            }
            var newPath = Parent.AddNewChild();
            newPath.Set<NotificationInterpreter>().FolderPath = firstPathItem;
            pathItems.RemoveFirst();
            return GetNodePath(pathItems);
        }

        private void OnNotify()
        {
            if (_notify != null)
                _notify(Parent);
            OnModified();
        }

        public void NotifyPath(string path)
        {
            var pathItems = BuildPathItems(path);

            Ensure.IsNotZero(pathItems.Count);
            var pathNode = GetNodePath(pathItems);
            Ensure.IsNotNull(pathNode);
            pathNode.Get<NotificationInterpreter>().OnNotify();
        }

        private static LinkedList<string> BuildPathItems(string path)
        {
            var pathWords = path.Split(new[] {'.', '/'});
            var pathItems = new LinkedList<string>();
            foreach (var pathWord in pathWords)
                pathItems.AddLast(pathWord);
            return pathItems;
        }

        public void RegisterPath(string path, NotificationEvent notify)
        {
            var pathNode = GetNodePath(BuildPathItems(path));
            pathNode.Set<NotificationInterpreter>()._notify += notify;
        }
    }
}