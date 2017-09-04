#region Usings

using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopAbs;

using Resources.PartModelling;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace MetaActions.Tools
{
    public class AngleDraftMetaAction : MetaActionBase
    {
        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            dependency.FunctionName = FunctionNames.AngleDraft;
            dependency.SelectionMode = TopAbsShapeEnum.TopAbs_FACE;

            dependency.Steps[0].OnCandidateUpdatePreprocessHandler += DraftFaceSelection;
            dependency.Steps[1].OnCandidateUpdatePreprocessHandler += DraftReferencePlaneSelection;
            dependency.Steps[3].OnCandidateUpdatePreprocessHandler += DrawAngle;
            dependency.OnStepsCompletedHandler += DraftingFinished;

            dependency.Steps[2].Data = new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
            dependency.Steps[2].IsDefaultValue = true;

            dependency.AutoReset = false;

            Dependency.Steps[0].HintText = ModelingResources.AngleDraftStep1;
            Dependency.Steps[1].HintText = ModelingResources.AngleDraftStep2;
            Dependency.Steps[3].HintText = ModelingResources.AngleDraftStep3;
        }

        private void DraftFaceSelection(bool updateShape)
        {
            var sceneSelectedEntity = (SceneSelectedEntity) Dependency.Steps[0].Data;
            Ensure.IsTrue(sceneSelectedEntity.ShapeType == TopAbsShapeEnum.TopAbs_FACE, "Invalid face");
        }

        private void DraftReferencePlaneSelection(bool updateShape)
        {
            var sceneSelectedEntity = (SceneSelectedEntity) Dependency.Steps[1].Data;
            Ensure.IsTrue(sceneSelectedEntity.ShapeType == TopAbsShapeEnum.TopAbs_FACE, "Invalid face");
        }

        private void DrawAngle(bool updateShape)
        {
            if (Dependency.Steps[3].Data is Mouse3DPosition)
            {
                var currentPoint = Dependency.Steps[3].Get<Mouse3DPosition>().Point;
                Dependency.Steps[3].Data = 10;
            }
            else if (Dependency.Steps[3].Data is Point3D)
            {
                var currentPoint = Dependency.Steps[3].Get<Point3D>();
                Dependency.Steps[3].Data = 10;
            }
        }

        private void DraftingFinished()
        {
            var builder = Dependency.DocumentNodeBuilder;
            builder[0].ReferenceData = Dependency.Steps[0].Get<SceneSelectedEntity>();
            builder[1].ReferenceData = Dependency.Steps[1].Get<SceneSelectedEntity>();
            builder[2].Axis3D = new Axis(Dependency.Steps[2].Get<gpAx1>());
            builder[3].Real = Dependency.Steps[2].Get<double>();
            builder.EnableSelection = true;
            builder.ExecuteFunction();
        }
    }
}