#region Usings

using System.Collections.Generic;

#endregion

namespace ShapeFunctionsInterface.Functions
{
    public abstract class IFunctionFactory
    {
        /// <summary>
        ///   the factory mapping between name and function itself
        /// </summary>
        protected SortedDictionary<int, FunctionCreatorBase> Functions { get; set; }

        public abstract void Register<T>() where T : FunctionBase, new();

        public void RegisterCustomCreator(FunctionCreatorBase functionInstance, string functionName)
        {
            Functions[functionName.GetHashCode()] = functionInstance;
        }

        /// <summary>
        ///   Gets the given function based on it's name
        /// </summary>
        /// <param name = "functionNameId"></param>
        /// <returns></returns>
        public abstract FunctionBase Get(int functionNameId);
    }
}