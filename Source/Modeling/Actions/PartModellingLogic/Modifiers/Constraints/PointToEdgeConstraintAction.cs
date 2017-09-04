#region Usings

using System.Collections.Generic;
using System.Drawing;
using ErrorReportCommon.Messages;
using MetaActionsInterface;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Constants;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Constraints
{
    internal class PointToEdgeConstraintAction : DrawingLiveShape
    {
        private SceneSelectedEntity _destinationSelectedEntity;
        private List<SceneSelectedEntity> _selectedShapes;
        private SceneSelectedEntity _sourceSelectedEntity;

        public PointToEdgeConstraintAction()
            : base(ModifierNames.PointToEdgeConstraint)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            BuildSelectionList();
            if (_selectedShapes.Count != 2)
            {
                NaroMessage.Show("You should select a point and an edge before using this tool!");
                BackToNeutralModifier();
                return;
            }
            _sourceSelectedEntity = _selectedShapes[0];
            _destinationSelectedEntity = _selectedShapes[1];
            BuildConstraint();
        }

        private void BuildSelectionList()
        {
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            _selectedShapes = new List<SceneSelectedEntity>();

            foreach (var entity in entities)
            {
                //if ((entity.ShapeType == OCTopAbs_ShapeEnum.TopAbs_WIRE) ||
                //    (entity.ShapeType == OCTopAbs_ShapeEnum.TopAbs_EDGE))
                    _selectedShapes.Add(entity);
            }
        }

        private void BuildConstraint()
        {
            InitSession();

            var firstShape = new NodeBuilder(_sourceSelectedEntity.Node);
            var secondShape = new NodeBuilder(_destinationSelectedEntity.Node);

            SceneSelectedEntity shapeEdge;
            Node point;

            if (firstShape.FunctionName == FunctionNames.Point)
            {
                point = _sourceSelectedEntity.Node;
                shapeEdge = _destinationSelectedEntity;
            }
            else
            {
                if(secondShape.FunctionName == FunctionNames.Point)
                {
                    point = _destinationSelectedEntity.Node;
                    shapeEdge = _sourceSelectedEntity;
                }
                else
                {
                    Document.Revert();
                    BackToNeutralModifier();
                    return;
                }
            }
            if (shapeEdge.Node.Get<FunctionInterpreter>().Name == FunctionNames.Dimension)
            {
                var line = shapeEdge.Node.Children[1].Get<ReferenceInterpreter>().Node;
                var canSelect = new NodeBuilder(line).EnableSelection;
                if (canSelect)
                {
                    shapeEdge = new SceneSelectedEntity(line) { ShapeType = TopAbsShapeEnum.TopAbs_WIRE, ShapeCount = 1 };
                }
            }
            var shape = ShapeUtils.ExtractSubShape(shapeEdge);
            if (shape == null)
                return;
            var edge = GeomUtils.ExtractEdge(shape);
            if (edge == null)
                return;
            var projectedPoint = GeomUtils.ProjectPointOnEdge(edge, (new NodeBuilder(point))[1].TransformedPoint3D.GpPnt);

            var projectedPointNode = new NodeBuilder(Document, FunctionNames.Point);
            projectedPointNode[0].Reference = Document.Root.Children[0];
            projectedPointNode[1].TransformedPoint3D = new Point3D(projectedPoint);
            projectedPointNode.EnableSelection = false;
            projectedPointNode.ExecuteFunction();
            var tempLine1 = new NodeBuilder(Document, FunctionNames.LineTwoPoints);
            tempLine1[0].Reference = point; //sketchCreator.GetPoint((new NodeBuilder(point))[1].TransformedPoint3D).Node;
            tempLine1[1].Reference = projectedPointNode.Node;
            tempLine1.EnableSelection = false;
            tempLine1.ExecuteFunction();

            var perpendicularConstraint = new NodeBuilder(Document, Constraint2DNames.PerpendicularFunction);
            perpendicularConstraint[0].Reference = tempLine1.Node;
            perpendicularConstraint[1].Reference = shapeEdge.Node;

            perpendicularConstraint.ExecuteFunction();

            var pointOnLineConstraint = new NodeBuilder(Document, Constraint2DNames.PointOnSegmentFunction);
            pointOnLineConstraint[0].Reference = projectedPointNode.Node;
            pointOnLineConstraint[1].Reference = shapeEdge.Node;

            pointOnLineConstraint.ExecuteFunction();

            NodeBuilderUtils.AddLengthAndDimensionConstraint(Document, tempLine1.Node, true);
            // Finish the transaction
            CommitFinal("Apply Constraint");
            UpdateView();
            RebuildTreeView();
            BackToNeutralModifier();
        }
    }
}