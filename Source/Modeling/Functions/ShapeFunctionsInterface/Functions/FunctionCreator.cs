namespace ShapeFunctionsInterface.Functions
{
    public class FunctionCreator<T> : FunctionCreatorBase
        where T : FunctionBase, new()
    {
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override FunctionBase Create()
        {
            return new T();
        }
    }
}