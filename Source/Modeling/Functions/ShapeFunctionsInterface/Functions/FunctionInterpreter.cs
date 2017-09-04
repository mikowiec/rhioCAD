#region Usings

using System;
using System.Text;
using log4net;
using NaroConstants.Names;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace ShapeFunctionsInterface.Functions
{
    public class FunctionInterpreter : AttributeInterpreterBase
    {
        #region Data members

        private static readonly ILog Log = LogManager.GetLogger(typeof (FunctionInterpreter));
        private FunctionBase _function;

        #endregion

        #region Properties

        /// <summary>
        ///   Name of function that is identifier in FunctionFactorty
        /// </summary>
        public string Name
        {
            get { return _function == null ? "Invalid" : _function.Name; }
            set
            {
                if (_function != null)
                {
                    if (value == _function.Name)
                        return;
                }

                _function = FunctionFactory.Instance.Get(value.GetHashCode());
                _function.SetNode(Parent);
                _function.PreExecute();
                BeginUpdate();
            }
        }

        /// <summary>
        ///   The exposed dependency function used to complete the data members
        /// </summary>
        public FunctionDependency Dependency
        {
            get { return _function.Dependency; }
        }

        #endregion

        #region Methods

        /// <summary>
        ///   Froze the execution of method Execute regardless of Node children's changes
        /// </summary>
        private void BeginUpdate()
        {
            Dependency.BeginUpdate();
        }

        public bool ValidateReferences()
        {
            for (var index = 0; index < Dependency.Children.Count; index++)
            {
                var child = Dependency.Children[index];
                if (child.Name != InterpreterNames.Reference) continue;
                if (!_function.ValidateReference(index))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public bool Execute()
        {
            Dependency.EndUpdate();
            if (_function.Dependency.Node == null)
            {
                _function.Dependency.Node = Parent;
            }

            _function.PreExecute();
            var result = false;
            if (!Dependency.IsValid)
            {
                return false;
            }
            if (!ValidateReferences())
            {
                return false;
            }
            try
            {
                result = _function.Execute();
            }
            catch (Exception e)
            {
                var message = new StringBuilder();
                message.Append("Exception on executing function: ");
                message.AppendLine(Name);
                message.AppendLine("With message:");
                message.AppendLine(e.Message);
                message.AppendLine("With stack:");
                message.AppendLine(e.StackTrace);

                Log.Error(message.ToString());
            }
            Log.Debug("After executing function: " + Name);
            if (result)
                Parent.Set<TransformationInterpreter>();
            if (result == false)
                Parent.Set<NamedShapeInterpreter>().Shape = null;
            return result;
        }

        /// <summary>
        ///   Serialize function's implementation
        /// </summary>
        /// <param name = "data">the container of serialized data</param>
        public override void Serialize(AttributeData data)
        {
            if (_function == null) return;
            data.WriteAttribute("Type", Name);
        }

        /// <summary>
        ///   Deserialize function's implementation
        /// </summary>
        /// <param name = "data">the container of serialized data</param>
        public override void Deserialize(AttributeData data)
        {
            Name = data.ReadAttributeString("Type");
            Execute();
        }

        #endregion
    }
}