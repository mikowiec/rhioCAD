#region Usings

using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;

using Resources.PartModelling;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActions.Tools
{
    public class TranslateMetaAction : MetaActionBase
    {
        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            Dependency.AddStepByName(InterpreterNames.Reference);
            Dependency.AddStepByName(InterpreterNames.Point3D);
            Dependency.AddStepByName(InterpreterNames.Point3D);
            dependency.Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            dependency.Steps[0].OnCandidateUpdateHandler += DisableSolver;
            dependency.Steps[2].OnCandidateUpdateHandler += DrawLiveTranslation;
            dependency.OnStepsCompletedHandler += TranslationFinished;

            Dependency.SelectionMode = TopAbsShapeEnum.TopAbs_SOLID;
            Dependency.FacePickerActivate = false;

            Dependency.Steps[0].HintText = ModelingResources.TranslateStep1;
            Dependency.Steps[1].HintText = ModelingResources.TranslateStep2;
            Dependency.Steps[2].HintText = ModelingResources.TranslateStep3;
        }

        private void DisableSolver(bool updateShape)
        {
            Dependency.Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.EnableAll);
        }

        private void DrawLiveTranslation(bool updateShape)
        {
            BuildTranslation();
            MetaActionDependencies.DimensionAnimation(Dependency.AnimationDocument, Dependency.Steps[1].Get<Point3D>(),
                                                      Dependency.Steps[2].Get<Point3D>());
        }

        private void TranslationFinished()
        {
            BuildTranslation();
            Dependency.Document.Commit("Translate");
        }

        private void BuildTranslation()
        {
            ReturnToInitialDocumentState();
            var referenceShape = Dependency.Steps[0].Get<SceneSelectedEntity>();
            var currTransformation = referenceShape.Node.Get<TransformationInterpreter>();
            var startCoordinate = Dependency.Steps[1].Get<Point3D>();
            var endCoordinate = Dependency.Steps[2].Get<Point3D>();
            var diffCoordinate = endCoordinate.SubstractCoordinate(startCoordinate);

            diffCoordinate.X += currTransformation.Translate.X;
            diffCoordinate.Y += currTransformation.Translate.Y;
            diffCoordinate.Z += currTransformation.Translate.Z;
            currTransformation.Translate = diffCoordinate.GpPnt;
        }

        private void ReturnToInitialDocumentState()
        {
            Dependency.Document.Revert();
            Dependency.Document.Transact();
        }
    }
}