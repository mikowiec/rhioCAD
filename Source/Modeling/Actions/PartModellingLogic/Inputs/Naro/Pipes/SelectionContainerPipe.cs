#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.BRepAlgoAPI;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAPI;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NaroPipes.Constants;
using NaroSketchAdapter.Rules.Naro;
using OccCode;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using System.Linq;
#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    internal class SelectionContainerPipe : InteractiveWorkPipe
    {
        private AISInteractiveContext _context;
        private Document _document;
        private bool _prevMouse;
        private SelectionContainer _selectionContainer;

        public SelectionContainerPipe()
            : base(InputNames.SelectionContainerPipe)
        {
        }

        private bool Enabled { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();
            MapInputs();
            MapNotifications();

            var geomUtilsWrapper = new GeomUtilsWrapper();
            _selectionContainer = new SelectionContainer(geomUtilsWrapper);

            Enabled = true;
        }

        private void MapInputs()
        {
            DependsOn(InputNames.Mouse3DEventsPipe);
            DependsOn(InputNames.Context, SourceContextHandler);
            DependsOn(InputNames.Document, SourceDocumentHandler);
            DependsOn(InputNames.GeometricSolverPipe, SourceSolverHandler);
            DependsOn(InputNames.UiElementsItem);
        }

        private void MapNotifications()
        {
            AddNotificationHandler(NotificationNames.SwitchSelectionMode, OnSwitchSelectionMode);
            AddNotificationHandler(NotificationNames.Cleanup, OnCleanup);
            AddNotificationHandler(NotificationNames.GetEntities, OnGetEntities);
            AddNotificationHandler(NotificationNames.GetSelectedFace, OnGetSelectedFace);
            AddNotificationHandler(NotificationNames.BuildSelections, OnBuildSelections);
            AddNotificationHandler(NotificationNames.Disable, OnDisabled);
            AddNotificationHandler(NotificationNames.Enable, OnEnabled);
            AddNotificationHandler(NotificationNames.GetContainer, OnGetContainer);
            AddNotificationHandler(NotificationNames.GetSelectionMode, OnGetSelectionMode);
            AddNotificationHandler(NotificationNames.SetZoomLevel, SetZoomLevel);
        }

        private void SetZoomLevel(DataPackage data)
        {
            var points = NodeUtils.GetAllVisiblePoints(_document);
            foreach (var point in points)
            {
                var nb = new NodeBuilder(point);
                nb.ExecuteFunction();
            }
        }

        private void OnGetSelectionMode(DataPackage data)
        {
            ReturnData = new DataPackage(_selectionContainer.CurrentSelectionMode);
        }

        private void OnGetContainer(DataPackage data)
        {
            ReturnData = new DataPackage(_selectionContainer);
        }

        private void OnEnabled(DataPackage data)
        {
            Enabled = true;
        }

        private void OnDisabled(DataPackage data)
        {
            Enabled = false;
        }

        private void OnBuildSelections(DataPackage dataPackage)
        {
            var data = dataPackage.Get<Mouse3DPosition>();
            _selectionContainer.BuildSelections(data);
        }

        private void OnGetEntities(DataPackage data)
        {
            ReturnData = new DataPackage(_selectionContainer.Entities);
        }

        private void OnGetSelectedFace(DataPackage data)
        {
            ReturnData = new DataPackage(_selectionContainer.selectedFace);
        }

        private void OnCleanup(DataPackage data)
        {
            _selectionContainer.CleanupDetectionEnvironment();
        }

        public override void OnConnect()
        {
            base.OnConnect();

            _selectionContainer.Context = _context;
            _selectionContainer.Document = _document;
        }

        private void SourceSolverHandler(DataPackage data)
        {
            MouseEventHandler(data.Get<Mouse3DPosition>());
            AddData(data.Data);
        }

        private void SourceDocumentHandler(DataPackage data)
        {
            _document = data.Get<Document>();
        }

        private void SourceContextHandler(DataPackage data)
        {
            _context = data.Get<AISInteractiveContext>();
        }

        private void MouseEventHandler(Mouse3DPosition mouseData)
        {
           if (_prevMouse != mouseData.MouseDown)
                MouseClickHandler(mouseData);
            else
                MouseMoveHandler(mouseData);
            _prevMouse = mouseData.MouseDown;
        }
        private gpPln viewPlane = new gpPln();
        private void MouseMoveHandler(Mouse3DPosition mousePosition)
        {
            _context.MoveTo(mousePosition.Initial2Dx, mousePosition.Initial2Dy, ViewItems.View);
            if (!Enabled)
                return;
            if (mousePosition.MouseDown == false)
                return;
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.Enable, SolverRuleNames.EdgeMatch);
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.Enable, SolverRuleNames.PlaneMatch);
            var solverPipe = Inputs[InputNames.GeometricSolverPipe];
              var eventsPipePlane = Inputs[InputNames.Mouse3DEventsPipe].GetData(NotificationNames.GetPlane);
            viewPlane = new gpPln();
            if (eventsPipePlane.Data == null)
                viewPlane = GeomUtils.PlaneOfTheView(ViewItems.View);
            else
                viewPlane = (gpPln) eventsPipePlane.Data;
            if (_selectionContainer.Entities.Count == 1 && _selectionContainer.Entities[0].ShapeType == TopAbsShapeEnum.TopAbs_FACE)
                return;
           
            DrawSelectionRectangle(new gpAx2(viewPlane.Axis.Location, viewPlane.Axis.Direction), startPoint, mousePosition.Point );

           var geometricSolver = solverPipe.GetData(NotificationNames.GetSolver).Get<GeometricSolver>();
           var results = geometricSolver.GetInterestingCloseGeometry(viewPlane, mousePosition.Point);
            foreach(var result in results)
            {
                var solverPointResult = result as SolverPointResult;
                if (solverPointResult != null && !selectedNodesIndexes.Contains((solverPointResult).ParentIndex))
                {
                    selectedNodesIndexes.Add((solverPointResult).ParentIndex);
                }
            }
        }

        List<NodeBuilder> lines = new List<NodeBuilder>();

        private void DrawSelectionRectangle(gpAx2 axis, Point3D _firstPoint, Point3D _secondPoint)
        {
            _document.Transact();
            var point3Ds = new List<Point3D>();
            var firstPoint2D = _firstPoint.ToPoint2D(axis);
            var secondPoint2D = _secondPoint.ToPoint2D(axis);

            var x1 = firstPoint2D.X;
            var y1 = firstPoint2D.Y;
            var x2 = secondPoint2D.X;
            var y2 = secondPoint2D.Y;
            var color = x1 < x2 ? Color.Gold : Color.White;
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, x1, y1));
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, x2, y1));
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, x2, y2));
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, x1, y2));
            var pointLinker = new SketchCreator(_document).PointLinker;
            lines = new List<NodeBuilder>
                    {
                        BuildLine(_document, pointLinker, point3Ds[0], point3Ds[1]),
                        BuildLine(_document, pointLinker, point3Ds[1], point3Ds[2]),
                        BuildLine(_document, pointLinker, point3Ds[2], point3Ds[3]),
                        BuildLine(_document, pointLinker, point3Ds[3], point3Ds[0])
                    };
            var sseList = new List<SceneSelectedEntity>();
            foreach(var line in lines)
            {
                var sse = new SceneSelectedEntity(line.Node);
                sseList.Add(sse);
            }
            var builder = new NodeBuilder(_document, FunctionNames.Face);
            builder[0].ReferenceList = sseList;
            builder.Color = color;
            builder.ExecuteFunction();
            selectionFace = builder.Shape;
        }

        private TopoDSShape selectionFace;

        private static NodeBuilder BuildLine(Document document, DocumentPointLinker documentPointLinker,
                                           Point3D firstCoordinate, Point3D secondCoordinate)
        {
            var firstPoint = documentPointLinker.GetPoint(firstCoordinate);
            firstPoint.Visibility = ObjectVisibility.Hidden;
            var secondPoint = documentPointLinker.GetPoint(secondCoordinate);
            secondPoint.Visibility = ObjectVisibility.Hidden;
            var line = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            line[0].Reference = firstPoint.Node;
            line[1].Reference = secondPoint.Node;
            line.Color = Color.Gray;
            line.ExecuteFunction();
            return line;
        }

        private List<int> selectedNodesIndexes = new List<int>();
        private int startX = 0;
        private int startY = 0;
        private Point3D startPoint;

        private Dictionary<int, TopoDSEdge> edgeMappings = new Dictionary<int, TopoDSEdge>(); 

        private void MouseClickHandler(Mouse3DPosition mousePosition)
        {
            if (!Enabled) return;
            var matchingSketches = new List<int>();
            if (mousePosition.MouseDown == false)
            {
                var linesEdges = (from line in lines where line != null && line.Shape != null select GeomUtils.ExtractEdge(line.Shape)).ToList();
                _document.Revert();

                // continue only if we have a drag action
                if (Math.Abs(mousePosition.Initial2Dx - startX) < 3 && Math.Abs(mousePosition.Initial2Dy - startY) < 3)
                    return;
                bool leftToRight = startX < mousePosition.Initial2Dx ? true : false;

                if (selectionFace == null)
                    return;
                var sketchNodes = NodeUtils.GetDocumentNodesOfType(_document, FunctionNames.Sketch);

                // find all sketches that are on the same plane as the selection
                matchingSketches.AddRange(from sketchNodeIndex in sketchNodes 
                                          let nb = new NodeBuilder(_document.Root[sketchNodeIndex]) 
                                          let normal = nb.Dependency[0].TransformedAxis3D
                                          where normal.IsParallel(viewPlane.Axis, Precision.Confusion) 
                                          select sketchNodeIndex);

                var pointsToShapeMapping = new Dictionary<int, List<int>>();
                var shapeToPointMapping = new Dictionary<int, List<int>>();
                var functionNames = new List<string> { FunctionNames.Circle, FunctionNames.Ellipse, FunctionNames.LineTwoPoints, FunctionNames.Arc, FunctionNames.Arc3P };
                var selectedShapes = new List<int>();
               foreach(var index in matchingSketches)
               {
                   var sketchPoints = NodeUtils.GetSketchPoints(_document.Root[index], _document);
                   // find all shapes and points on the matching sketches
                   foreach(var node in _document.Root.Children)
                   {
                       var builder = new NodeBuilder(node.Value);
                       if(functionNames.Contains(builder.FunctionName))
                       {
                            var currentSketchNode = AutoGroupLogic.FindSketchNode(node.Value);
                            if(currentSketchNode.Index == index)
                            {
                                if (builder.FunctionName == FunctionNames.Circle)
                                {
                                    if(!pointsToShapeMapping.ContainsKey(builder.Dependency[0].Node.Index))
                                        pointsToShapeMapping.Add(builder.Dependency[0].ReferenceBuilder.Node.Index,
                                                                new List<int> {builder.Node.Index});
                                    else
                                        pointsToShapeMapping[builder.Dependency[0].ReferenceBuilder.Node.Index].Add(builder.Node.Index);

                                    shapeToPointMapping.Add(builder.Node.Index, new List<int> { builder.Dependency[0].ReferenceBuilder.Node.Index });
                                }
                                else
                                {
                                    var pointsList = new List<int>();
                                    for(int k=0;k<builder.Dependency.Count;k++)
                                    {
                                        if(!pointsToShapeMapping.ContainsKey(builder.Dependency[k].ReferenceBuilder.Node.Index))
                                            pointsToShapeMapping.Add(builder.Dependency[k].ReferenceBuilder.Node.Index,new List<int>{ builder.Node.Index});
                                        else
                                            pointsToShapeMapping[builder.Dependency[k].ReferenceBuilder.Node.Index].Add(builder.Node.Index);
                                        pointsList.Add(builder.Dependency[k].ReferenceBuilder.Node.Index);
                                    }
                                    shapeToPointMapping.Add(builder.Node.Index, pointsList);
                                }
                            }

                           var edge = GeomUtils.ExtractEdge(builder.Shape);
                           if(edge!= null && ! edgeMappings.ContainsKey(builder.Node.Index))
                               edgeMappings.Add(builder.Node.Index, edge);
                       }
                   }
                   var selectedPoints = new List<int>();

                   // check which points are inside the selection
                   foreach(var point in sketchPoints)
                   {
                       var shapeFace = new NodeBuilder(point).Shape;
                       if (shapeFace == null)
                           continue;
                       var common = new BRepAlgoAPICommon(selectionFace, shapeFace);
                       if (common.IsDone)
                       {
                           var commonArea = GeomUtils.GetFaceArea(common.Shape);
                           if (commonArea > 0)
                               selectedPoints.Add(point.Index);
                       }
                       _document.Transact();
                   }

                   // Left->Right - only shapes that are fully inside the selection box are selected
                   if (leftToRight)
                   {
                       foreach(var point in selectedPoints)
                       {
                           if(!pointsToShapeMapping.ContainsKey(point))
                           {
                               selectedShapes.Add(point);
                               continue;
                           }
                           var shapes = pointsToShapeMapping[point];
                           foreach(var shape in shapes)
                           {
                               var points = shapeToPointMapping[shape];
                               var allPointsAreSelected = true;
                               foreach (var pointIndex in points)
                                   if (!selectedPoints.Contains(pointIndex))
                                   {
                                       allPointsAreSelected = false;
                                       break;
                                   }
                               if(allPointsAreSelected)
                                   selectedShapes.Add(shape);
                           }
                       }
                       selectedShapes = selectedShapes.Distinct().ToList();
                   }
                   else
                   {
                       // Right->Left - shapes that are corssed by the selection box are also included in the selection
                       foreach (var point in selectedPoints)
                       {
                           if (pointsToShapeMapping.ContainsKey(point))
                               selectedShapes.AddRange(pointsToShapeMapping[point]);
                           else
                               selectedShapes.Add(point);
                       }
                       foreach(var edgeMapping in edgeMappings)
                       {
                           if(!selectedShapes.Contains(edgeMapping.Key))
                           {
                               foreach(var line in linesEdges)
                               {
                                   var intersection = GeomUtils.IntersectionPoints(line, edgeMapping.Value);
                                   if(intersection.Count >0)
                                   {
                                       selectedShapes.Add(edgeMapping.Key);
                                       break;
                                   }
                               }
                           }
                       }
                   }
               }
                    selectedShapes = selectedShapes.Distinct().ToList();
                    _selectionContainer.BuildSelections(selectedShapes);

                    Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTabMultipleSelections, _selectionContainer.Entities);
                    _document.Transact();
                return;
            }
            
            selectedNodesIndexes.Clear();
            startX = mousePosition.Initial2Dx;
            startY = mousePosition.Initial2Dy;
            startPoint = mousePosition.Point;

            var correctedMousePosition = CalculateCorrectCoordinate(mousePosition);
            _context.MoveTo(correctedMousePosition.Initial2Dx, correctedMousePosition.Initial2Dy, ViewItems.View);

            if (mousePosition.MouseDown)
            {
                if (mousePosition.ShiftDown)
                    _context.ShiftSelect(true);
                else
                    _context.Select(true);
            }

            // Perform click selection using the corrected coordinate
           _selectionContainer.BuildSelections(correctedMousePosition);
           if (_selectionContainer.Entities.Count == 2)
           {
               Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTabTwoSelections, _selectionContainer.Entities);
           }
            if(_selectionContainer.Entities.Count == 1)
            {
                Inputs[InputNames.UiElementsItem].Send(NotificationNames.SelectNode, _selectionContainer.Entities[0].Node);
            }
        }

        private Mouse3DPosition CalculateCorrectCoordinate(Mouse3DPosition mousePosition)
        {
            var correctedMousePosition = new Mouse3DPosition(mousePosition);

            var initialSelection = _selectionContainer.CurrentSelectionMode;
           /* if ((_selectionContainer.CurrentSelectionMode != OCTopAbs_ShapeEnum.TopAbs_SOLID)
                 && (_selectionContainer.CurrentSelectionMode != OCTopAbs_ShapeEnum.TopAbs_COMPOUND))*/
           
            if (_selectionContainer.CurrentSelectionMode == TopAbsShapeEnum.TopAbs_EDGE)
            {
                return correctedMousePosition;
            }
            _selectionContainer.SwitchSelectionMode(TopAbsShapeEnum.TopAbs_FACE);

            _context.MoveTo(mousePosition.Initial2Dx, mousePosition.Initial2Dy, ViewItems.View);
            _selectionContainer.BuildSelections(mousePosition);
             if(_selectionContainer.Entities.Count == 1)
             {
                // we have a selected face
                 _selectionContainer.selectedFace = _selectionContainer.Entities[0];
             }
            CorrectCoordinateOnSelectedFace(mousePosition, correctedMousePosition);

            _selectionContainer.SwitchSelectionMode(initialSelection);
            return correctedMousePosition;
        }

        private void CorrectCoordinateOnSelectedFace(Mouse3DPosition mousePosition,
                                                     Mouse3DPosition correctedMousePosition)
        {
            var currentAction = this._document.Root.Get<ActionGraphInterpreter>().ActionsGraph.CurrentAction;
            if (_selectionContainer[TopAbsShapeEnum.TopAbs_FACE].Count <= 0)
            {
                if (currentAction.Name == ModifierNames.StartSketch)
                {
                    SelectionInfo selInfo = null;
                    Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetFace, selInfo);
                }
                return;
            }
            var face = _selectionContainer[TopAbsShapeEnum.TopAbs_FACE][0].TargetShape();
            var plane = GeomUtils.ExtractPlane(face);
            if (plane == null) return;
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, plane);

            
            if (currentAction.Name == ModifierNames.StartSketch)
            {
                var selectionInfo = new SelectionInfo
                                {
                                    selectedNode = _selectionContainer[TopAbsShapeEnum.TopAbs_FACE][0].Node,
                                    face = _selectionContainer[TopAbsShapeEnum.TopAbs_FACE][0].ShapeCount - 1
                                };
                var nb = new NodeBuilder(_selectionContainer[TopAbsShapeEnum.TopAbs_FACE][0].Node);
                var faces = GeomUtils.ExtractFaces(nb.Shape);
                int count = 0;
                foreach (var face1 in faces)
                {
                    var direction = GeomUtils.ExtractPlane(face1);
                    if (direction == null)
                    {
                        count++;
                        continue;
                    }
                   if(direction.Axis.Direction.IsEqual(plane.Axis.Direction, Precision.Confusion) && 
                        direction.Axis.Location.IsEqual(plane.Axis.Location, Precision.Confusion))
                        break;
                    count++;
                }

                selectionInfo.face = count;
                Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetFace, selectionInfo);
            }
            double x = 0;
            double y = 0;
            double z = 0;
            var isOnPlane = GeomUtils.ConvertToPlane(ViewItems.View, plane, mousePosition.Initial2Dx,
                                                     mousePosition.Initial2Dy, ref x, ref y, ref z);
            if (isOnPlane)
                correctedMousePosition.Point = new Point3D(x, y, z);
        }

        private void OnSwitchSelectionMode(DataPackage dataPackage)
        {
            _selectionContainer.SwitchSelectionMode(dataPackage.Get<TopAbsShapeEnum>());
        }
    }
}