#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Interpreters;
using log4net;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    class Extrude : DrawingLiveShape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Extrude));

        #region ExtrudeStages enum

        public enum ExtrudeStages
        {
            SelectSketch = 0,
            ExtrudeAnimation
        }

        #endregion

        private ExtrudeStages _extrudeStages;
        private Node _sketchNode;
        private gpPln _shapePlane;
        private int extrudeType = 0;
        private NodeBuilder extrudeBuilder;
        public Extrude()
            : base(ModifierNames.Extrude)
        {
        }

        private void SetWorkingPlane(gpPln normalPlane)
        {
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, normalPlane);
        }

        private void ResetWorkingPlane()
        {
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, new DataPackage(null));
        }

      

        #region Overriden methods
        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            var sketchBuilder = new SketchCreator(Document, false);
            var sketchNode = sketchBuilder.CurrentSketch;
            if(sketchNode != null)
            {
                ActionsGraph.SwitchAction(ModifierNames.EndSketch, ModifierNames.Extrude);
                return;
            }
            Reset();
            extrudeBuilder = new NodeBuilder(Document, FunctionNames.Extrude);
            extrudeBuilder[2].Real = 0.0;
            extrudeBuilder.ExecuteFunction();
            extrudeBuilder.Visibility = ObjectVisibility.Hidden;
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, extrudeBuilder.Node);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                TopAbsShapeEnum.TopAbs_SOLID);
        }

        private void Reset()
        {
            _extrudeStages = ExtrudeStages.SelectSketch;
            _sketchNode = null;
            
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
        }

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            base.OnMouseUpAction(mouseData);
           
            if (_extrudeStages == ExtrudeStages.SelectSketch)
            {
                var entities = Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
                if (entities.Count <= 0)
                    return;

                _sketchNode = AutoGroupLogic.FindSketchNode(entities[0].Node);
                if (_sketchNode == null)
                    return;
                if(_sketchNode.Children[2].Get<MeshTopoShapeInterpreter>() == null)
                {
                    // the sketch shape was not generated - this is the case when we open a file and perform extrude without any edits
                    var tempFace = AutoGroupLogic.RebuildSketchFace(_sketchNode, Document);
                    if (tempFace == null)
                        return;
                    _sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = tempFace;
                    NodeUtils.SetSketchTransparency(Document, _sketchNode, ObjectVisibility.Hidden);
                    _sketchNode.Set<DrawingAttributesInterpreter>().Transparency = 1;
                    _sketchNode.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
                    Document.Commit("Sketch face generated");
                }

                var face = _sketchNode.Children[2].Get<MeshTopoShapeInterpreter>().Shape;

                _shapePlane = GeomUtils.ExtractPlane(face);
                PreviewExtrude(false, mouseData);
                ResetWorkingPlane();
                Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Disable);
                _extrudeStages = ExtrudeStages.ExtrudeAnimation;
               
            }
            else if (_extrudeStages == ExtrudeStages.ExtrudeAnimation)
            {
                var sketchBuilder = new NodeBuilder(_sketchNode);
                var extrudeHeight = sketchBuilder[0].Axis3D.Location.Distance(mouseData.Point);
                if (extrudeHeight < 1e-12) return;
                PreviewExtrude(false, mouseData);
                NodeUtils.SetSketchTransparency(Document, _sketchNode, ObjectVisibility.Hidden);
                CommitFinal("Extrudes build");
                Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
                
                //Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                //                                                TopAbsShapeEnum.TopAbs_SOLID);
                RebuildTreeView();
                UpdateView();
                BackToNeutralModifier();
            }
        }

        private double extrudeHeight = 0;
        private void PreviewExtrude(bool preview, Mouse3DPosition mouseData)
        {
            if (extrudeBuilder.FunctionName == string.Empty)
            {
                extrudeBuilder = new NodeBuilder(Document, FunctionNames.Extrude);
                extrudeBuilder[2].Real = 0.0;
                extrudeBuilder.ExecuteFunction();
                extrudeBuilder.Visibility = ObjectVisibility.Hidden;
            }
            else
            {
                extrudeType = extrudeBuilder[1].Integer;
            }
            InitSession();
            if (_sketchNode.Children[2].Get<MeshTopoShapeInterpreter>() != null && _shapePlane != null)
            {
         
                var dimensionIsDisplayed = preview;
                extrudeBuilder = new NodeBuilder(Document, FunctionNames.Extrude);
                extrudeBuilder[0].Reference = _sketchNode;
                extrudeBuilder[1].Integer = extrudeType;
                extrudeBuilder[2].Real = 
                 Math.Abs(extrudeHeight) > Precision.Confusion ? extrudeHeight : GeomUtils.CalculateDistance(mouseData.Point.GpPnt, _shapePlane);
                extrudeBuilder.ExecuteFunction();
                var nb = new NodeBuilder(extrudeBuilder.Node);
               
                if (dimensionIsDisplayed)
                {
                    DisplayTemporaryDimension(Document, _sketchNode, extrudeBuilder.Node, mouseData, false);
                }
                Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, extrudeBuilder.Node);
            }
        }

        public static void DisplayTemporaryDimension(Document animationDocument, Node baseNode, Node extrusion, Mouse3DPosition mouseData, bool enableSelection)
        {
            var subShape = new NodeBuilder(animationDocument, FunctionNames.SubShape);
            subShape[0].Reference = extrusion;
            subShape[1].Integer = 1;
            subShape[2].Integer = (int)TopAbsShapeEnum.TopAbs_EDGE;
            subShape.ExecuteFunction();

            if (subShape.Shape == null)
            {
                return;
            }

            var edge = TopoDS.Edge(subShape.Shape);
            var baseNodeBuilder = new NodeBuilder(baseNode);
            var gravityCenter = GeomUtils.ExtractGravityCenter(baseNodeBuilder.Shape);

            var firstPoint = new Point3D();
            var firstPointCalculated = GeomUtils.CalculateEdgeFirstPoint(edge);
            if (firstPointCalculated != null)
                firstPoint = (Point3D)firstPointCalculated;

            var secondPoint = new Point3D();
            var secondPointCalculated = GeomUtils.CalculateEdgeLastPoint(edge);
            if (secondPointCalculated != null)
                secondPoint = (Point3D)secondPointCalculated;

            var middlePoint = GeomUtils.ComputeMidPoint(firstPoint, secondPoint);

            // Translate the dimenion text at some distance from the extrude
            var vector = new gpVec(firstPoint.GpPnt, gravityCenter.GpPnt);
            vector.Reverse();
            vector.Normalize();
            vector.Multiply(2);
            middlePoint = GeomUtils.BuildTranslation(middlePoint, vector);

            subShape.Visibility = ObjectVisibility.Hidden;

            // Build a distance dimension just for animation purposes
            var animationBuilder = new NodeBuilder(animationDocument, FunctionNames.PointsDimension);
            animationBuilder[0].TransformedPoint3D = firstPoint;
            animationBuilder[1].TransformedPoint3D = secondPoint;
            animationBuilder[2].TransformedPoint3D = middlePoint;
            animationBuilder[3].Integer = (int)DsgPrsArrowSide.DsgPrs_AS_FIRSTPT_LASTAR;
            animationBuilder[4].Real = 1;
            animationBuilder.EnableSelection = false;
            animationBuilder.Color = Color.Black;
            animationBuilder.ExecuteFunction();
        }

        private bool heightChecked = false;
        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (extrudeBuilder.Shape == null)
            {
                if (extrudeBuilder.Node.Children.Count == 0)
                {
                    extrudeBuilder = new NodeBuilder(Document, FunctionNames.Extrude);
                    extrudeBuilder[0].Reference = _sketchNode;
                    extrudeBuilder[1].Integer = extrudeType;
                    extrudeBuilder.ExecuteFunction();
                }
                if (_shapePlane != null)  
                {
                    extrudeBuilder[2].Real = GeomUtils.CalculateDistance(mouseData.Point.GpPnt, _shapePlane);
                    extrudeBuilder.ExecuteFunction();
                }
                
                if(extrudeBuilder.Shape == null)
                    return;
            }
            if (extrudeBuilder.Dependency == null)
                return;
            if (!heightChecked && _extrudeStages != ExtrudeStages.ExtrudeAnimation)
            {
                extrudeHeight = extrudeBuilder[2].Real;
                if (_extrudeStages == ExtrudeStages.ExtrudeAnimation)
                    heightChecked = true;
            }
            base.OnMouseMove3DAction(mouseData);
            if (_extrudeStages != ExtrudeStages.ExtrudeAnimation)
                return;

            PreviewExtrude(true, mouseData);
        }

        #endregion
    }
}