#region Usings

using System;
using System.Drawing;
using System.Windows.Controls;
using ErrorReportCommon.Messages;
using MetaActionsInterface;
using NaroConstants.Names;
using PartModellingUi.Views.Tools;
using Resources.PartModelling;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActions.Shapes
{
    public class SplineMetaAction : MetaActionBase
    {
        private bool _multiplePointsWarningShown;
        private int _solvedSteps;

        protected override void FillUiDependencies()
        {
            Dependency.FunctionName = FunctionNames.Spline;

            var actionsGraph = Dependency.ActionsGraph;
            try
            {
                var ribbonPanel = actionsGraph[InputNames.FastToolbarInput].Get<StackPanel>();
                var fastAccessTools = new SplineFastAccessTools(actionsGraph);
                ribbonPanel.Children.Add(fastAccessTools);
            }
            catch (Exception)
            {
               
            }

            Dependency.AddStepByName(InterpreterNames.Point3D);
            Dependency.AddStepByName(InterpreterNames.Point3D);

            Dependency.Steps[0].OnCandidateUpdateHandler += OnCandidateUpdate;
            Dependency.Steps[0].HintText = ModelingResources.SplineStep1;
            Dependency.Steps[1].OnCandidateUpdateHandler += OnCandidateUpdate;
            Dependency.Steps[1].HintText = ModelingResources.SplineStep2;

            Dependency.AutoFace = true;
            Dependency.AutoReset = false;

            Dependency.OnDisconnect += OnDeactivate;

            _solvedSteps = 0;

            var mouseCursorInput = Dependency.Inputs.Inputs[InputNames.MouseCursorInput];
            mouseCursorInput.Send(NotificationNames.SetResourceManager, MetaActionResource.ResourceManager);
            mouseCursorInput.Send(NotificationNames.SetCursorName, "spline.cur");
            _multiplePointsWarningShown = false;
        }

        private void OnCandidateUpdate(bool updateShape)
        {
            if (Dependency.StepIndex == 0)
                return;
            if (Dependency.StepIndex == 20 && !_multiplePointsWarningShown)
            {
                _multiplePointsWarningShown = true;
                NaroMessage.Show(
                    "The count of points of your spline is big. You can draw more points but some visualisation problems may occur!");
            }
            Dependency.AnimationNodeBuilder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Spline);
            var nb = Dependency.AnimationNodeBuilder.Node.Get<FunctionInterpreter>();
            var dnb = Dependency.DocumentNodeBuilder.Node.Get<FunctionInterpreter>();
            foreach (var step in Dependency.Steps)
            {
                var data = step.Get<Point3D?>();
                if (data == null) continue;
                nb.Dependency.AddAttributeType(InterpreterNames.Point3D);
                dnb.Dependency.AddAttributeType(InterpreterNames.Point3D);
                var pos = nb.Dependency.Count - 1;
                nb.Dependency.Children[pos].TransformedPoint3D = (Point3D) data;
                dnb.Dependency.Children[pos].TransformedPoint3D = (Point3D) data;
            }
            var animationBuilder = Dependency.AnimationNodeBuilder;
            animationBuilder.Color = Color.Red;
            animationBuilder.Transparency = 0.2;
            nb.Execute();
            if (Dependency.StepIndex == _solvedSteps)
                return;
            _solvedSteps = Dependency.StepIndex;

            Dependency.AddStepByName(InterpreterNames.Point3D);
            var index = Dependency.StepIndex - 1;
            UnregisterUpdate(index);
            index = Dependency.StepIndex + 1;
            RegisterUpdate(index);
            Dependency.Steps[Dependency.StepIndex + 1].HintText = ModelingResources.SplineStep2;
            if (!_multiplePointsWarningShown || Dependency.StepIndex != 25) return;
            _multiplePointsWarningShown = false;
            NaroMessage.Show(
                "Maximum spline point count exceeded. Spline shape will be stopped. Please start another spline.");
        }

        private void RegisterUpdate(int index)
        {
            Dependency.Steps[index].OnCandidateUpdateHandler += OnCandidateUpdate;
        }

        private void UnregisterUpdate(int index)
        {
            Dependency.Steps[index].OnCandidateUpdateHandler -= OnCandidateUpdate;
        }

        private void OnDeactivate()
        {
            if (Dependency.Steps.Count < 4)
            {
                NodeBuilderUtils.DeleteNode(Dependency.DocumentNodeBuilder.Node, Dependency.Document);
                Dependency.Document.Revert();
                return;
            }
            Dependency.Document.Transact();
            Dependency.DocumentNodeBuilder = new NodeBuilder(Dependency.Document, FunctionNames.Spline);
            var builder = Dependency.DocumentNodeBuilder;

            Dependency.Steps.RemoveAt(Dependency.Steps.Count - 1);
            Dependency.Steps.RemoveAt(Dependency.Steps.Count - 1);
            var nb = builder.Node.Get<FunctionInterpreter>();
            foreach (var step in Dependency.Steps)
            {
                var data = step.Get<Point3D?>();
                if (data == null) continue;
                nb.Dependency.AddAttributeType(InterpreterNames.Point3D);
                var pos = builder.Count - 1;
                nb.Dependency.Children[pos].TransformedPoint3D = (Point3D) data;
            }
            builder.ExecuteFunction();

            if (Dependency.StepIndex != 0)
                UnregisterUpdate(Dependency.StepIndex - 1);
            Dependency.Document.Commit("Draw Spline");
            Dependency.ActionsGraph[InputNames.UiElementsItem].Send(NotificationNames.AddNewNodeToTree,
                                                                    Dependency.DocumentNodeBuilder.Node);
            Dependency.OnDisconnect = null;
        }
    }
}