#region Usings

using System.Collections.Generic;
using ErrorReportCommon.Messages;
using MetaActionsInterface;
using NaroConstants.Names;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    public class AddSelectedTool : DrawingLiveShape
    {
        private SortedDictionary<string, string> _shapeToActionMapping;

        public AddSelectedTool()
            : base(ModifierNames.AddSelectedTool)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            _shapeToActionMapping = new SortedDictionary<string, string>
                                        {
                                            {FunctionNames.LineTwoPoints, ModifierNames.Line3D},
                                            {FunctionNames.SplinePath, ModifierNames.InterpolatedSpline},
                                            {FunctionNames.ThreePointsRectangle, ModifierNames.ThreePointsRectangle},
                                            {FunctionNames.Paralleogram, ModifierNames.Parallelogram},
                                            {FunctionNames.Sewing, ModifierNames.Sew},
                                            {FunctionNames.Box, ModifierNames.Box},
                                            {FunctionNames.Arc, ModifierNames.ArcCenterStartEnd},
                                            {FunctionNames.Arc3P, ModifierNames.ArcStartEndRadius},
                                            {FunctionNames.Circle, ModifierNames.DrawCircle},
                                            {FunctionNames.Ellipse, ModifierNames.Ellipse},
                                            {FunctionNames.Cone, ModifierNames.Cone},
                                            {FunctionNames.Cut, ModifierNames.Cut},
                                            {FunctionNames.Cylinder, ModifierNames.Cylinder},
                                            {FunctionNames.Extrude, ModifierNames.Extrude},
                                            {FunctionNames.Fillet, ModifierNames.Fillet},
                                            {FunctionNames.Fillet2D, ModifierNames.Fillet2D},
                                            {FunctionNames.Polyline, ModifierNames.Polyline},
                                            {FunctionNames.Point, ModifierNames.Point3D},
                                            {FunctionNames.Rectangle, ModifierNames.RectangleTwoPoints},
                                            {FunctionNames.Sphere, ModifierNames.Sphere},
                                            {FunctionNames.Spline, ModifierNames.Spline},
                                            {FunctionNames.Torus, ModifierNames.Torus},
                                            {FunctionNames.CircularPattern, ModifierNames.CircularPattern},
                                            {FunctionNames.ArrayPattern, ModifierNames.ArrayPattern},
                                            {FunctionNames.Pipe, ModifierNames.Pipe},
                                            {FunctionNames.Revolve, ModifierNames.Revolve},
                                            {FunctionNames.Dimension, ModifierNames.Dimension},
                                            {FunctionNames.Offset, ModifierNames.Offset},
                                            {FunctionNames.Offset3D, ModifierNames.Offset3D},
                                            {FunctionNames.AngleDraft, ModifierNames.AngleDraft},
                                            {FunctionNames.MirrorPoint, ModifierNames.MirrorPoint},
                                            {FunctionNames.MirrorLine, ModifierNames.MirrorLine},
                                            {FunctionNames.MirrorPlane, ModifierNames.MirrorPlane},
                                            {FunctionNames.Trim, ModifierNames.Trim},
                                            {FunctionNames.EdgeDistanceConstraint, ModifierNames.EdgeDistanceConstraint},
                                            {FunctionNames.PointToPointConstraint, ModifierNames.PointToPointConstraint},
                                            {FunctionNames.PointToEdgeConstraint, ModifierNames.PointToEdgeConstraint},
                                            {FunctionNames.DefineDrawingPlane, ModifierNames.DefineDrawingPlane},
                                            {FunctionNames.VerticalLine, ModifierNames.VerticalLine},
                                            {FunctionNames.HorizontalLine, ModifierNames.HorizontalLine}
                                        };
        }

        public override void OnActivate()
        {
            base.OnActivate();

            // Hide the currently selected object and the objects that have references to it
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();


            if (entities.Count == 0 || entities[0] == null)
            {
                WarnNoSelectedAndBackToNone();
                return;
            }
            var shapeName = new NodeBuilder(entities[0].Node).FunctionName;
            string actioNName;
            if (_shapeToActionMapping.TryGetValue(shapeName, out actioNName))
                ActionsGraph.SwitchAction(actioNName);
        }


        private void WarnNoSelectedAndBackToNone()
        {
            NaroMessage.Show("Please pick a shape to switch action");
            BackToNeutralModifier();
        }
    }
}