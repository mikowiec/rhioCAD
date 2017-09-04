#region Usings

using System.Collections.Generic;
using ConstraintsModule.Common;
using NaroConstants.Names;
using ShapeFunctionsInterface.Utils;

#endregion

namespace ConstraintsModule.Mappings.Constraints.Common
{
    internal abstract class TwoShapesConstraintMapper<TShape1, TShape2> : ConstraintMapperBase
    {
        protected TShape1 First { get; private set; }
        protected TShape2 Second { get; private set; }

        protected int P1 { get; private set; }
        protected int P2 { get; private set; }
        protected int P3 { get; private set; }
        protected int P4 { get; private set; }

        // line points
        protected int L1P1 { get; private set; }
        protected int L1P2 { get; private set; }
        protected int L2P1 { get; private set; }
        protected int L2P2 { get; private set; }

        // arc points
        protected int A1P1 { get; private set; }
        protected int A1P2 { get; private set; }
        protected int A1P3 { get; private set; }
        protected int A2P1 { get; private set; }
        protected int A2P2 { get; private set; }
        protected int A2P3 { get; private set; }

        // circle centres
        protected int C1 { get; private set; }
        protected int C2 { get; private set; }

        protected Dictionary<int, int> shapeToParamIndex;

        //protected override void MapToSolver()
        //{
        //    First = MappedReference<TShape1>(0);
        //    Second = MappedReference<TShape2>(1);
        //    var constraint = ConstraintBuild();
        //    AddConstraint(constraint);
        //}

        protected override List<ConstraintRefBase> MapToSolverRef()
        {
            var firstShape = new NodeBuilder(Document.Root[Builder[0].Reference.Index]);
            var secondShape = new NodeBuilder(Document.Root[Builder[1].Reference.Index]);

            if (firstShape.FunctionName == secondShape.FunctionName)
            {
                if (firstShape.FunctionName == FunctionNames.Circle)
                {
                    C1 = firstShape.Node.Index;
                    C2 = secondShape.Node.Index;
                }
                else
                if (firstShape.FunctionName == FunctionNames.LineTwoPoints)
                {
                    L1P1 = firstShape.Dependency[0].Reference.Index;
                    L1P2 = firstShape.Dependency[1].Reference.Index;
                    L2P1 = secondShape.Dependency[0].Reference.Index;
                    L2P2 = secondShape.Dependency[1].Reference.Index;
                }
                else
                if (firstShape.FunctionName == FunctionNames.Point)
                {
                    P1 = firstShape.Node.Index;
                    P2 = secondShape.Node.Index;
                }
                else
                    if (firstShape.FunctionName == FunctionNames.Arc)
                    {
                        A1P1 = firstShape.Dependency[0].Reference.Index;
                        A1P2 = firstShape.Dependency[1].Reference.Index;
                        A1P3 = firstShape.Dependency[2].Reference.Index;
                        A2P1 = secondShape.Dependency[0].Reference.Index;
                        A2P2 = secondShape.Dependency[1].Reference.Index;
                        A2P3 = secondShape.Dependency[2].Reference.Index;
                    }
            }
            else
            {
                if(firstShape.FunctionName == FunctionNames.LineTwoPoints || secondShape.FunctionName == FunctionNames.LineTwoPoints)
                {
                    var shape = firstShape.FunctionName == FunctionNames.LineTwoPoints ? firstShape : secondShape;
                    L1P1 = shape.Dependency[0].Reference.Index;
                    L1P2 = shape.Dependency[1].Reference.Index;
                }
         
                if (firstShape.FunctionName == FunctionNames.Point || secondShape.FunctionName == FunctionNames.Point)
                {
                    var shape = firstShape.FunctionName == FunctionNames.Point ? firstShape : secondShape;
                    P1 = shape.Node.Index;
                }
                
                 if (firstShape.FunctionName == FunctionNames.Arc || secondShape.FunctionName == FunctionNames.Arc)
                 {
                     var shape = firstShape.FunctionName == FunctionNames.Arc ? firstShape : secondShape;
                     A1P1 = shape.Dependency[0].Reference.Index;
                     A1P2 = shape.Dependency[1].Reference.Index;
                     A1P3 = shape.Dependency[2].Reference.Index;
                 }

               if (secondShape.FunctionName == FunctionNames.Circle || firstShape.FunctionName == FunctionNames.Circle)
                {
                    var shape = firstShape.FunctionName == FunctionNames.Circle ? firstShape : secondShape;
                    C1 = shape.Node.Index;
                }
            }
            shapeToParamIndex = ShapeToParamIndex;
           return ConstraintRefBuild();
        }

        protected abstract List<ConstraintRefBase> ConstraintRefBuild();
    }
}