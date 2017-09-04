#region Usings

using System.Collections.Generic;
using System.Drawing;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.gp;
using log4net;
using MetaActionsInterface;
using Naro.Infrastructure.Library.Algo;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Constraints
{
    internal class PointToPointConstraintAction : DrawingLiveShape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (PointToPointConstraintAction));
        private SceneSelectedEntity _currentSelectedEntity;
        private SceneSelectedEntity _destinationSelectedEntity;
        private SceneSelectedEntity _sourceSelectedEntity;

        public PointToPointConstraintAction()
            : base(ModifierNames.PointToPointConstraint)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Reset();
        }

        private void Reset()
        {
            // Suspend the face picker
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);

            // Switch to edge selection mode
            Context.CloseAllContexts(true);
            Context.OpenLocalContext(true, true, false, false);
            Context.ActivateStandardMode(TopAbsShapeEnum.TopAbs_VERTEX);
            _sourceSelectedEntity = null;
            _destinationSelectedEntity = null;
            _currentSelectedEntity = null;
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            // At mouse down pick the selected edge
            if (!mouseData.MouseDown)
                return;
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            if (_currentSelectedEntity == null)
            {
                // Store the mouse coordinate used to calculate the extrusion height
                Log.Info("Dimension - started");

                var selectedNodes = entities;
                if (selectedNodes.Count != 1)
                    return;

                _currentSelectedEntity = selectedNodes[0];

                // If no selected node
                if (_currentSelectedEntity == null)
                    return;
                if (_sourceSelectedEntity == null)
                {
                    _sourceSelectedEntity = _currentSelectedEntity;
                }
                else
                {
                    if (_destinationSelectedEntity == null &&
                        (_currentSelectedEntity.Node.Index != _sourceSelectedEntity.Node.Index ||
                         _currentSelectedEntity.ShapeCount != _sourceSelectedEntity.ShapeCount)
                        )
                        _destinationSelectedEntity = _currentSelectedEntity;
                }
                _currentSelectedEntity = null;
            }
            // At this moment the Dimension is finished
            if (_destinationSelectedEntity == null) return;
            Log.Info("Point to point constraint - finished");

            InitSession();
            var tempLine = new NodeBuilder(Document, FunctionNames.LineTwoPoints);
            tempLine[0].Reference = _sourceSelectedEntity.Node;
            tempLine[1].Reference = _destinationSelectedEntity.Node;
            tempLine.EnableSelection = false;
            tempLine.ExecuteFunction();
            NodeBuilderUtils.AddLengthAndDimensionConstraint(Document, tempLine.Node, false);

            // Close all local contexts
            Context.CloseAllContexts(true);

            // Finish the transaction
            CommitFinal("Apply dimension");

            Reset();
            BackToNeutralModifier();
        }

        private Node RegenerateSubShape()
        {
            return TreeUtils.BuildSubShape(Document, _currentSelectedEntity.Node, TopAbsShapeEnum.TopAbs_VERTEX,
                                           _currentSelectedEntity.ShapeCount, false);
        }

        private void DrawDimension(gpPnt mousePoint)
        {
            var builder = CreateTemporaryBuilder(FunctionNames.Dimension);
            builder[0].Reference = RegenerateSubShape();
            builder[1].TransformedPoint3D = new Point3D(mousePoint);
            builder.ExecuteFunction();
            return;
        }

        /// <summary>
        ///   Receives mouse move events. The mouse move can be made having a button pressed or not
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (_currentSelectedEntity == null)
            {
                return;
            }
            // Display the temporary dimension
            InitSession();
            DrawDimension(mouseData.Point.GpPnt);
            UpdateView();
        }
    }
}