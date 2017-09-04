#region Usings

using System.Drawing;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.gp;
using log4net;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Constants;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class Offset3D : DrawingLiveShape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (Offset3D));

        private Node _selectedNode;

        public Offset3D() : base(ModifierNames.Offset3D)
        {
        }

        public override void OnActivate()
        {
            Reset();

            _selectedNode = NodeBuilderUtils.IdentifySelectedObjectLabel(Document.Root);
            if (_selectedNode == null)
                BackToNeutralModifier();
        }

        private void Reset()
        {
            // Suspend the face picker
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
        }

        /// <summary>
        ///   Returns 1 if the point is outside the solid and -1 if inside or on solid.
        /// </summary>
        /// <param name = "point"></param>
        /// <returns></returns>
        private int GetDirection(gpPnt point)
        {
            var sourceShape = _selectedNode.Get<TopoDsShapeInterpreter>().Shape;
            var classification = GeomUtils.ClassifyPointVersusSolid(sourceShape, point);
            if ((classification == TopAbsState.TopAbs_IN) || (classification == TopAbsState.TopAbs_ON))
            {
                return -1;
            }

            return 1;
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            AddToPointList(mouseData.Point);

            // Start an offset drawing process
            if (Points.Count == 1)
            {
                Log.Info("Offset3D - started");
                return;
            }

            // At mouse down pick the selected edge
            if (!mouseData.MouseDown) return;
            if (_selectedNode == null)
                return;
            Log.Info("Offset3D - finished");
            InitSession();

            var direction = GetDirection(mouseData.Point.GpPnt);

            var builder = new NodeBuilder(Document, FunctionNames.Offset3D);
            builder[0].Reference = _selectedNode;
            builder[1].Real = direction*Points[0].Distance(mouseData.Point);

            // Close all local contexts
            Context.CloseAllContexts(true);

            if (!builder.ExecuteFunction())
            {
                Document.Revert();
                BackToNeutralModifier();
                return;
            }

            // Finish the transaction
            CommitFinal("Apply Offset3D");
            // Prepare for a new dimension
            BackToNeutralModifier();
        }

        /// <summary>
        ///   Receives mouse move events. The mouse move can be made having a button pressed or not
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (Points.Count == 0)
                return;

            // Check if it is outer or inner offset
            var direction = GetDirection(mouseData.Point.GpPnt);
            var offsetLength = Points[0].Distance(mouseData.Point);
            if (offsetLength < 1e-12)
            {
                return;
            }
            InitSession();
            DrawOffset3D(direction, offsetLength);
            UpdateView();
        }

        private void DrawOffset3D(int direction, double offsetLength)
        {
            var builder = CreateTemporaryBuilder(FunctionNames.Offset3D);
            builder[0].Reference = _selectedNode;
            builder[1].Real = direction*offsetLength;
            builder.Color = Color.Red;
            builder.ExecuteFunction();
        }
    }
}