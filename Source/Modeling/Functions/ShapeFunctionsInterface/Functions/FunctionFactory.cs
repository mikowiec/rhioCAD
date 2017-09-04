#region Usings

using System.Collections.Generic;

#endregion

namespace ShapeFunctionsInterface.Functions
{
    internal sealed class FunctionFactory : IFunctionFactory
    {
        #region Data members

        private static readonly FunctionFactory SingletonInstance = new FunctionFactory();

        public static IFunctionFactory Instance
        {
            get { return SingletonInstance; }
        }

        #endregion

        #region Default constructor

        /// <summary>
        ///   default constuctor
        /// </summary>
        private FunctionFactory()
        {
            Functions = new SortedDictionary<int, FunctionCreatorBase>();
        }

        #endregion

        #region Properties

        #endregion

        #region Members

        /// <summary>
        ///   Register a new function shape that can be created after that
        /// </summary>
        public override void Register<T>()
        {
            var creator = new FunctionCreator<T>();
            SingletonInstance.Functions[creator.Create().Name.GetHashCode()] = creator;
        }

        /// <summary>
        ///   Gets the given function based on it's name
        /// </summary>
        /// <param name = "functionNameId"></param>
        /// <returns></returns>
        public override FunctionBase Get(int functionNameId)
        {
            return !SingletonInstance.Functions.ContainsKey(functionNameId)
                       ? null
                       : SingletonInstance.Functions[functionNameId].Create();
        }

        #endregion
    }
}