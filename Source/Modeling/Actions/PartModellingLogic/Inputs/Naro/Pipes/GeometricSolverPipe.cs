#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.PartModeling;
using NaroCAD.SolverModule.Factory;
using NaroCppCore.Occ.gp;
using NaroSetup;
using NaroSetup.Pages.Solver;
using NaroSketchAdapter;
using NaroCAD.SolverModule;
using NaroSketchAdapter.Factory;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using TreeData.NaroData;
using log4net;
using Naro.Infrastructure.Library.GeomHelpers;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs.Layers;
using NaroCAD.SolverModule;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroPipes.Actions;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using Naro.Infrastructure.Library.Algo;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    /// <summary>
    /// Listens to Mouse3DEventsPipe. The 3D coordinates received are passed through
    /// the hinter algorithms and the resulting 3D coordinates are sent to GeometricSolverPipe
    /// listeners.
    /// Draws solver hints on a separate layer.
    /// </summary>
    public class GeometricSolverPipe : ViewBasedPipe
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (GeometricSolverPipe));

        private readonly SolverDrawer _solverDrawer;
        private OcLayer2DManager _manager;
        private Point3D? _previousPoint;
      
        private List<SolverPreviewObject> _solverGeometry = new List<SolverPreviewObject>();

        public GeometricSolverPipe(Solver solver,
                                   SolverDrawer solverDrawer)
            : base(InputNames.GeometricSolverPipe)
        {
            Solver = solver;
            _solverDrawer = solverDrawer;
        }

        private bool PreviousMouseDown { get; set; }
        private Solver Solver { get; set; }


        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.Mouse3DEventsPipe, OnMouseData);
            AddNotificationHandler(NotificationNames.Suspend, Suspend);
            AddNotificationHandler(NotificationNames.Resume, Resume);
            AddNotificationHandler(NotificationNames.EnableAll, EnableAll);
            AddNotificationHandler(NotificationNames.DisableAll, DisableAll);
            AddNotificationHandler(NotificationNames.Enable, EnableRule);
            AddNotificationHandler(NotificationNames.Disable, DisableRule);
            AddNotificationHandler(NotificationNames.ResetPreviousPoint, ResetPreviousPoint);
            AddNotificationHandler(NotificationNames.GetSolver, GetSolver);

            _solverDrawer.SetActionGraph(ActionsGraph);
        }

        private void ResetPreviousPoint(DataPackage data)
        {
            _previousPoint = null;
        }

        public override void OnConnect()
        {
            base.OnConnect();
            if (_manager != null) return;
            _manager = ActionsGraph[InputNames.View].GetData(NotificationNames.GetLayerManager).Get<OcLayer2DManager>();
        }

        private Point3D ApplyCoordinateIncrements(Point3D mouseData)
        {
            var actionsGraph = _solverDrawer.Document.Root.Get<ActionGraphInterpreter>().ActionsGraph;
            var optionsSetup = actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);
            var XIncrement = optionsSection.GetDoubleValue((int)HinterOptionFields.XIncrement);
            var YIncrement = optionsSection.GetDoubleValue((int)HinterOptionFields.YIncrement);
            var ZIncrement = optionsSection.GetDoubleValue((int)HinterOptionFields.ZIncrement);
            var newPoint = new Point3D();
            newPoint.X = XIncrement > 0.00001 ? Math.Round(mouseData.X / XIncrement) * XIncrement : mouseData.X;
            newPoint.Y = YIncrement > 0.00001 ? Math.Round(mouseData.Y / YIncrement) * YIncrement : mouseData.Y;
            newPoint.Z = ZIncrement > 0.00001 ? Math.Round(mouseData.Z / ZIncrement) * ZIncrement : mouseData.Z;
            return newPoint;
        }

        private void OnMouseData(DataPackage data)
        {
            var mouseData = data.Get<Mouse3DPosition>();
            //if (_solverSuspended)
            //    return;

            // Pass the coordinates through the solver
            // Check if there are any magic points around
          
            mouseData.Point = ApplyCoordinateIncrements(mouseData.Point);
            gpPln sketchPlane = null;
            var eventsPipePlane = Inputs[InputNames.Mouse3DEventsPipe].GetData(NotificationNames.GetPlane);
            if (eventsPipePlane != null)
            {
                sketchPlane = ((gpPln) eventsPipePlane.Data);
            }
            if (sketchPlane == null)
              sketchPlane = GeomUtils.PlaneOfTheView(ViewItems.View);
      //      var viewPlane = GeomUtils.PlaneOfTheView(ViewItems.View);
            _solverGeometry = _previousPoint != null
                                  ? Solver.GetInterestingCloseGeometry(sketchPlane, mouseData.Point,
                                                                       (Point3D) _previousPoint)
                                  : Solver.GetInterestingCloseGeometry(sketchPlane, mouseData.Point);
            _solverDrawer.Transact();
            
            var _document = _solverDrawer.Document;
            _document.Transact();
            var edgeSuggestions = new List<SolverGeometricObject>();
       
            for(int i=0;i<_solverGeometry.Count;i++)
            {
                if (_solverGeometry[i] is SolverEdgeTwoPointsResult)
                {
                    var nb = TreeUtils.AddLineToNode(_document, (_solverGeometry[i]).Point, ((SolverEdgeTwoPointsResult)_solverGeometry[i]).SecondPoint, ObjectVisibility.Hidden);
                    var suggestion = SolverConstraintFactory.Instance.ExtractGeometry(nb.Node);
                    if (suggestion == null) continue;
                    edgeSuggestions.Add(suggestion);
                    nb.Visibility = ObjectVisibility.Hidden;
                }
            }
            
            foreach(var geomObj in edgeSuggestions)
            {
                if (geomObj == null) continue;
                var edges = GeomUtils.ExtractEdges(geomObj.Builder.Shape);
                geomObj.Edges.Add(new SolverEdge(edges[0]));
            }
            var mousePoint = mouseData.Point;

            if (_solverGeometry.Count > 0)
            {
                mousePoint = _solverGeometry[0].Point;
            }
            else
            {
                var clear = new SolverNoResult(mousePoint) { Text = string.Empty };
                _solverGeometry.Add(clear);
            }

            // we have more than one solution - move the point to the intersection
            if (edgeSuggestions.Count >= 2)
            {
                var intersections = SolverExtractLogic.GetIntersectionsPointList(edgeSuggestions);
                // if there is more than one intersection point, we need to choose the closest one
                if (intersections.Count > 0)
                {
                    if (intersections.Count == 1)
                    {
                        mousePoint = intersections[0];
                    }
                    else
                    {
                        mousePoint = GeomUtils.GetClosestPoint(intersections, mouseData.Point);
                    }
                }
            }

          //  _document.Revert();

            for (int index = 0; index < _solverGeometry.Count; index++)
            {
                // show all hinter lines
                var solverPreviewObject = ShowSolverGeometry(index);
                UpdateLayerPos(solverPreviewObject, mouseData);
            }

            mouseData.Axis.Location = (mousePoint.GpPnt);
            var mouse3DPosition = new Mouse3DPosition(mousePoint, mouseData.Axis, mouseData.MouseDown,
                                                      mouseData.ShiftDown,
                                                      mouseData.ControlDown, mouseData.Initial2Dx, mouseData.Initial2Dy);
            AddData(mouse3DPosition);
            ShowHinter(_document, _solverGeometry, mouse3DPosition, sketchPlane);
            // If it is a click store the coordinate of it
            if (mouseData.MouseDown && mouseData.MouseDown != PreviousMouseDown)
                _previousPoint = mousePoint;

            PreviousMouseDown = mouseData.MouseDown;

            ViewRedraw();
        }

        private void ShowHinter(Document _document, List<SolverPreviewObject> _solverGeometry, Mouse3DPosition mouseData, gpPln sketchPlane)
        {
            var axis = sketchPlane.Axis;
            axis.Location = new Point3D(0, 0, 0).GpPnt;
            var axis2 = new gpAx2();
            axis2.Axis = axis;
            var point3D = mouseData.Point;
            var pointOnplane = point3D.ToPoint2D(axis2);
            var constraintHints = new bool[]{false, false, false, false};

            for (int i = 0; i < _solverGeometry.Count; i++)
            {
                if (_solverGeometry[i] is SolverEdgeTwoPointsResult)
                {
                    switch (_solverGeometry[i].Type)
                    {
                        case ("Parallel X"):
                            constraintHints[0] = true;
                            break;
                        case ("Parallel Y"):
                            constraintHints[1] = true;
                            break;
                        case ("Parallel Line"):
                            constraintHints[2] = true;
                            break;
                        case ("Perpendicular Line"):
                            constraintHints[3] = true;
                            break;
                    }

                }
            }
            var currentX = pointOnplane.X;
            var currentY = pointOnplane.Y;
           
            NodeBuilderUtils.DrawConstraints(_document, axis2, currentX, currentY, constraintHints);
        }

        private SolverPreviewObject ShowSolverGeometry(int index)
        {
            if (_solverGeometry.Count == 0)
                return null;
            var solverPreviewObject = _solverGeometry[index];
            _solverDrawer.Show(solverPreviewObject);
            return solverPreviewObject;
        }

        private void DrawMarkerBox()
        {
            var lastPoint = new Point3D();
            const double size = 0.001;
            var temporary = new NodeBuilder(_solverDrawer.Document, FunctionNames.Box1P);
            temporary[0].TransformedPoint3D = lastPoint;
            temporary[1].Real = size;
            temporary[2].Real = size;
            temporary[3].Real = size;
            temporary.Color = Color.Red;
            temporary.ExecuteFunction();
        }

        private void UpdateLayerPos(SolverPreviewObject solverPreviewObject, Mouse3DPosition mouseData)
        {
            DrawMarkerBox();
            var layer = _manager.SetLayer("SolverType");
            layer.SetPosition(mouseData.Initial2Dx+20, mouseData.Initial2Dy + 20);
            var text = solverPreviewObject == null ? string.Empty : solverPreviewObject.Text;
            layer.TextOut(text);
        }


        private static void Resume(DataPackage dataPackage)
        {
            Log.Debug("Solver - resumed");
        }

        private static void Suspend(DataPackage dataPackage)
        {
            Log.Debug("Solver - suspended");
        }

        private void GetSolver(DataPackage dataPackage)
        {
            ReturnData = new DataPackage(Solver);
        }

        private void DisableRule(DataPackage dataPackage)
        {
            Solver.DisableRule(dataPackage.Text);
        }

        private void EnableRule(DataPackage dataPackage)
        {
            Solver.EnableRule(dataPackage.Text);
        }

        private void DisableAll(DataPackage data)
        {
            Solver.DisableAllRules();
        }

        private void EnableAll(DataPackage data)
        {
            Solver.EnableAllRules();
        }

        public override void OnDisconnect()
        {
            // Hide the magic point
            _solverDrawer.Transact();
            _previousPoint = null;
        }
    }
}