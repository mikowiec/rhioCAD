#region Usings

using NaroConstants.Names;

using ShapeFunctionsInterface.Functions;
using NaroCppCore.Occ.Precision;

#endregion

namespace ShapeFunctions.Constraints.Naro
{
    public class CoLocationConstraint : FunctionBase
    {
        public CoLocationConstraint() : base(FunctionNames.CoLocationConstraint)
        {
            // Reference shape on source shape
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Source point intentifier
            Dependency.AddAttributeType(InterpreterNames.Integer);
            // Reference shape on destination shape
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Destination (follower) point intentifier
            Dependency.AddAttributeType(InterpreterNames.Integer);
        }

        public override bool Execute()
        {
            // Reference shape on source shape
            var refSource = Dependency[0].Reference;
            var funcSource = refSource.Get<FunctionInterpreter>();
            // Source point intentifier
            var pointSource = Dependency[1].Integer;
            // Reference shape on destination shape
            var refDestination = Dependency[2].Reference;
            var funcDestination = refDestination.Get<FunctionInterpreter>();
            // Destination (following) point intentifier
            var pointDestination = Dependency[3].Integer;

            var srcPoint = funcSource.Dependency[pointSource].TransformedPoint3D;
            var destPoint = funcDestination.Dependency[pointDestination].TransformedPoint3D;
            if (!srcPoint.GpPnt.IsEqual(destPoint.GpPnt, Precision.Confusion))
                funcSource.Dependency[pointSource].TransformedPoint3D = destPoint;

            return true;
        }
    }
}