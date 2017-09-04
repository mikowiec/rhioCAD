#region Usings

using System;
using log4net;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Implements a translation modifier.
    /// </summary>
    public class Translate : DrawingLiveShape
    {
        private const double BoxWidth = 4.0;
        private static readonly ILog Log = LogManager.GetLogger("NaroCAD");
        private Node _translatedNode;

        public Translate()
            : base(ModifierNames.Translate)
        {
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            if (Document == null)
                return;

            if (!mouseData.MouseDown)
                return;

            bool firstClick = (_translatedNode == null) && (Points.Count == 0);

            // Check if a shape was selected before launching the tool
            if (Points.Count == 0)
            {
                _translatedNode = NodeBuilderUtils.IdentifySelectedObjectLabel(Document.Root);
                if (_translatedNode == null)
                    return;
            }

            // First the object is selected
            if (firstClick)
                return;

            // Start a translation process
            if (Points.Count < 1)
            {
                AddToPointList(mouseData.Point);
                if (Points.Count == 1)
                {
                    Log.Info("Translate - translation started");

                    Document.Transact();
                }
                return;
            }

            // The translation finished
            Log.Info("Translate - translation finished");
            InitSession();

            // Apply transformation
            if (_translatedNode != null)
            {
                var transformation = _translatedNode.Set<TransformationInterpreter>();
                transformation.TranslateWith(
                    new Point3D(new gpPnt(mouseData.Point.X, mouseData.Point.Y, mouseData.Point.Z)));
                transformation.Pivot = mouseData.Point.GpPnt;
                // Commit
                CommitFinal("Translate");

                _translatedNode = null;
            }
            else
                Document.Revert();
        }

        /// <summary>
        ///   Receives mouse move events. The mouse move can be made having a button pressed or not
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (Points.Count != 1)
                return;

            if (_translatedNode == null)
                return;

            // Draw a temporary line that follows the mouse until the second point is picked               
            if (Points.Count != 1) return;
            try
            {
                // Draw the helper line
                if (Points[0].IsEqual(mouseData.Point))
                    return;
                InitSession();

                DrawLine(Points[0], mouseData.Point);
                DrawMarkerBox(Points[0], BoxWidth);
                DrawMarkerBox(mouseData.Point, BoxWidth);

                // Draw also the translated shape
                var transformation = _translatedNode.Set<TransformationInterpreter>();
                transformation.Translate = new gpPnt(mouseData.Point.X, mouseData.Point.Y, mouseData.Point.Z);
                transformation.Pivot = mouseData.Point.GpPnt;

                UpdateView();
            }
            catch (Exception)
            {
                Log.Info("Translate - translation error");
            }
        }
    }
}