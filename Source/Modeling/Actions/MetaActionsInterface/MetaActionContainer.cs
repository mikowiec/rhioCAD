#region Usings

using System;
using System.Collections.Generic;
using ErrorReportCommon.Messages;
using log4net;
using NaroBasicPipes.Actions;
using NaroCAD.SolverModule.Interface;
using NaroConstants.Names;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Actions;
using OccCode;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace MetaActionsInterface
{
    public class MetaActionContainer : DrawingLiveShape
    {
        private readonly MetaActionBase _metaAction;

        public MetaActionContainer(string name, MetaActionBase metaAction)
            : base(name)
        {
            _metaAction = metaAction;
        }

        public override void OnRegister()
        {
            base.OnRegister();
            SetDependencies();
        }

        private void SetDependencies()
        {
            DependsOn(InputNames.RestrictedPlane);
            DependsOn(InputNames.CommandLinePrePusher);
            DependsOn(InputNames.FacePickerVisualFeedbackPipe);
            DependsOn(InputNames.CommandLineView, OnCommandLine);
            DependsOn(InputNames.CommandParser, OnCommandParser);
            DependsOn(InputNames.MirrorEntireScenePipe);
        }

        #region Private members

        private static readonly ILog Log = LogManager.GetLogger(typeof (MetaActionContainer));

        #endregion

        #region Properties

        public MetaActionDependencies Dependency
        {
            get { return _metaAction == null ? null : _metaAction.Dependency; }
        }

        #endregion

        #region Methods

        private bool _facePickerSuspended;

        private void OnCommandLine(DataPackage data)
        {
            Inputs[InputNames.CommandParser].Send(NotificationNames.HandleChangeCommand, data.Get<string>());
        }

        private void OnCommandParser(DataPackage data)
        {
            switch (data.Text)
            {
                case CoordinatateParserNames.ParsedValue:
                    PushValue(data.Data);
                    break;
                case CoordinatateParserNames.ChangeMetaAction:
                    ActionsGraph.SwitchAction(data.Get<string>());
                    break;
                case CoordinatateParserNames.Stop:
                    BackToNeutralModifier();
                    break;
            }
        }

        /// <summary>
        ///   Change the current meta action in the command line
        /// </summary>
        private void ChangeMetaAction()
        {
            var dependencyHost = new MetaActionDependencies(Document, AnimationDocument, ActionsGraph)
                                     {Inputs = ActionsGraph.InputContainer};
            _metaAction.SetupDependency(dependencyHost);
            _metaAction.FillDependencies();
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                           _metaAction.Dependency.SelectionMode);
            if (_metaAction.Dependency.FacePickerActivate)
                Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);

            Dependency.Reset();
            Inputs[InputNames.CommandParser].Send(NotificationNames.UpdateCommand, _metaAction);
            PrePushItems();
            LockPlaneToDraw();
        }

        private void PrePushItems()
        {
            var prePusher = Inputs[InputNames.CommandLinePrePusher];
            var result = (List<object>) prePusher.GetData(NotificationNames.GetValue).Data;
            foreach (var itemToPush in result)
                ForcePushValue(itemToPush);
            prePusher.Send(NotificationNames.Reset);
        }

        private void LockPlaneToDraw()
        {
            if (!Dependency.LockPlaneIfRequested) return;
            var restrictedPlaneInput = Inputs[InputNames.RestrictedPlane];
            var plane = restrictedPlaneInput.GetData(NotificationNames.GetPlane).Data;
            if (plane == null) return;
            var facePicker = Inputs[InputNames.FacePickerPlane];
            facePicker.Send(NotificationNames.LockPlane, plane);
        }

        protected override void OnTreeNodeSelect(Node node)
        {
            if (Dependency.StepName == InterpreterNames.Reference)
                ForcePushValue(new SceneSelectedEntity(node));
        }

        private void ForcePushValue(object data)
        {
            var dependency = _metaAction.Dependency;
            InitAnimateSession();
            dependency.ProposeCandidate(data, false);
            dependency.PushCandidate();

            if (dependency.StepIndex < dependency.Steps.Count)
            {
                Inputs[InputNames.CommandParser].Send(NotificationNames.UpdateParserStage);
                UpdateView();
                return;
            }
            UpdateParserAndView(dependency);
        }

        public void PushValue(object data)
        {
            if (data == null)
                return;

            // Try to propose to the meta action the parameter value
            var dependency = _metaAction.Dependency;
            //Dependency.Inputs.Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
            InitAnimateSession();

            if (!BridgedProposeDependency(data, dependency))
                return;

            var documentNodeBuilder = dependency.DocumentNodeBuilder;
            if (documentNodeBuilder != null &&
                documentNodeBuilder.LastExecute && dependency.StepName == InterpreterNames.Reference)
            {
                var dependencyNode = dependency.DocumentNodeBuilder[dependency.StepIndex];
                var step = dependency.Steps[dependency.StepIndex];
                dependencyNode.ReferenceData = step.Get<SceneSelectedEntity>();
                if (!dependencyNode.IsValid)
                {
                    NaroMessage.Show(@"Tool does not work with this shape");
                    return;
                }
            }
            if (data is Mouse3DPosition)
                Inputs[InputNames.CoordinateParser].Send(NotificationNames.SetLastPoint,
                                                         (data as Mouse3DPosition).Point);
            dependency.PushCandidate();

            UpdateParserAndView(dependency);
        }

        protected override void OnNodeSelect(Node node)
        {
            if (_metaAction.Dependency.StepName != InterpreterNames.Reference)
                return;
            var data = new SceneSelectedEntity(node);
            _metaAction.Dependency.Propose(data);
            PushValue(data);
        }

        private void UpdateParserAndView(MetaActionDependencies dependency)
        {
            if (dependency.StepIndex < dependency.Steps.Count)
            {
                Inputs[InputNames.CommandParser].Send(NotificationNames.UpdateParserStage);
                return;
            }

            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Cleanup);

            if (dependency.DocumentNodeBuilder != null && 
                dependency.DocumentNodeBuilder.LastExecute && dependency.DocumentNodeBuilder.ExecuteFunction())
            {
                CommitFinal("Draw " + dependency.FunctionName);
                AddNodeListToTree(dependency.AddToTreeOnComplete);
            }
            else
                dependency.Document.Revert();

            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);

            if (_metaAction.Dependency.StepIndex != _metaAction.Dependency.Steps.Count) return;
            if (_metaAction.Dependency.AutoReset)
            {
                _metaAction.Dependency.Reset();
                Inputs[InputNames.CommandParser].Send(NotificationNames.UpdateParserStage);
            }
            else
            {
                BackToNeutralModifier();
            }
        }

        /// <summary>
        ///   Unifies proposals that come from mouse and from command line.
        ///   ex: a height comes from command line as number, from mouse comes as 3D mouse coordinate
        /// </summary>
        /// <param name = "data"></param>
        /// <param name = "dependency"></param>
        /// <returns>Returns true if the dependency was proposed</returns>
        private bool BridgedProposeDependency(object data, MetaActionDependencies dependency)
        {
            switch (dependency.StepName)
            {
                case InterpreterNames.Real:
                    {
                        if (data is Mouse3DPosition)
                            ProposeMouseDependency(data as Mouse3DPosition, false);
                        else
                        {
                            var value = (double) data;
                            dependency.Propose(value);
                        }
                    }
                    break;
                case InterpreterNames.Integer:
                    {
                        if (data is int)
                        {
                            var value = (int) data;
                            dependency.Propose(value);
                        }
                    }
                    break;
                case InterpreterNames.Point3D:
                    {
                        if (data is Point3D)
                        {
                            var value = (Point3D) data;
                            dependency.Propose(value);
                        }
                        else if (data is Mouse3DPosition)
                            ProposeMouseDependency(data as Mouse3DPosition, false);
                    }
                    break;
                case InterpreterNames.Axis3D:
                    {
                        dependency.Propose(data);
                    }
                    break;
                case InterpreterNames.Reference:

                    break;
                case InterpreterNames.ReferenceList:
                    break;
            }

            return true;
        }

        public override void OnActivate()
        {
            base.OnActivate();
            ChangeMetaAction();
            var solverPipe = Inputs[InputNames.GeometricSolverPipe];
            solverPipe.GetData(NotificationNames.GetSolver).Get<GeometricSolver>();
        }

        /// <summary>
        ///   Called when notified that the FacPicker detected a new face selected.
        /// </summary>
        /// <param name = "face"></param>
        protected override void FacePicked(TopoDSFace face)
        {
            base.FacePicked(face);
            if (_metaAction == null) return;

            ProposeSelectedReferenceShape(face);
        }

        private void ProposeSelectedReferenceShape(TopoDSShape face)
        {
            var dependency = _metaAction.Dependency;
            if (dependency == null) return;
            if (dependency.StepName != InterpreterNames.Reference) return;
            SceneSelectedEntity selectedNode = null;
            if (face != null)
            {
                selectedNode = GeomUtils.IdentifyNode(Document.Root, face);
                if (selectedNode == null)
                    return;
            }
            else
            {
                var node = NodeBuilderUtils.IdentifySelectedObjectLabel(Document.Root);
                if (node != null)
                    selectedNode = new SceneSelectedEntity(node);
            }

            if (selectedNode == null) return;
            // The scene selected entity is hold as reference
            dependency.Propose(selectedNode, true);
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            //TODO: we have bogus logic that is possible to have enabled command line
            //We need to fix it
            if (_metaAction == null)
                return;

            if (!mouseData.MouseDown)
                return;
            try
            {
                if (Dependency.StepName == InterpreterNames.Reference)
                    if (Dependency.Steps[Dependency.StepIndex].Data == null)
                        ProposeSelectedReferenceShape(null);

                PushValue(mouseData);
            }
            catch (Exception ex)
            {
                NaroMessage.Show(@"Exception on mouse click: " + ex.Message);
            }
        }

        /// <summary>
        ///   Receives mouse move events. The mouse move can be made having a button pressed or not
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            //TODO: we have bogus logic that is possible to have enabled command line
            //We need to fix it
            if (_metaAction == null)
                return;

            if (mouseData.ControlDown && !_facePickerSuspended)
            {
                Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
                _facePickerSuspended = true;
            }
            if (!mouseData.ControlDown && _facePickerSuspended)
            {
                Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
                _facePickerSuspended = false;
            }

            try
            {
                InitAnimateSession();

                ProposeMouseDependency(mouseData, true);
              //  UpdateView();
            }
            catch (Exception ex)
            {
                Log.Info("CommandLineAction - mouse move error" + ex.Message);
            }
        }

        protected override void InitDocumentSession()
        {
            base.InitDocumentSession();
            Dependency.RefreshDocumentBuilder();
        }

        private void ProposeMouseDependency(Mouse3DPosition mouseData, bool updateShape)
        {
            var dependency = _metaAction.Dependency;
            switch (dependency.StepName)
            {
                case InterpreterNames.Point3D:
                    dependency.Propose(mouseData.Point, updateShape);
                    break;
                case InterpreterNames.Axis3D:
                    mouseData.Axis.Location = mouseData.Point.GpPnt;
                    dependency.Propose(mouseData.Axis, updateShape);
                    break;
                case InterpreterNames.Real:
                    dependency.Propose(mouseData, updateShape);
                    break;
            }

            //Inputs[InputNames.MirrorEntireScenePipe].Send(NotificationNames.Refresh, _metaAction.Dependency.AnimationNodeBuilder);
        }

        public override void OnDeactivate()
        {
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
            if (_metaAction != null)
            {
                if (_metaAction.Dependency.OnDisconnect != null)
                    _metaAction.Dependency.OnDisconnect();
                _metaAction.SetupDependency(null);
            }
            Inputs[InputNames.CommandLineView].Send(CoordinatateParserNames.SetHint, string.Empty);
            base.OnDeactivate();
        }

        #endregion
    }
}