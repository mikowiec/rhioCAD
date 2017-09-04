#region Usings

using MetaActionsInterface;
using NaroConstants.Names;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace NaroCAD.Plugin.Structural.Design
{
    public class BeamAction : MetaActionBase
    {
        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            dependency.FunctionName = Constant.FunctionBeam;
            dependency.FacePickerActivate = false;
            // properties Index is 0 for the moment
            dependency.Steps[Constant.StepIndexBeamProperty].Integer = 0;
            dependency.Steps[Constant.StepIndexBeamProperty].IsDefaultValue = true;
            dependency.Steps[Constant.StepIndexBeamFirstNode].HintText = "Select first point";
            dependency.Steps[Constant.StepIndexBeamFirstNode].OnCandidateUpdatePreprocessHandler += OnFirstSelection;
            dependency.Steps[Constant.StepIndexBeamSecondNode].HintText = "Select second point";
            dependency.Steps[Constant.StepIndexBeamSecondNode].OnCandidateUpdatePreprocessHandler += OnSecondSelection;
            dependency.AutoReset = false;
        }

        private void OnFirstSelection(bool updateShape)
        {
            OnPointSelection(1);
        }

        private void OnSecondSelection(bool updateShape)
        {
            OnPointSelection(2);
        }

        private void OnPointSelection(int stepIndex)
        {
            var source = Dependency.Steps[stepIndex].Get<SceneSelectedEntity>();
            var shapeNode = source.Node;
            Ensure.IsTrue(FunctionUtils.GetFunctionName(shapeNode) == FunctionNames.Point, "Invalid point");
            var builder = Dependency.DocumentNodeBuilder;
            builder[stepIndex].ReferenceData = source;
        }
    }
}