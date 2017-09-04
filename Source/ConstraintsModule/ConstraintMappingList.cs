#region Usings

using System.Collections.Generic;
using ConstraintsModule.Common;
using NaroSketchAdapter.Common;

#endregion

namespace ConstraintsModule
{
    public class ConstraintMappingList
    {
        public readonly SortedDictionary<string, ISolverConstraintMapping> ShapeConstraintObjectMapping;

        public ConstraintMappingList()
        {
            ShapeConstraintObjectMapping = new SortedDictionary<string, ISolverConstraintMapping>();
        }

        private void Register(string functionName, ISolverConstraintMapping mapper)
        {
            ShapeConstraintObjectMapping[functionName] = mapper;
        }


        internal void Register<T>(string constraintName) where T : ConstraintMapperBase, new()
        {
            Register(constraintName, new T());
        }
    }
}