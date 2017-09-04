#region Usings

using System;
using System.Collections.Generic;
using NaroConstants.Names;
using NaroPipes.Actions;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctionsInterface.Utils
{
    public class GenericCacheComparer
    {
        public static bool UpdatedMemento(NodeBuilder nodeBuilder, DataPackage memento)
        {
            var cacheData = new CacheData(nodeBuilder.Node.Get<FunctionInterpreter>().Dependency,
                                          nodeBuilder.FunctionName);
            if (memento.Data == null)
            {
                memento.Data = cacheData;
                return true;
            }
            var oldCache = (CacheData) (memento.Data);
            var result = !cacheData.IsEqual(oldCache);
            if (result) memento.Data = cacheData;
            return result;
        }

        #region Nested type: CacheData

        private class CacheData
        {
            private readonly FunctionDependency _dependency;
            private readonly string _functionName;

            public CacheData(FunctionDependency dependency, string functionName)
            {
                _dependency = dependency;
                _functionName = functionName;
                Data = new List<object>();
                foreach (var dependencyNode in dependency.Children)
                {
                    switch (dependencyNode.Name)
                    {
                        case InterpreterNames.Real:
                            Data.Add(dependencyNode.Real);
                            break;
                        case InterpreterNames.TransformedPoint3D:
                            Data.Add(dependencyNode.TransformedPoint3D);
                            break;
                        case InterpreterNames.Integer:
                            Data.Add(dependencyNode.Integer);
                            break;
                        default:
                            Data.Add(null);
                            break;
                    }
                }
            }


            private List<object> Data { get; set; }

            public bool IsEqual(CacheData data)
            {
                if (_functionName != data._functionName)
                    return false;
                var count = _dependency.Children.Count;
                for (var i = 0; i < count; i++)
                {
                    var dependencyNode = _dependency[i];
                    var compareNode = data._dependency[i];
                    switch (dependencyNode.Name)
                    {
                        case InterpreterNames.Real:
                            if (Math.Abs(dependencyNode.Real - compareNode.Real) < 1e-12)
                                return false;
                            break;
                        case InterpreterNames.Integer:
                            if (dependencyNode.Integer != compareNode.Integer)
                                return false;
                            break;
                        case InterpreterNames.Point3D:
                            if (!dependencyNode.TransformedPoint3D.IsEqual(compareNode.TransformedPoint3D))
                                return false;
                            break;
                    }
                }
                return true;
            }
        }

        #endregion
    }
}