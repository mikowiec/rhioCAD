#region Usings

using System.Collections.Generic;

#endregion

namespace ConstraintsModule.Views
{
    public class ConstraintDependencyDescription
    {
        public ConstraintDependencyDescription(string functionName)
        {
            DependencyList = new List<string>();
            FunctionName = functionName;
        }

        public void DependOn(string dependency)
        {
            DependencyList.Add(dependency);
        }

        #region Properties

        public string FunctionName { get; private set; }
        public List<string> DependencyList { get; private set; }

        public string Descriptor { get; set; }

        public string IconPicture { get; set; }

        #endregion
    }
}