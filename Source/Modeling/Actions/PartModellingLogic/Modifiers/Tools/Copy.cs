#region Usings

using System.Collections.Generic;
using log4net;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.Capabilities;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Implements the copy modifier.
    /// </summary>
    public class Copy : DrawingLiveShape
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");
        private readonly List<Node> _nodesToAddToTree;

        private readonly List<Node> _selectedNodes = new List<Node>();
        private CapabilitiesCollection _collection;
        private bool _targetOjectsSelected;

        public Copy()
            : base(ModifierNames.Copy)
        {
            _nodesToAddToTree = new List<Node>();
            DependsOn(InputNames.GlobalCapabilitiesInput);
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.CoordinateParser, OnCoordinateParser);
        }

        protected override void OnTreeNodeSelect(Node node)
        {
            OnShapePicked(node);
        }

        private bool IsNodeValid(int dependencyIndex, Node node)
        {
            var builder = new NodeBuilder(node);
            if (dependencyIndex != 1)
                return true;
            if (!_collection.HasConcept(builder.FunctionName))
                return false;
            return true;
        }

        public override void OnDeactivate()
        {
            AddNodeListToTree(_nodesToAddToTree);
            _nodesToAddToTree.Clear();
            base.OnDeactivate();
        }

        private void OnCoordinateParser(DataPackage data)
        {
            var coordinate = data.Get<Point3D>();
            AddNextPoint(coordinate);
        }

        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            if (_targetOjectsSelected == false)
            {
                Ensure.IsNotNull(Document);
                OnSceneShapePicked();
                return;
            }
            var coordinate = mouseData.Point;
            AddNextPoint(coordinate);
        }

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            base.OnMouseUpAction(mouseData);
            ActionsGraph[InputNames.GeometricSolverPipe].Send(NotificationNames.ResetPreviousPoint);
        }

        private void AddNextPoint(Point3D coordinate)
        {
            if (_targetOjectsSelected)
            {
                Points[Points.Count - 1] = coordinate;
                Inputs[InputNames.CoordinateParser].Send(NotificationNames.SetLastPoint,
                                                         coordinate);
                if (Points.Count > 1)
                {
                    BuildCopy();
                }
                Points.Add(new Point3D());
            }
        }


        private void OnSceneShapePicked()
        {
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            if (entities.Count <= 0)
                return;
            OnShapePicked(entities[0].Node);
        }

        private void OnShapePicked(Node node)
        {
            if (!IsNodeValid(_selectedNodes.Count, node))
                return;
            if (_selectedNodes.Count > 0 && _selectedNodes[0].Index == node.Index)
                return;
            SelectShape(node);
            _selectedNodes.Add(node);
            _targetOjectsSelected = true;
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.EnableAll);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _collection = Inputs[InputNames.GlobalCapabilitiesInput].Get<CapabilitiesCollection>();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Reset();
            Points.Clear();
            Points.Add(new Point3D());
        }

        private void Reset()
        {
            Context.Select(true);
            _selectedNodes.Clear();
            _targetOjectsSelected = false;
        }

        private void BuildCopy()
        {
            InitSession();
            MakeCopy();
            Document.Commit("Make a copy");
            UpdateView();
            Log.Info("Copy " + (Points.Count - 1) + " done");
        }

        private void MakeCopy()
        {
            var translationVector = Points[Points.Count - 1].SubstractCoordinate(Points[0]);
            var sourceCopyBuilder = new NodeBuilder(Document.CopyPaste(_selectedNodes[0]));
            sourceCopyBuilder.ShapeName = "Copyed" +
                                          sourceCopyBuilder.ShapeName.Substring(0,
                                                                                sourceCopyBuilder.ShapeName.Length - 1) +
                                          (Points.Count - 1);
            var transformInterpreter = sourceCopyBuilder.Node.Get<TransformationInterpreter>();
            transformInterpreter.ApplyTranslateWith(translationVector);
            ActionsGraph[InputNames.UiElementsItem].Send(NotificationNames.AddNewNodeToTree, sourceCopyBuilder.Node);
        }
    }
}