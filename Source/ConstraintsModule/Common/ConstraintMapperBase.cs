#region Usings

using System.Collections.Generic;
using ConstraintsModule.Primitives;
using NaroSketchAdapter.Common;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;
//using CleanSolver.SolverSystem;
//using SketchSolve.Primitives;

#endregion

namespace ConstraintsModule.Common
{
    public abstract class ConstraintMapperBase : ISolverConstraintMapping
    {
        protected NodeBuilder Builder;
        protected ConstraintContainer ConstraintList;
        protected ConstraintRefContainer ConstraintRefList;
        //protected Sketch3DTo2DTranslator CoordinateTranslator;
        protected Dictionary<int, object> GlobalObjectMapping;
        protected List<DoubleRefObject> Parameters;

        protected Dictionary<int, int> ShapeToParamIndex;

        protected Document Document;

        #region ISolverConstraintMapping Members

        //public void Map(NodeBuilder builder, List<DoubleRefObject> parameters,
        //                Dictionary<int, object> globalObjectMapping, Sketch3DTo2DTranslator coordinateTranslator,
        //                ConstraintContainer constraintList)
        //{
        //    Builder = builder;
        //    Parameters = parameters;
        //    GlobalObjectMapping = globalObjectMapping;
        //    CoordinateTranslator = coordinateTranslator;
        //    ConstraintList = constraintList;
        //   // MapToSolver();
        //}

        public List<ConstraintRefBase> MapRef(Document document, NodeBuilder builder, Dictionary<int, int> shapeToParamIndex)
        {
            Builder = builder;
            Document = document;
            ShapeToParamIndex = shapeToParamIndex;
            return MapToSolverRef();
        }

        #endregion

        //protected abstract void MapToSolver();

        protected abstract List<ConstraintRefBase> MapToSolverRef();

        protected T MappedObject<T>(int referencePoint0)
        {
            return (T) GlobalObjectMapping[referencePoint0];
        }

        protected DoubleRefObject AddParameter(double value)
        {
            var result = new DoubleRefObject(value);
            Parameters.Add(result);
            return result;
        }

        protected DoubleRefObject AddIndexParameter(int position)
        {
            return AddParameter(Builder[position].Real);
        }

        protected T MappedReference<T>(int referenceIndex)
        {
            var referenceData = Builder[referenceIndex].Reference.Index;
            return MappedObject<T>(referenceData);
        }

        protected void AddConstraint(ConstraintBase constraint)
        {
            ConstraintList.Add(constraint);
        }

        protected void AddRefConstraint(ConstraintRefBase constraint)
        {
            ConstraintRefList.Add(constraint);
        }
    }
}