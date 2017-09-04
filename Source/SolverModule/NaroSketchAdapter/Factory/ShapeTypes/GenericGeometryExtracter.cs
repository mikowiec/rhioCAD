#region Usings

using NaroCAD.SolverModule.Factory.ShapeTypes;
using NaroCAD.SolverModule.Helpers;
using NaroCAD.SolverModule.Interface.Geometry;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchAdapter.Factory.ShapeTypes
{
    public class GenericGeometryExtracter : SolverGeometryExtracter
    {
        public double AnglePrecision
        {
            get { return SolverOptions.GetDoubleValue(2); }
        }

        public bool ComputeParallelism
        {
            get { return SolverOptions.GetBoolValue(2); }
        }

        protected override bool Extract(SolverGeometricObject solverObject)
        {
            if (!ShapeUtils.HasShape(solverObject.Parent))
                return false;
            NodeHelper.BuildSolverInfo(solverObject, solverObject.Parent, AnglePrecision,
                                       ComputeParallelism);
            return true;
        }
    }
}