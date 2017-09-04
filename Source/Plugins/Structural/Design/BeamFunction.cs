#region Usings

using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;

using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace NaroCAD.Plugin.Structural.Design
{
    internal class BeamFunction : FunctionBase
    {
        public BeamFunction()
            : base(Constant.FunctionBeam)
        {
            // PropertyIndex
            Dependency.AddAttributeType(InterpreterNames.Integer);
            // 1. structural node
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // 2. structural node
            Dependency.AddAttributeType(InterpreterNames.Reference);
        }

        public override bool Execute()
        {
            var dependency = Builder.Node.Get<FunctionInterpreter>().Dependency;
            var firstData = dependency[Constant.StepIndexBeamFirstNode].ReferenceData;
            var firstNode = firstData.Node;
            var firstIndex = firstData.ShapeCount;
            var firstPointValue = ShapeUtils.ExtractShapesPoint(firstNode, firstIndex);
            var secondData = dependency[Constant.StepIndexBeamSecondNode].ReferenceData;
            var secondNode = secondData.Node;
            var secondIndex = secondData.ShapeCount;
            var secondPointValue = ShapeUtils.ExtractShapesPoint(secondNode, secondIndex);
            if (firstPointValue.IsEqual(secondPointValue, Precision.Confusion))
            {
                return false;
            }

            NodeUtils.Hide(firstNode);
            NodeUtils.Hide(secondNode);

            var aEdge = new BRepBuilderAPIMakeEdge(firstPointValue, secondPointValue).Edge;
            var wire = new BRepBuilderAPIMakeWire(aEdge).Wire;
            Shape = wire;

            return true;
        }
    }
}