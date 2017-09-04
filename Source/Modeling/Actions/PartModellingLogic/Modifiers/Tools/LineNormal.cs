#region Usings

using System;
using log4net;
using MetaActionsInterface;
using Naro.Infrastructure.Library.Algo;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;
using OccCode;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class LineNormal : DrawingLiveShape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (LineNormal));
        private gpDir _direction = new gpDir();

        private NodeBuilder _temporary;

        public LineNormal() : base(ModifierNames.LineNormal)
        {
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            if (!mouseData.MouseDown)
                return;
            AddToPointList(mouseData.Point);
            // Start a line drawing process
            if (Points.Count == 1)
            {
                var face = CurrentFacePicked;
                if (face != null)
                {
                    _direction = GeomUtils.ExtractDirection(face);
                }
                Log.Info("Line Normal - draw line started");
                return;
            }

            // The line drawing finished
            Log.Info("Line Normal - draw line finished");

            // Create line
            var normalPoint = (Point3D) GeomUtils.ProjectPointOnLine(Points[0], _direction, mouseData.Point);
            if (Points[0].IsEqual(normalPoint))
            {
                return;
            }

            InitSession();
            var node = TreeUtils.AddLineToNode(Document, Points[0], normalPoint).Node;
            if (node == null)
            {
                Document.Revert();
                BackToNeutralModifier();
                return;
            }

            // Commit
            CommitFinal("Line Normal");
            _temporary = new NodeBuilder(null);
        }

        /// <summary>
        ///   Receives mouse move events. The mouse move can be made having a button pressed or not
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (Points.Count < 1)
            {
                return;
            }

            // Draw a temporary line that follows the mouse until the second point is picked
            try
            {
                var normalPoint = (Point3D) GeomUtils.ProjectPointOnLine(Points[0], _direction, mouseData.Point);
                if (Points[0].IsEqual(normalPoint))
                {
                    return;
                }
                InitSession();
                _temporary = CreateTemporaryBuilder(FunctionNames.LineTwoPoints);
                _temporary[0].TransformedPoint3D = Points[0];
                _temporary[1].TransformedPoint3D = normalPoint;
                _temporary.ExecuteFunction();
                UpdateView();
            }
            catch (Exception)
            {
                Log.Info("Line Normal - line generation error");
            }
        }
    }
}