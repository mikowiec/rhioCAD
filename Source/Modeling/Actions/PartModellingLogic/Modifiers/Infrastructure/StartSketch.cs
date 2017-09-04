#region Usings

using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using OccCode;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingLogic.Inputs.Naro.Pipes;
using PartModellingLogic.Modifiers.Tools;
using ShapeFunctionsInterface.Interpreters;
using TreeData.NaroData;
using log4net;
using MetaActionsInterface;
using Naro.Infrastructure.Library.Actions;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Constants;
using NaroUiBuilder;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    public class StartSketch : DrawingLiveShape
    {
        private static readonly ILog Log = LogManager.GetLogger("StartSketch");
        private ISketchButton _sketchButton;
        private Point3D _coordinate;
        public StartSketch()
            : base(ModifierNames.StartSketch)
        {
        }

        public override void OnDeactivate()
        {
            base.OnDeactivate();
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                          TopAbsShapeEnum.TopAbs_SOLID);
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.CoordinateParser, OnCoordinateParser);
        }

        #region Build from coordinates
        private void OnCoordinateParser(DataPackage data)
        {
            var text = (string)data.Data;
            if (text.Contains(","))
            {
                _coordinate = CoordinateParser.ParsePointValue(text, _coordinate);
                AddNewPoint(_coordinate);
            }
            if (Points.Count < 4) return;
        }

        private void AddNewPoint(Point3D coordinate)
        {
            if (Points.Count == 4 && Points[0].IsEqual(coordinate))
                return;
            if (Points.Contains(coordinate))
                return;
            Points[Points.Count - 1] = coordinate;
            AddNewEmptyPoint();
            if (Points.Count <= 2) return;
            BuildFinalSketch();
            UpdateView();
            Reset();
        }

        private void BuildAndEnterSketch(Document document)
        {
            var sketchCreator = new SketchCreator(document);
            var currentSketch = sketchCreator.CurrentSketch;
            var sketchNodeBuilder = new NodeBuilder(currentSketch);
            Document.Transact();

            Log.InfoFormat("StartSketch - Command line input");
            var firstvector = new gpDir(Points[1].GpPnt.X - Points[0].GpPnt.X, Points[1].GpPnt.Y - Points[0].GpPnt.Y, Points[1].GpPnt.Z - Points[0].GpPnt.Z);
            var secondvector = new gpDir(Points[2].GpPnt.X - Points[0].GpPnt.X, Points[2].GpPnt.Y - Points[0].GpPnt.Y, Points[2].GpPnt.Z - Points[0].GpPnt.Z);
            var normal = firstvector.Crossed(secondvector);
            var _normalOnPlane = new gpAx1(Points[0].GpPnt, normal);
            var sketchAx2 = new gpAx2();
            sketchAx2.Axis = (_normalOnPlane);
            var plane = new gpPln(new gpAx3(sketchAx2));
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, plane);
            sketchNodeBuilder[0].Axis3D = new Axis(sketchNodeBuilder[0].Axis3D.Location, new Point3D(new gpPnt(_normalOnPlane.Direction.XYZ)));
            HighlightCurrentSketchNodes(sketchNodeBuilder.Node);
            NodeBuilderUtils.HidePlanes(Document);
            Document.Commit("sketch created");
            AddNodeToTree(sketchNodeBuilder.Node);
            Document.Transact();
            Document.Root.Get<DocumentContextInterpreter>().ActiveSketch = sketchNodeBuilder.Node.Index;
            _sketchButton.Block();
            Document.Commit("Started editing sketch");
        }

        private void BuildFinalSketch()
        {
            InitSession();
            BuildAndEnterSketch(Document);
        }
        #endregion

        private void Reset()
        {
            Points.Clear();
            AddNewEmptyPoint();
            ShowHint("First point");
        }

        /// <summary>
        /// Called when Enter Sketch is pressed. If a node is selected in the tree or a shape is selected on the drawing stage, 
        /// the sketch containing that node/shape is selected for editing, otherwise a new sketch will be created in OnMouseDownAction
        /// </summary>
        public override void OnActivate()
        {
            base.OnActivate();
            if(Document.Root.Children.Count > 0)
                Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                          TopAbsShapeEnum.TopAbs_FACE);
            else
                Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                TopAbsShapeEnum.TopAbs_SOLID);
            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.Unknown);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Disable);
            Reset();
            ShowHint(ModelingResources.StartSketch);
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            var uiBuilder = ActionsGraph[InputNames.UiBuilderInput].Get<UiBuilder>();
            var sketchControl = uiBuilder.GetItemAtPath("Ribbon/Modelling/Sketch/Sketch");
            _sketchButton = (ISketchButton)sketchControl;
            var selected = Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get<List<SceneSelectedEntity>>();
            Node node = null;
            if (selected.Count > 0)
                node = selected[0].Node;
            else
                node = Inputs[InputNames.NodeSelect].GetData(NotificationNames.GetValue).Get<Node>();
            if(node != null)
            {
                Node sketchNode = AutoGroupLogic.FindSketchNode(node);

                if (sketchNode != null)
                {
                    Document.Transact();
                    Document.Root.Get<DocumentContextInterpreter>().ActiveSketch = sketchNode.Index;
                    NodeUtils.SetSketchTransparency(Document, sketchNode, 0);
                    Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
                    var axis = new NodeBuilder(sketchNode)[0].TransformedAxis3D;
                    var plane = new gpPln(new gpAx3(axis.Location, axis.Direction));
                    Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, plane);
                    //if (Inputs[InputNames.Mouse3DEventsPipe].GetData(NotificationNames.GetPlane).Data == null)
                    //{
                    //    var plane = new gpPln(new gpAx3());
                    //    Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, plane);
                    //    //ActionsGraph[InputNames.View].Send(NotificationNames.SwitchView, plane);
                    //}
                    _sketchButton.Block();
                    HighlightCurrentSketchNodes(sketchNode);
                    Document.Commit("Started editing sketch");
                    BackToNeutralModifier();
                    
                    Log.Info("StartSketch - current sketch exists");
                    _sketchButton.Block();
                    return;
                }
            }
            if (Document.Root.Children.Count == 0)
            {
                CreatePlane(new Point3D(-20, -10, 0), new Point3D(20, -10, 0),
                            new Point3D(20, 10, 0), new Point3D(-20, 10, 0), "Top");
                CreatePlane(new Point3D(-20, 0, -10), new Point3D(20, 0, -10),
                            new Point3D(20, 0, 10), new Point3D(-20, 0, 10), "Right");
                CreatePlane(new Point3D(0, -20, -10), new Point3D(0, 20, -10),
                            new Point3D(0, 20, 10), new Point3D(0, -20, 10), "Front");
                Document.Commit("Default planes created");
            }
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Enable);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                          TopAbsShapeEnum.TopAbs_FACE);
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
            var sketchCreator = new SketchCreator(Document, false);
            if (sketchCreator.CurrentSketch == null)
            {
                ShowHint(ModelingResources.StartSketch);
                Log.Info("StartSketch - no current sketch");
            }
         
        }

        private void CreatePlane(Point3D point1, Point3D point2, Point3D point3, Point3D point4, string displayName)
        {
            var planeNode = new NodeBuilder(Document, FunctionNames.Plane, displayName);
            planeNode[0].TransformedPoint3D = point1;
            planeNode[1].TransformedPoint3D = point2;
            planeNode[2].TransformedPoint3D = point3;
            planeNode[3].TransformedPoint3D = point4;
            planeNode.ExecuteFunction();
            AddNodeToTree(planeNode.Node);
        }

        /// <summary>
        /// A new sketch is created: if the user clicked on the face of a solid, that face's normal is used as axis for the new sketch, otherwise 
        /// the default axis with position (0,0,0) and direction (0,0,1) is used.
        /// </summary>
        /// <param name="mouseData"></param>
        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            base.OnMouseDownAction(mouseData);

            Log.Info("StartSketch - OnMouseDownAction");

            //var checkSketch = new SketchCreator(Document, false);
            //if (checkSketch.CurrentSketch != null) return;
            Log.Info("StartSketch - OnMouseDownAction - current sketch null");

            var sketchCreator = new SketchCreator(Document);
            var currentSketch = sketchCreator.CurrentSketch;
            var sketchNodeBuilder = new NodeBuilder(currentSketch);

            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.BuildSelections, mouseData);
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            
            var selectedFace = (SelectionInfo)Inputs[InputNames.Mouse3DEventsPipe].GetData(NotificationNames.GetFace).Data;
            Document.Transact();
            var transformationInfo = new TransformationInfo();
            transformationInfo.SketchIndex = sketchNodeBuilder.Node.Index;
            Log.InfoFormat("StartSketch - OnMouseDownAction - selected entities count {0}", entities.Count);
            var normalOnPlane = new Axis(new Point3D(0, 0, 0), new Point3D(0, 0, 1)).GpAxis;
            if (Inputs[InputNames.Mouse3DEventsPipe].GetData(NotificationNames.GetPlane).Data != null)
            {
               
                normalOnPlane.Location = 
                    ((gpPln) Inputs[InputNames.Mouse3DEventsPipe].GetData(NotificationNames.GetPlane).Data).Axis.Location; 
                normalOnPlane.Direction =
                    ((gpPln) Inputs[InputNames.Mouse3DEventsPipe].GetData(NotificationNames.GetPlane).Data).Axis.Direction;
                if (selectedFace != null)
                {
                    var _3DShapesFunctions = new List<string>();
                    _3DShapesFunctions.AddRange(new[] { FunctionNames.Sphere, FunctionNames.Box, FunctionNames.Cylinder,
                        FunctionNames.Torus, FunctionNames.Cone, FunctionNames.Plane});
                    var nb = new NodeBuilder(selectedFace.selectedNode);
                    if (nb.FunctionName == string.Empty || _3DShapesFunctions.Contains(nb.FunctionName))
                    {
                        transformationInfo.RefSketchIndex = -1;
                    }
                    else
                    {
                        transformationInfo.RefSketchIndex = nb.Dependency[0].Reference.Index;
                        var faces = GeomUtils.ExtractFaces(nb.Shape);
                        var face = faces[selectedFace.face];
                        var orientation = face.Orientation();
                        if (orientation == TopAbsOrientation.TopAbs_REVERSED)
                            normalOnPlane.Direction = normalOnPlane.Direction.Reversed;
                    }
                }
                else
                {
                    transformationInfo.RefSketchIndex = -1;
                }
            }
            else
            {
                var plane = new gpPln(new gpAx3());
                Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, plane);
                transformationInfo.RefSketchIndex = -1;
            }

            if(selectedFace != null)
            {
                var nb = new NodeBuilder(selectedFace.selectedNode);
                if (nb.FunctionName != FunctionNames.Plane)
                {
                    sketchNodeBuilder[2].Reference = nb.Node;
                    sketchNodeBuilder[3].Integer = selectedFace.face;
                }
            }
            _sketchButton.Block();
          
            sketchNodeBuilder[0].TransformedAxis3D = new Axis(new Point3D(0, 0, 0), new Point3D(0, 0, 1)).GpAxis;
            var transformation = sketchNodeBuilder.Node.Set<TransformationInterpreter>();
                   
            if (selectedFace != null)
            {
                var solids = new List<string>{string.Empty};
                solids.AddRange(FunctionNames.GetSolids());
                if (solids.Contains(new NodeBuilder(selectedFace.selectedNode).FunctionName))
                {
                    var oldSystemAxis = new gpAx3(new gpPnt(0,0,0), new gpDir(0,0,1));
                    var newSystemAxis = new gpAx3(normalOnPlane.Location, normalOnPlane.Direction);
                    gpTrsf T = new gpTrsf();
                    T.SetTransformation(oldSystemAxis, newSystemAxis);
                    transformation.CurrTransform = T.Inverted;
                }
                else
                {
                    var allTrsfs = 
                        NodeBuilderUtils.GetTransformedAxis(
                            new NodeBuilder(selectedFace.selectedNode).Dependency[0].ReferenceBuilder);
                    gpTrsf T = new gpTrsf();
                    var oldSystemAxis = new gpAx3(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
                  //  var oldSystemAxis = new gpAx3(allTrsfs.Location, allTrsfs.Direction);
                    normalOnPlane.Direction = NodeBuilderUtils.RoundToPrecision(normalOnPlane.Direction);
                    var newSystemAxis = new gpAx3(normalOnPlane.Location, normalOnPlane.Direction);
                   // T.SetDisplacement(oldSystemAxis, newSystemAxis);
                    T.SetTransformation(oldSystemAxis, newSystemAxis);
                    transformation.CurrTransform = T.Inverted;
                }
                transformationInfo.Transformation = transformation.CurrTransform;
            }
            else
            {
                transformation.TranslateWith(new Point3D(normalOnPlane.Location));
                transformationInfo.Transformation = transformation.CurrTransform;
            }
            transformationInfo.TrsfIndex = TransformationInfo.maxTrsfIndex;
            TransformationInfo.maxTrsfIndex++;
            TransformationInterpreter.Transformations.Add(transformationInfo);
    
            sketchNodeBuilder.ExecuteFunction();
            
            AddNodeToTree(sketchNodeBuilder.Node);
            NodeBuilderUtils.HidePlanes(Document);
            HighlightCurrentSketchNodes(sketchNodeBuilder.Node);
            Document.Commit("sketch created");
            BackToNeutralModifier();
            
        }

        private void HighlightCurrentSketchNodes(Node currentSketch)
        {
            var results = new List<NodeBuilder>();
            results.AddRange(from node in Document.Root.ChildrenList
                             let builder = new NodeBuilder(node)
                             where FunctionNames.GetSketchShapes().Contains(builder.FunctionName)
                             select builder);
            foreach (var nodeBuilder in results)
            {
                var sketchNode = NodeBuilderUtils.FindSketchNode(nodeBuilder.Node);
                nodeBuilder.Color = sketchNode.Index == currentSketch.Index? Color.DarkTurquoise :  Color.Gray;
            }
        }
    }
}
