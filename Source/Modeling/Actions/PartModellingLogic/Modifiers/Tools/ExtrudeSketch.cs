#region Usings

using System.Collections.Generic;
using System.Drawing;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;
using OccCode;
using TreeData.AttributeInterpreter;
using PartModellingUi.Views.Tools;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class ExtrudeSketch : DrawingLiveShape
    {
        #region struct IntIntPair

        private struct IntIntPair
        {
            public IntIntPair(SceneSelectedEntity value)
                : this()
            {
                Index = value.Node.Index;
                SubIndex = value.ShapeCount;
            }



            private int SubIndex { get; set; }

            private int Index { get; set; }

            public SceneSelectedEntity Get(Document document)
            {
                return new SceneSelectedEntity
                {
                    Node = document.Root[Index],
                    ShapeCount = SubIndex,
                    ShapeType = TopAbsShapeEnum.TopAbs_FACE
                };
            }
        }

        #endregion

        #region ExtrudeStages enum

        public enum ExtrudeStages
        {
            SelectSketch = 0,
            SelectAutoFace,
            ExtrudeAnimation,
            FinalizeExtrude
        }

        #endregion

        private ExtrudeStages _extrudeStages;
        private Node _sketchNode;
        public ExtrudeSketch()
            : base(ModifierNames.Extrude)
        {
        }

        private void SetWorkingPlane()
        {
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, _normalPlane);
        }

        private void ResetWorkingPlane()
        {
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, _normalPlane);
        }

        private List<Node> BuildAutoFaces(Node sketchNode)
        {
            var results = new List<Node>();
            var root = Document.Root;
            InitSession();
            var found = true;
            var circleNodes = new List<Node>();
            while (found)
            {
                found = false;
                foreach (var node in root.ChildrenList)
                {
                    var builder = new NodeBuilder(node);

                    if (builder.FunctionName == FunctionNames.Circle || builder.FunctionName == FunctionNames.Ellipse)
                    {
                        var currentSketchNode = AutoGroupLogic.FindSketchNode(node);
                        if (currentSketchNode.Index == sketchNode.Index)
                            circleNodes.Add(node);
                    }

                    if (builder.FunctionName == FunctionNames.LineTwoPoints ||
                        builder.FunctionName == FunctionNames.Arc ||
                        builder.FunctionName == FunctionNames.Arc3P)
                    {
                        var currentSketchNode = AutoGroupLogic.FindSketchNode(node);
                        if (currentSketchNode.Index != sketchNode.Index) continue;
                        var result = AutoGroupLogic.TryAutoGroup(Document, builder.Node);
                        if (result == null) continue;
                        found = true;
                        results.Add(result);
                        //  var faceBuilder = new NodeBuilder(result) {Transparency = 0.5};
                        break;
                    }
                }
            }
            foreach (var node in circleNodes)
            {
                var builder = new NodeBuilder(node);
                var addedEntiy = new SceneSelectedEntity { Node = builder.Node, ShapeType = TopAbsShapeEnum.TopAbs_WIRE };
                var builder2 = new NodeBuilder(Document, FunctionNames.Face);
                builder2[0].ReferenceList = new List<SceneSelectedEntity> { addedEntiy };
                builder2.ExecuteFunction();
                results.Add(builder2.Node);
            }
            return results;
        }

        private void BuildDragAxis(TopoDSShape shape, double extrudeSize)
        {
            var gravityCenter = GeomUtils.ExtractGravityCenter(shape);
            var dir = GeomUtils.ExtractDirection(shape);
            if (dir.XYZ.Z < 0)
                dir.Reverse();
            var vec = new gpVec(dir);
            vec.Normalize();
            vec.Multiply(extrudeSize);

            gravityCenter = GeomUtils.BuildTranslation(gravityCenter, vec);
            var point = new gpPnt(dir.XYZ);
            var gravityAxis = new Axis(gravityCenter, new Point3D(point));
            DrawDragAxis(gravityAxis, 2, 1);
            _normalPlane = BuildNormalPlane(dir, gravityAxis);
        }

        private static gpPln BuildNormalPlane(gpDir dir, Axis gravityAxis)
        {
            var gravityCenter = gravityAxis.Location;
            var plane = new gpPln(gravityCenter.GpPnt, dir);
            var newPoint = gravityCenter;
            newPoint.X += 1;
            newPoint.Y += 2;
            newPoint.Z += 3;
            var result = GeomUtils.ProjectPointOnPlane(newPoint.GpPnt, plane, Precision.Confusion);
            var resultPlane = GeomUtils.BuildPlane(gravityCenter, new Point3D(result),
                                                   gravityAxis.Location.AddCoordinate(gravityAxis.Direction));
            return resultPlane;
        }

        private void DrawDragAxis(Axis xAxis, double length, double width)
        {
            _axisBuilder = new NodeBuilder(Document, FunctionNames.AxisHandle);
            _axisBuilder[1].Axis3D = xAxis;
            _axisBuilder[2].Real = length;
            _axisBuilder[3].Real = width;
            _axisBuilder.Color = Color.DarkViolet;
            _axisBuilder.Transparency = 0.2;
            _axisBuilder.ExecuteFunction();
        }

        protected override void FacePicked(TopoDSFace face)
        {
            base.FacePicked(face);
            if (_extrudeStages == ExtrudeStages.SelectAutoFace)
                _underMouseFace = face;
        }

        private void ProposeSelectedReferenceShape(TopoDSShape face, Mouse3DPosition mouseData)
        {
            SceneSelectedEntity selectedNode = null;
            if (face != null)
            {
                selectedNode = GeomUtils.IdentifyNode(Document.Root, face);
                if (selectedNode == null)
                    return;
            }
            else
            {
                var node = NodeBuilderUtils.IdentifySelectedObjectLabel(Document.Root);
                if (node != null)
                    selectedNode = new SceneSelectedEntity(node);
            }
            if (selectedNode == null) return;
            if (_axisBuilder.Node != null && selectedNode.Node.Index == _axisBuilder.Node.Index)
            {
                SetWorkingPlane();
                _dragging = true;
                _startDragPos = mouseData.Point;
                return;
            }
            // The scene selected entity is hold as reference

            Propose(selectedNode);
        }

        private void Propose(SceneSelectedEntity selectedNode)
        {
            var nodeIndex = selectedNode.Node.Index;
            var subFace = selectedNode.ShapeCount;
            ResizeShapesToExtrude(selectedNode, nodeIndex, subFace);
        }

        private void PreviewExtrudes(bool showDragAxis)
        {
            var extrudeSize = _globalExtrudeSize;

            InitSession();

            Ensure.IsNotNull(_sketchNode);
            var results = BuildAutoFaces(_sketchNode);
       
            foreach(var node in results)
            {
                if (showDragAxis)
                {
                    var nb = new NodeBuilder(node);
                    BuildDragAxis(nb.Shape, extrudeSize);
                }
                var extrudeBuilder = BuildExtrudeBuilder(new SceneSelectedEntity(node) { ShapeType = TopAbsShapeEnum.TopAbs_FACE });//node);
                _extrudesList[extrudeBuilder.Node.Index] = extrudeBuilder.Node;
            }
            UpdateView();
        }

        private NodeBuilder BuildExtrudeBuilder(SceneSelectedEntity node)
        {
            var extrudeBuilder = new NodeBuilder(Document, FunctionNames.Extrude);
            extrudeBuilder[0].ReferenceData = node;
            extrudeBuilder[2].Real = _globalExtrudeSize;
            extrudeBuilder.ExecuteFunction();
            return extrudeBuilder;
        }

        private void ResizeShapesToExtrude(SceneSelectedEntity selectedNode, int nodeIndex, int subFace)
        {
            SortedDictionary<int, IntIntPair> subCollection;
            Node extrudeNode;
            if (_extrudesList.TryGetValue(nodeIndex, out extrudeNode))
            {
                var extrudeBuilder = new NodeBuilder(extrudeNode);
                var sourceFaceNodeIndex = extrudeBuilder[0].Reference.Index;
                _shapesToExtrude.Remove(sourceFaceNodeIndex);
                return;
            }
            if (!_shapesToExtrude.TryGetValue(nodeIndex, out subCollection))
            {
                subCollection = new SortedDictionary<int, IntIntPair>();
                _shapesToExtrude[nodeIndex] = subCollection;
            }
            if (subCollection.ContainsKey(subFace))
            {
                //subCollection.Remove(subFace);
                //if (subCollection.Count == 0)
                //    _shapesToExtrude.Remove(nodeIndex);
            }
            else
                subCollection[subFace] = new IntIntPair(selectedNode);
        }

        #region Overriden methods

        public override void OnRegister()
        {
            base.OnRegister();
            _shapesToExtrude = new SortedDictionary<int, SortedDictionary<int, IntIntPair>>();
            _extrudesList = new SortedDictionary<int, Node>();
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Reset();

            _extrudeSizeView = new ExtrudeSizeView(-100, 100, _globalExtrudeSize);
            _extrudeSizeView.ValueChanged += OnDialogValueChanged;
            _extrudeSizeView.ResultAccepted += OnDialogResultAccepted;
            RibbonPanel.Children.Add(_extrudeSizeView);

            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
        }

        private void Reset()
        {
            _shapesToExtrude = new SortedDictionary<int, SortedDictionary<int, IntIntPair>>();
            _extrudesList = new SortedDictionary<int, Node>();
            _underMouseFace = null;
            _normalPlane = null;
            _axisBuilder = new NodeBuilder(null);
            _dragging = false;
            _globalExtrudeSize = 5;
            _extrudeSizeView = null;
            _extrudeStages = ExtrudeStages.SelectSketch;
            _sketchNode = null;

            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
        }

        private void OnDialogResultAccepted()
        {
            if (!_extrudeSizeView.ResultOperation)
            {
                BackToNeutralModifier();
                return;
            }
   
            PreviewExtrudes(false);
            CommitFinal("Extrudes build");
            RebuildTreeView();
            UpdateView();
            BackToNeutralModifier();
        }

        private IEnumerable<IntIntPair> GetNonAutoFaces()
        {
            var result = new List<IntIntPair>();
            foreach (var extrude in _extrudesList)
            {
                var extrudeBuilder = new NodeBuilder(extrude.Value);
                var reference = new NodeBuilder(extrudeBuilder[0].Reference);
                if (reference.FunctionName == FunctionNames.Face) continue;
                result.Add(new IntIntPair(extrudeBuilder[0].ReferenceData));
            }

            return result;
        }

        private IEnumerable<IntIntPair> GetAutoFaces()
        {
            var result = new List<IntIntPair>();
            foreach (var extrude in _extrudesList)
            {
                var extrudeBuilder = new NodeBuilder(extrude.Value);
                var reference = new NodeBuilder(extrudeBuilder[0].Reference);
                if (reference.FunctionName != FunctionNames.Face) continue;
                result.Add(new IntIntPair(reference[0].ReferenceList[0]));
            }

            return result;
        }

        private void OnDialogValueChanged()
        {
            _globalExtrudeSize = _extrudeSizeView.ExtrudeHeight;
            PreviewExtrudes(true);
        }

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            base.OnMouseUpAction(mouseData);
            _dragging = false;

            if (_extrudeStages == ExtrudeStages.SelectSketch)
            {
                var entities = Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
                if (entities.Count <= 0)
                    return;

                _sketchNode = AutoGroupLogic.FindSketchNode(entities[0].Node);
                Ensure.IsNotNull(_sketchNode);

                PreviewExtrudes(true);
                _extrudeStages = ExtrudeStages.SelectAutoFace;
                Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
            }
            else if (_extrudeStages == ExtrudeStages.SelectAutoFace)
            {
                ProposeSelectedReferenceShape(_underMouseFace, mouseData);
                PreviewExtrudes(true);
                _extrudeStages = ExtrudeStages.ExtrudeAnimation;
            }
            else if (_extrudeStages == ExtrudeStages.ExtrudeAnimation)
            {
            }

        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            base.OnMouseMove3DAction(mouseData);
            if (!_dragging) return;
            if (_extrudeStages != ExtrudeStages.ExtrudeAnimation)
                return;

            _globalExtrudeSize = _startDragPos.Distance(mouseData.Point);
            _extrudeSizeView.ExtrudeHeight = _globalExtrudeSize;
            PreviewExtrudes(true);
        }

        #endregion

        #region Fields

        private NodeBuilder _axisBuilder;
        private bool _dragging;
        private ExtrudeSizeView _extrudeSizeView;
        private SortedDictionary<int, Node> _extrudesList;
        private double _globalExtrudeSize;
        private gpPln _normalPlane;
        private SortedDictionary<int, SortedDictionary<int, IntIntPair>> _shapesToExtrude;
        private Point3D _startDragPos;
        private TopoDSFace _underMouseFace;

        #endregion
    }
}
