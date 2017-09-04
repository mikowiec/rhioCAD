#region Usings

using System.Collections.Generic;
using System.Drawing;
using log4net;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Constants;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Precision;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Displays on the selected face an arrow showing the face direction
    /// </summary>
    public class Direction : DrawingLiveShape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (Dimension));

        private SceneSelectedEntity _currentSelectedEntity;
        private SceneSelectedEntity _previousSelectedEntity;

        public Direction()
            : base(ModifierNames.Direction)
        {
        }

        public override void OnActivate()
        {
            Reset();
        }

        private void Reset()
        {
            // Suspend the face picker
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
            EnterFaceSelectionMode();

            _currentSelectedEntity = null;
        }

        private void EnterFaceSelectionMode()
        {
            // Switch to edge selection mode
            Context.CloseAllContexts(true);
            Context.OpenLocalContext(true, true, false, false);
            Context.ActivateStandardMode(TopAbsShapeEnum.TopAbs_FACE);
        }

        private void ExitFaceSelectionMode()
        {
            // Close all local contexts
            Context.CloseAllContexts(true);
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            if (Document == null)
                return;
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            // At mouse down pick the selected edge
            if (!mouseData.MouseDown) return;
            // Store the mouse coordinate used to calculate the extrusion height
            Log.Info("Direction - shown");
            InitSession();

            var selectedNodes = entities;
            if (selectedNodes.Count != 1)
                return;

            _currentSelectedEntity = selectedNodes[0];

            // If click on the same shape reverse the face direction
            var reverseFace = false;
            if ((_previousSelectedEntity != null) && (_previousSelectedEntity.Node == _currentSelectedEntity.Node))
            {
                reverseFace = true;
            }
            _previousSelectedEntity = _currentSelectedEntity;

            // If no selected node
            if ((_currentSelectedEntity == null) || (_currentSelectedEntity.ShapeType != TopAbsShapeEnum.TopAbs_FACE))
            {
                return;
            }

            ExitFaceSelectionMode();

            var topoFace =
                GeomUtils.ExtractShapeType(_currentSelectedEntity.Node.Get<TopoDsShapeInterpreter>().Shape,
                                           _currentSelectedEntity.ShapeType,
                                           _currentSelectedEntity.ShapeCount);
            var face = TopoDS.Face(topoFace);
            if (reverseFace)
            {
                ReverseFaceDirection(face);
            }
            ShowFaceDirection(face);

            // Prepare for a new direction
            Reset();
        }

        /// <summary>
        ///   Reverses the direction of a face
        /// </summary>
        /// <param name = "face"></param>
        private static void ReverseFaceDirection(TopoDSShape face)
        {
            switch (face.Orientation())
            {
                case TopAbsOrientation.TopAbs_FORWARD:
                    face.Orientation(TopAbsOrientation.TopAbs_REVERSED);
                    break;
                case TopAbsOrientation.TopAbs_REVERSED:
                    face.Orientation(TopAbsOrientation.TopAbs_FORWARD);
                    break;
            }
        }

        /// <summary>
        ///   Displays the direction of a face
        /// </summary>
        /// <param name = "face"></param>
        private void ShowFaceDirection(TopoDSFace face)
        {
            var p1 = new gpPnt();
            var v1 = new gpVec();
            var v2 = new gpVec();

            var sf = new BRepAdaptorSurface(face, true);
            var u = sf.FirstUParameter;
            var x = sf.LastUParameter;
            if (Precision.IsInfinite(u))
                u = (Precision.IsInfinite(x)) ? 0.0 : x;
            else if (!Precision.IsInfinite(x))
                u = (u + x)/2.0;

            var v = sf.FirstVParameter;
            x = sf.LastVParameter;
            if (Precision.IsInfinite(v))
                v = (Precision.IsInfinite(x)) ? 0.0 : x;
            else if (!Precision.IsInfinite(x))
                v = (v + x)/2.0;

            sf.D1(u, v, p1, v1, v2);
            var vector = v1.Crossed(v2);
            x = vector.Magnitude;

            // The direction vector length
            const double length = 70.0;
            if (x > 0.0000001)
            {
                vector.Multiply(length/x);
            }
            else
            {
                vector.SetCoord(length/2.0, 0, 0);
            }

            var p2 = new gpPnt(p1.X, p1.Y, p1.Z);
            p2.Translate(vector);

            if (p1.IsEqual(p2, Precision.Confusion))
            {
                return;
            }

            DrawArrow(Document, p1, p2, face.Orientation());
        }

        public static void ShowFaceDirection(TopoDSFace face, Document Document)
        {
            var p1 = new gpPnt();
            var v1 = new gpVec();
            var v2 = new gpVec();

            var sf = new BRepAdaptorSurface(face, true);
            var u = sf.FirstUParameter;
            var x = sf.LastUParameter;
            if (Precision.IsInfinite(u))
                u = (Precision.IsInfinite(x)) ? 0.0 : x;
            else if (!Precision.IsInfinite(x))
                u = (u + x) / 2.0;

            var v = sf.FirstVParameter;
            x = sf.LastVParameter;
            if (Precision.IsInfinite(v))
                v = (Precision.IsInfinite(x)) ? 0.0 : x;
            else if (!Precision.IsInfinite(x))
                v = (v + x) / 2.0;

            sf.D1(u, v, p1, v1, v2);
            var vector = v1.Crossed(v2);
            x = vector.Magnitude;

            // The direction vector length
            const double length = 70.0;
            if (x > 0.0000001)
            {
                vector.Multiply(length / x);
            }
            else
            {
                vector.SetCoord(length / 2.0, 0, 0);
            }

            var p2 = new gpPnt(p1.X, p1.Y, p1.Z);
            p2.Translate(vector);

            if (p1.IsEqual(p2, Precision.Confusion))
            {
                return;
            }

            DrawArrow(Document, p1, p2, face.Orientation());
        }

        /// <summary>
        ///   Draws an arrow on the scene
        /// </summary>
        /// <param name = "document"></param>
        /// <param name = "firstPoint"></param>
        /// <param name = "secondPoint"></param>
        /// <param name = "color"></param>
        public static void DrawArrow(Document document, gpPnt firstPoint, gpPnt secondPoint,
                                     TopAbsOrientation color)
        {
            var builder = new NodeBuilder(document, FunctionNames.Arrow);
            builder[0].TransformedPoint3D = new Point3D(firstPoint);
            builder[1].TransformedPoint3D = new Point3D(secondPoint);
            builder[2].Integer = (int) color;
            builder.Color = Color.Red;
            builder.ExecuteFunction();
        }
    }
}