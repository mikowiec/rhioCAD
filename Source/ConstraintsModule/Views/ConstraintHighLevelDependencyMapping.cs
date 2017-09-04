#region Usings

using System.Collections.Generic;

#endregion

namespace ConstraintsModule.Views
{
    public class ConstraintHighLevelDependencyMapping
    {
        private readonly SortedDictionary<string, ConstraintDependencyDescription> _constraints;

        public ConstraintHighLevelDependencyMapping()
        {
            _constraints = new SortedDictionary<string, ConstraintDependencyDescription>();
        }

        public SortedDictionary<string, ConstraintDependencyDescription> Constraints
        {
            get { return _constraints; }
        }

        public void Register(string constraintName, string descriptor, string iconPicture, string firstDependency,
                             string secondDependency)
        {
            var constraint = new ConstraintDependencyDescription(constraintName)
                                 {
                                     Descriptor = descriptor,
                                     IconPicture = iconPicture
                                 };
            constraint.DependOn(firstDependency);
            constraint.DependOn(secondDependency);
            Constraints[constraintName] = constraint;
        }

        public void Register(string constraintName, string descriptor, string iconPicture, string firstDependency)
        {
            var constraint = new ConstraintDependencyDescription(constraintName)
                                 {
                                     Descriptor = descriptor,
                                     IconPicture = iconPicture
                                 };
            constraint.DependOn(firstDependency);
            Constraints[constraintName] = constraint;
        }

        private static bool AreEqualLists(List<string> list1, List<string> list2)
        {
            if (list1.Count != list2.Count)
                return false;
            var count = list1.Count;
            var sourceArray = new List<string>(list1);
            sourceArray.Sort();
            var destArray = new List<string>(list2);
            destArray.Sort();
            for (var i = 0; i < count; i++)
            {
                if (sourceArray[i] != destArray[i])
                    return false;
            }
            return true;
        }

        public List<string> AccessibleConstraints(List<string> functionNames)
        {
            var result = new List<string>();
            foreach (var constraint in Constraints.Values)
            {
                if (AreEqualLists(functionNames, constraint.DependencyList))
                    result.Add(constraint.FunctionName);
            }
            return result;
        }

        public ConstraintDependencyDescription GetConstraintDescription(string constraintFunction)
        {
            return Constraints[constraintFunction];
        }
    }
}