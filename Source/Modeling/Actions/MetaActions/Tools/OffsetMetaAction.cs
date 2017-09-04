#region Usings

using System;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.IntTools;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Actions;

using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace MetaActions.Tools
{
    public class OffsetMetaAction : MetaActionBase
    {
        private bool _collectMouseInfo = true;
        private Mouse3DPosition _previousMouseClick;

        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            dependency.FunctionName = FunctionNames.Offset;

            dependency.AutoReset = true;

            dependency.Steps[1].OnCandidateUpdateHandler += DrawLiveOffset;
            dependency.OnStepsCompletedHandler += OffsetFinished;

            dependency.Steps[0].HintText = ModelingResources.OffsetStep1;
            dependency.Steps[1].HintText = ModelingResources.OffsetStep2;

            ConnectInput(dependency, InputNames.GeometricSolverPipe);
        }

        protected override void OnReceiveInputData(String inputName, Object data)
        {
            base.OnReceiveInputData(inputName, data);
            var dataPackage = (DataPackage)data;
            switch (inputName)
            {
                case InputNames.GeometricSolverPipe:
                    var mouseData = dataPackage.Get<Mouse3DPosition>();
                    // Store the last click
                    if (mouseData.MouseDown && _collectMouseInfo)
                    {
                        _previousMouseClick = mouseData;
                        _collectMouseInfo = false;
                    }
                    break;
            }
        }

        private void DrawLiveOffset(bool updateShape)
        {
            var builder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Offset) { EnableSelection = false };
            BuildOffset(builder);
        }

        private void OffsetFinished()
        {
            var builder = Dependency.DocumentNodeBuilder;
            BuildOffset(builder);
            _collectMouseInfo = true;
        }

        private void BuildOffset(NodeBuilder builder)
        {
            if (Dependency.Steps[1].Data is Mouse3DPosition)
            {
                var mouse = Dependency.Steps[1].Data as Mouse3DPosition;
                var face = TopoDS.Face(Dependency.Steps[0].Get<SceneSelectedEntity>().TargetShape());
                var direction = GetOffsetDirection(face, mouse.Point.GpPnt);
                Dependency.Steps[1].Data = mouse.Point.GpPnt.Distance(_previousMouseClick.Point.GpPnt) * direction;
            }

            builder[0].Reference = (Dependency.Steps[0].Get<SceneSelectedEntity>()).Node;
            builder[1].Real = Dependency.Steps[1].Get<double>();
            builder.ExecuteFunction();
        }

        /// <summary>
        ///   Detects if a point is inside or outside of a face
        /// </summary>
        /// <param name = "face"></param>
        /// <param name = "point"></param>
        /// <returns>-1 inside, 1 outside</returns>
        private static int GetOffsetDirection(TopoDSFace face, gpPnt point)
        {
            var classifier = new IntToolsContext();
            if (classifier.IsValidPointForFace(point, face, Precision.Confusion))
            {
                return -1;
            }

            return 1;
        }
    }
}