#region Usings

using TreeData.AttributeInterpreter.TypeHelpers;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class TreeViewVisibilityInterpreter : NaroDataInterpreter
    {
        public TreeViewVisibilityInterpreter()
        {
            DummyVal = 3;
        }

        public int DummyVal { get; private set; }
    }
}