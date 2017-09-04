#region Usings

using System;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;

using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctionsInterface.Functions
{
    public abstract class FunctionBase
    {
        protected FunctionBase(string name)
        {
            Name = name;
            Dependency = new FunctionDependency(String.Empty);
        }

        public string Name { get; private set; }

        protected Node Parent
        {
            get { return Dependency.Node; }
        }


        protected NodeBuilder Builder
        {
            get { return new NodeBuilder(Parent); }
        }

        /// <summary>
        /// </summary>
        public FunctionDependency Dependency { get; private set; }

        /// <summary>
        ///   The generated Execute shape
        /// </summary>
        protected TopoDSShape Shape
        {
            get { return Parent.Get<NamedShapeInterpreter>() == null ? null : Parent.Get<NamedShapeInterpreter>().Shape; }
            set { Parent.Set<NamedShapeInterpreter>().Shape = value; }
        }

        /// <summary>
        ///   The generated interctive shape
        /// </summary>
        protected AISInteractiveObject Interactive
        {
            set { Parent.Set<InteractiveShapeInterpreter>().Interactive = value; }
        }

        protected gpAx1 Axis
        {
            set { Parent.Set<NamedShapeInterpreter>().Axis = value; }
        }

        public void SetNode(Node node)
        {
            Dependency.Node = node;
        }

        public virtual void PreExecute()
        {
        }

        protected virtual bool ValidateReference(int indexDependency, ReferenceInterpreter reference)
        {
            return true;
        }

        public bool ValidateReference(int indexDependency)
        {
            return ValidateReference(indexDependency, Dependency[indexDependency].Node.Get<ReferenceInterpreter>());
        }

        public abstract bool Execute();

        protected void AddDependency(string interpreterName)
        {
            Dependency.AddAttributeType(interpreterName);
        }
    }
}