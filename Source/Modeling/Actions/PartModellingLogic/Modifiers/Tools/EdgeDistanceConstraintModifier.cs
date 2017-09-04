#region Usings

using System.Collections.Generic;
using System.Windows.Forms;
using ErrorReportCommon.Messages;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Constants;
using OccCode;

using PartModellingLogic.UI.Views.Shapes;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    internal class EdgeDistanceConstraintModifier : DrawingLiveShape
    {
        private Node _secondShape;
        private SceneSelectedEntity _selectedEdge;

        public EdgeDistanceConstraintModifier()
            : base(ModifierNames.EdgeDistanceConstraint)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            var selectedNodes = entities;
            if (selectedNodes.Count == 0)
            {
                SelectEdgeBeforeStartActionMessage();
                BackToNeutralModifier();
                return;
            }
            foreach (var entity in selectedNodes)
            {
                if ((entity.ShapeType != TopAbsShapeEnum.TopAbs_WIRE) &&
                    (entity.ShapeType != TopAbsShapeEnum.TopAbs_EDGE)) continue;
                _selectedEdge = entity;
                break;
            }
            if (_selectedEdge == null)
                SelectEdgeBeforeStartActionMessage();
        }

        private static void SelectEdgeBeforeStartActionMessage()
        {
            NaroMessage.Show("Select_Edge_Before_Using");
        }

        protected override void FacePicked(TopoDSFace face)
        {
            var entity = GeomUtils.IdentifyNode(Document.Root, face);
            base.FacePicked(face);
            if (entity == null) return;
            _secondShape = entity.Node;
        }

        private void CreateConstraintDialogAndApplyIt()
        {
            var paramDialog = new EdgeDistanceDialog(_secondShape);
            var result = paramDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                BackToNeutralModifier();
            }
            else
            {
                InitSession();
                var builder = new NodeBuilder(Document, FunctionNames.EdgeDistanceConstraint);
                builder[0].ReferenceData = _selectedEdge;
                builder[1].Real = paramDialog.Distance;
                builder[2].Node = _secondShape;
                builder[3].Integer = paramDialog.AppliedPoint;
                builder.ExecuteFunction();

                CommitFinal("Distance_To_Edge_Constraint_Applied");
                BackToNeutralModifier();
            }
        }


        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            CreateConstraintDialogAndApplyIt();
        }
    }
}