#region Usings

using System.Collections.Generic;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace Naro.Infrastructure.Interface.Boo
{
    public abstract class LibraryShape
    {
        protected LibraryShape()
        {
            GenerateTreeViewFromRootBuilder = false;
            Dependency = new List<DependencyNode>();
        }

        private List<DependencyNode> Dependency { get; set; }
        public NodeBuilder RootBuilder { get; protected set; }
        public bool GenerateTreeViewFromRootBuilder { get; protected set; }

        protected LibraryShape GetGlobal(string shapeName)
        {
            return GlobalLibraryShapeFactory.Instance.Get(shapeName);
        }

        protected void AddDependency<T>(T defaultValue)
        {
            AddDependency<T>();
            Dependency[Dependency.Count - 1].Value = defaultValue;
        }

        protected void AddDependency<T>()
        {
            var dependencyNode = new DependencyNode
                                     {
                                         TypeId = typeof (T).GetHashCode(),
                                         Value = null
                                     };
            Dependency.Add(dependencyNode);
        }

        public T Get<T>(int index)
        {
            Ensure.AreEqual(typeof (T).GetHashCode(), Dependency[index].TypeId);
            return (T) Dependency[index].Value;
        }

        public void Set<T>(int index, T value)
        {
            Ensure.AreEqual(typeof (T).GetHashCode(), Dependency[index].TypeId);
            Dependency[index].Value = value;
        }

        public abstract bool Execute(Document document);

        #region Nested type: DependencyNode

        private class DependencyNode
        {
            public int TypeId;
            public object Value { get; set; }
        }

        #endregion
    }
}