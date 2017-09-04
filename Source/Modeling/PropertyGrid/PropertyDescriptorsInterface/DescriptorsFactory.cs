#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Documents;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace PropertyDescriptorsInterface
{
    public class DescriptorsFactory
    {
        private static readonly DescriptorsFactory SingletonInstance = new DescriptorsFactory();
        private readonly SortedDictionary<int, GridTabBase> _registeredTabs = new SortedDictionary<int, GridTabBase>();
        private readonly SortedDictionary<string, GridTabBase> _shapeTabs = new SortedDictionary<string, GridTabBase>();
        private readonly Dictionary<SelectionList, GridTabBase> _selectionTabs = new Dictionary<SelectionList, GridTabBase>();
        private readonly SortedDictionary<ConstraintPair, GridTabBase> _constraintsTab =
            new SortedDictionary<ConstraintPair, GridTabBase>();
        private DescriptorsFactory()
        {
        }

        public static DescriptorsFactory Instance
        {
            get { return SingletonInstance; }
        }

        public SortedDictionary<int, GridTabBase> RegisteredTabs
        {
            get { return _registeredTabs; }
        }

        public void RegisterInterpreterTab<T>(GridTabBase tab) where T : AttributeInterpreterBase
        {
            _registeredTabs[typeof (T).GetHashCode()] = tab;
        }

        public GridTabBase GetFunctionTab(string key)
        {
            return _shapeTabs.ContainsKey(key) ? _shapeTabs[key] : null;
        }

        public GridTabBase GetSelectionsTab(Node node1, Node node2, Node node3)
        {
            if (node1.Get<FunctionInterpreter>() == null || node2.Get<FunctionInterpreter>() == null || node3.Get<FunctionInterpreter>() == null)
                return null;
            var list = new List<string>
                           {
                               node1.Get<FunctionInterpreter>().Name,
                               node2.Get<FunctionInterpreter>().Name,
                               node3.Get<FunctionInterpreter>().Name
                           };
            list.Sort();
            var SelectionList = new SelectionList(list[0], list[1], list[2]);
            GridTabBase tab = null;
            _selectionTabs.TryGetValue(SelectionList, out tab);
            return tab;
        }

        public GridTabBase GetConstraintTab(string functionName1, string functionName2)
        {
            var constraintPair = new ConstraintPair(functionName1, functionName2);
            foreach(var tab in _constraintsTab)
            {
                if (tab.Key.CompareTo(constraintPair) == 0)
                    return tab.Value;
            }
            return null;
        }

        public void RegisterFunctionTab(string functionName, GridTabBase tab)
        {
            _shapeTabs[functionName] = tab;
        }

        public void RegisterConstraintsTab(string functionNameNode1, string functionNameNode2, GridTabBase tab)
        {
            var constraintPair = new ConstraintPair(functionNameNode1, functionNameNode2);
            _constraintsTab[constraintPair] = tab;
        }

        public void RegisterSelectionsTab(List<String> selectedObjects, GridTabBase tab)
        {
            if (selectedObjects.Count < 3)
                return;
            selectedObjects.Sort();
            var selectionList = new SelectionList(selectedObjects[0], selectedObjects[1], selectedObjects[2]);
            Console.WriteLine(selectedObjects[0]+" "+selectedObjects[1]+" "+selectedObjects[2]);
            if(!_selectionTabs.ContainsKey(selectionList))
                _selectionTabs[selectionList] = tab;
        }
    }

    public class ConstraintPair : IComparable
    {
        public string constraint1;
        public string constraint2;
        public ConstraintPair(string functionName1 , string functionName2)
        {
            constraint1 = functionName1;
            constraint2 = functionName2;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            var otherPair = obj as ConstraintPair;
            if (otherPair == null)
                throw new ArgumentException("Object is not a constraintPair");
            if (this.constraint1 == otherPair.constraint1 && this.constraint2 == otherPair.constraint2)
                return 0;
            if (this.constraint1 == otherPair.constraint2 && this.constraint2 == otherPair.constraint1)
                return 0;
            return 1;
        }
    }

    public class SelectionList  : IEquatable<SelectionList>
    {
        private readonly string _shape1;
        private readonly string _shape2;
        private readonly string _shape3;

        public SelectionList(string functionName1, string functionName2, string functionName3)
        {
            _shape1 = functionName1;
            _shape2 = functionName2;
            _shape3 = functionName3;
        }

        public override int GetHashCode()
        {
            return _shape1.GetHashCode() + _shape2.GetHashCode() + _shape3.GetHashCode();
        }

        public bool Equals(SelectionList obj) 
         {
             if (obj == null) return false;

             var firstFunctions = new List<string> { _shape1, _shape2, _shape3 };
             firstFunctions.Sort();
             var secondFunctions = new List<string> { obj._shape1, obj._shape2, obj._shape3 };
             secondFunctions.Sort();
             if (_shape1 == obj._shape1 && _shape2 == obj._shape2 && _shape3 == obj._shape3)
                 return true;

             return false;
         }
    }
}