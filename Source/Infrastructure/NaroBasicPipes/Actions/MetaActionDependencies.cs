#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using log4net;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;
using OccCode;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroBasicPipes.Actions
{
    /// <summary>
    ///   Contains a collection of input completion values
    /// </summary>
    public class MetaActionDependencies
    {
        #region Properties

        public List<Step> Steps { get; private set; }
        public int StepIndex { get; private set; }

        public string StepName
        {
            get { return StepIndex >= Steps.Count ? null : Steps[StepIndex].Name; }
        }

        public string StepHint
        {
            get { return StepIndex >= Steps.Count ? null : Steps[StepIndex].HintText; }
        }

        public bool AutoReset { get; set; }
        public TopAbsShapeEnum SelectionMode { get; set; }
        public bool FacePickerActivate { get; set; }
        public Document Document { get; private set; }
        public Document AnimationDocument { get; private set; }
        public InputFactory Inputs { get; set; }
        public NodeBuilder AnimationNodeBuilder { get; set; }
        public NodeBuilder DocumentNodeBuilder { get; set; }
        public List<Node> AddToTreeOnComplete { get; private set; }
        public bool LockPlaneIfRequested { get; set; }

        public string FunctionName
        {
            get { return _functionName; }
            set { SetFunctionName(value); }
        }

        public bool AutoFace { private get; set; }

        #endregion

        #region private members

        private static readonly ILog Log = LogManager.GetLogger(typeof (MetaActionDependencies));
        private FunctionBase _function;
        private string _functionName;

        #endregion

        #region Step internal class

        public class Step
        {
            #region Constructor

            public Step(string name)
            {
                Name = name;
            }

            #endregion

            #region Events

            #region Delegates

            public delegate void OnCandidateUpdateEvent(bool updateShape);

            #endregion

            public OnCandidateUpdateEvent OnCandidateUpdateHandler;
            public OnCandidateUpdateEvent OnCandidateUpdatePreprocessHandler;

            #endregion

            #region Properties

            public object Data { get; set; }
            public string Name { get; private set; }
            public bool IsDefaultValue { get; set; }

            public int Integer
            {
                get { return (int) ((int?) Data); }
                set { Set((int?) value); }
            }

            public double Real
            {
                get { return (double) ((double?) Data); }
                set { Set((double?) value); }
            }

            /// <summary>
            ///   Text used for hint label
            /// </summary>
            public String HintText { get; set; }

            #endregion

            #region Methods

            public T Get<T>()
            {
                return (T) Data;
            }

            private void Set<T>(T value)
            {
                Data = value;
            }

            #endregion
        }

        #endregion

        #region OnStepsCompletedHandler

        #region Delegates

        public delegate void OnStepsCompletedEvent();

        #endregion

        //public OnStepsCompletedEvent OnLastDocumentHandler;
        public OnStepsCompletedEvent OnDisconnect;
        public OnStepsCompletedEvent OnStepsCompletedHandler;

        #endregion

        #region Constructor

        public MetaActionDependencies(Document document, Document animationDocument, ActionsGraph actionsGraph)
        {
            Steps = new List<Step>();
            AddToTreeOnComplete = new List<Node>();
            Document = document;
            AnimationDocument = animationDocument;
            SelectionMode = TopAbsShapeEnum.TopAbs_SOLID;
            FacePickerActivate = true;
            ActionsGraph = actionsGraph;
        }

        #endregion

        #region Methods

        public ActionsGraph ActionsGraph { get; private set; }

        private void SetFunctionName(string functionName)
        {
            var functionFactory =
                ActionsGraph[InputNames.FunctionFactoryInput].GetData(NotificationNames.GetValue).Get<IFunctionFactory>();

            _function = functionFactory.Get(functionName.GetHashCode());
            _functionName = functionName;
            var dep = _function.Dependency;
            Steps = new List<Step>();
            foreach (var depChild in dep.Children)
            {
                var depName = depChild.Name;
                AddStepByName(depName);
            }
        }

        public void AddStepByName(string depName)
        {
            Steps.Add(new Step(depName));
        }

        private void OnStepsCompleted()
        {
            if (OnStepsCompletedHandler != null)
            {
                OnStepsCompletedHandler();
            }
            else
            {
                AutoCompleteDependencies();
            }
            if (DocumentNodeBuilder!= null && DocumentNodeBuilder.LastExecute)
                AddToTreeOnComplete.Add(DocumentNodeBuilder.Node);
            if (!AutoFace) return;
            var autoFaceNode = AutoGroupLogic.TryAutoGroup(Document, DocumentNodeBuilder.Node);
            if (autoFaceNode != null)
                AddToTreeOnComplete.Add(autoFaceNode);
        }

        private void AutoCompleteAnimateDependencies()
        {
            if (string.IsNullOrEmpty(_functionName))
                return;
            AnimationNodeBuilder = new NodeBuilder(AnimationDocument, _functionName)
                                       {
                                           EnableSelection = false,
                                           Color = Color.Red,
                                           DisplayMode = AISDisplayMode.AIS_WireFrame,
                                           Transparency = 0.2
                                       };
            AutoFillBuilder(AnimationNodeBuilder);
        }

        private void AutoCompleteDependencies()
        {
            if (DocumentNodeBuilder == null || DocumentNodeBuilder.Node == null) return;
            DocumentNodeBuilder = AutoFillBuilder(DocumentNodeBuilder);
            if (!DocumentNodeBuilder.LastExecute) Document.Revert();
        }

        private NodeBuilder AutoFillBuilder(NodeBuilder nodeBuilder)
        {
            var childId = 0;
            foreach (var step in Steps)
            {
                switch (step.Name)
                {
                    case InterpreterNames.Integer:
                        nodeBuilder[childId].Integer = step.Integer;
                        break;
                    case InterpreterNames.Real:
                        if (step.Data is double?)
                        {
                            nodeBuilder[childId].Real = step.Real;
                        }
                        break;
                    case InterpreterNames.TransformedPoint3D:
                        nodeBuilder[childId].TransformedPoint3D = step.Get<Point3D>();
                        break;
                    case InterpreterNames.Axis3D:
                        nodeBuilder[childId].Axis3D = new Axis(step.Get<gpAx1>());
                        break;
                    case InterpreterNames.Reference:
                        var selectedEntity = step.Get<SceneSelectedEntity>();
                        if (selectedEntity != null)
                        {
                            nodeBuilder[childId].Reference = selectedEntity.Node;
                            //RestoreNodeSelectionValues();
                        }
                        break;
                    default:
                        throw new Exception("Cannot provide dependency: " + step.Name);
                }
                childId++;
            }
            nodeBuilder.ExecuteFunction();
            return nodeBuilder;
        }

        public void ProposeCandidate(object data)
        {
            ProposeCandidate(data, true);
        }

        public void ProposeCandidate(object data, bool updateShape)
        {
            while (Steps[StepIndex].IsDefaultValue)
            {
                StepIndex++;
            }
            Steps[StepIndex].Data = data;
            if (Steps[StepIndex].OnCandidateUpdatePreprocessHandler != null)
            {
                Steps[StepIndex].OnCandidateUpdatePreprocessHandler(updateShape);
            }
            else
            {
                AutoPreprocessData();
            }

            if (Steps[StepIndex].OnCandidateUpdateHandler == null)
            {
                AutoDrawDependencies();
            }
            if (StepIndex < Steps.Count && Steps[StepIndex].OnCandidateUpdateHandler != null)
            {
                Steps[StepIndex].OnCandidateUpdateHandler(updateShape);
            }
        }

        private static void DrawPoint(Document document, Point3D position)
        {
            var builder = new NodeBuilder(document, FunctionNames.Point);
            builder[1].TransformedPoint3D = position;
            builder.ExecuteFunction();
        }

        private void DrawLine(Document document, Point3D start, Point3D stop)
        {
            var builder = new NodeBuilder(document, FunctionNames.DottedLine);
            ApplyAnimationSettings(builder.Node);
            builder[0].TransformedPoint3D = start;
            builder[1].TransformedPoint3D = stop;
            builder.ExecuteFunction();
        }

        private void DrawRectangle(Document document, gpAx1 axis, Point3D first)
        {
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            ApplyAnimationSettings(builder.Node);
            builder[0].Axis3D = new Axis(axis);
            builder[1].TransformedPoint3D = first;
            builder.ExecuteFunction();
        }

        public static void DimensionAnimation(Document document, Point3D firstPoint, Point3D secondPoint)
        {
            var animationBuilder = new NodeBuilder(document, FunctionNames.PointsDimension);
            animationBuilder[0].TransformedPoint3D = firstPoint;
            animationBuilder[1].TransformedPoint3D = secondPoint;
            var textLocation = GeomUtils.ComputeMidPoint(firstPoint, secondPoint);
            textLocation.X++;
            textLocation.Y++;
            textLocation.Z++;
            animationBuilder[2].TransformedPoint3D = textLocation;
            animationBuilder.EnableSelection = false;
            animationBuilder.Color = Color.Red;
            animationBuilder.ExecuteFunction();
        }

        private void AutoPreprocessData()
        {
            if (Steps[StepIndex].Name != InterpreterNames.Axis3D) return;
            if (Steps[StepIndex].Data is Point3D)
            {
                var axis = new gpAx1(Steps[StepIndex].Get<Point3D>().GpPnt, new gpDir(0, 1, 0));
                Steps[StepIndex].Data = axis;
            }
            else if (Steps[StepIndex].Data is Mouse3DPosition)
            {
                var mouse3D = Steps[StepIndex].Get<Mouse3DPosition>();
                Steps[StepIndex].Data = mouse3D.Axis;
            }
        }

        private void AutoDrawDependencies()
        {
            if (StepIndex == Steps.Count - 1)
            {
                AutoCompleteAnimateDependencies();
                return;
            }
            if (StepIndex == 0)
            {
                switch (StepName)
                {
                    case InterpreterNames.Point3D:
                        DrawPoint(AnimationDocument, Get<Point3D>());
                        break;
                    case InterpreterNames.Axis3D:
                        DrawPoint(AnimationDocument, new Point3D(Get<gpAx1>().Location));
                        break;
                    case InterpreterNames.Reference:
                        HighlightShape(Get<SceneSelectedEntity>());
                        break;
                }
                return;
            }
            Point3D? lastPoint = null;
            for (var id = 0; id <= StepIndex; id++)
            {
                var steps = Steps[id];
                if (steps.Name != InterpreterNames.Point3D) continue;
                gpAx1 axis = null;
                for (var prevSteps = 0; prevSteps < id; prevSteps++)
                {
                    if (Steps[prevSteps].Name == InterpreterNames.Axis3D)
                    {
                        axis = Steps[prevSteps].Get<gpAx1>();
                    }
                }

                if (lastPoint != null)
                {
                    DrawLine(AnimationDocument, (Point3D) lastPoint, steps.Get<Point3D>());
                }
                if (axis != null)
                {
                    DrawRectangle(AnimationDocument, axis, steps.Get<Point3D>());
                }
                if (steps.Data is Point3D)
                    lastPoint = steps.Get<Point3D>();
            }
            if (StepIndex == Steps.Count - 1)
            {
                AutoCompleteAnimateDependencies();
            }
        }

        private void HighlightShape(SceneSelectedEntity selectedShape)
        {
            if (selectedShape == null)
                return;
            ApplyAnimationSettings(selectedShape.Node);
        }

        private void ApplyAnimationSettings(Node node)
        {
            return;
            //RestoreNodeSelectionValues();

            //_selectedNode = node;

            //SaveSelectedNodeValues();
            //node.Set<DrawingAttributesInterpreter>().Color = Color.RoyalBlue;
            //node.Set<DrawingAttributesInterpreter>().Transparency = 0.2;
        }

        //private void RestoreNodeSelectionValues()
        //{
        //    if (_selectedNode == null) return;
        //    if (_previousColor != null)
        //        _selectedNode.Set<DrawingAttributesInterpreter>().Color = (Color)_previousColor;
        //    else
        //        _selectedNode.Set<DrawingAttributesInterpreter>().HasColorSet = false;
        //    if (_previousTransparency != null)
        //        _selectedNode.Set<DrawingAttributesInterpreter>().Transparency = (double)_previousTransparency;
        //    else
        //        _selectedNode.Set<DrawingAttributesInterpreter>().HasTransparency = false;
        //    _selectedNode = null;
        //}

        //private void SaveSelectedNodeValues()
        //{
        //    _previousColor = null;
        //    if (_selectedNode.Set<DrawingAttributesInterpreter>().HasColorSet)
        //        _previousColor = _selectedNode.Set<DrawingAttributesInterpreter>().Color;
        //    _previousTransparency = null;
        //    if (_selectedNode.Set<DrawingAttributesInterpreter>().HasTransparency)
        //        _previousTransparency = _selectedNode.Get<DrawingAttributesInterpreter>().Transparency;
        //}


        public void Propose<T>(T data)
        {
            Propose(data, true);
        }

        public void Propose<T>(T data, bool updateShape)
        {
            ProposeCandidate(data, updateShape);
        }

        private T Get<T>()
        {
            return Steps[StepIndex].Get<T>();
        }

        public void PushCandidate()
        {
            if (StepIndex >= Steps.Count || (Steps[StepIndex].Data == null))
            {
                Log.Info("Push null candidate, canceled");
                return;
            }

            StepIndex++;
            SkipDefaultSteps();
        }

        public void SkipDefaultSteps()
        {
            while (StepIndex < Steps.Count && Steps[StepIndex].IsDefaultValue)
                StepIndex++;

            if (StepIndex == Steps.Count)
                OnStepsCompleted();
        }

        public void Reset()
        {
            StepIndex = 0;
            CleanDependencies();
            SkipDefaultSteps();
            RefreshDocumentBuilder();
        }

        public void CleanDependencies()
        {
            for (var index = 0; index < Steps.Count; index++)
            {
                if (Steps[index].IsDefaultValue) continue;
                Steps[index].Data = null;
            }
        }

        public void RefreshDocumentBuilder()
        {
            if (String.IsNullOrEmpty(_functionName)) return;
            AddToTreeOnComplete.Clear();
            Document.Transact();
            DocumentNodeBuilder = new NodeBuilder(Document, _functionName, _functionName);
        }

        #endregion
    }
}