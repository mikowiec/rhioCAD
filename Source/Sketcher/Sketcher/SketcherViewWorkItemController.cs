using System.Collections.Generic;
using Naro.Infrastructure.Library;
using Naro.Sketcher.Inputs;
using Naro.Solver.DataHelper;
using Naro.Solver.Rules;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using log4net;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.EventBroker;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Interface.Services;
using Naro.Infrastructure.Library.Geometry;
using Naro.Sketcher.Constants;
using Naro.Sketcher.Modifiers;
using Naro.Solver;
using OCNaroWrappers;

namespace Naro.Sketcher
{
	class SketcherViewWorkItemController : WorkItemController
	{
		private static readonly ILog log = LogManager.GetLogger(typeof(SketcherViewWorkItemController));

		private ISketcherView attachedView;
		private OCWNT_GraphicDevice device2d;
		private OCV2d_Viewer viewer2d;
		private OCAIS2D_InteractiveContext context2d;
		private OCV2d_View view2d;

		private Int32 _xMin, _xMax, _yMin, _yMax;
		private Solver.Solver _solver;
		private SolverDrawer _solverDrawer;

		private InputFactory inputFactory;
		private MouseEventsInput mouseInput;
		private WorkingPlaneInput workingPlaneInput;

	    private EditDetectionPipe _editDetectionPipe;

		Action3d _currentAction;

		public override void Run()
		{
			Application.DoEvents();

			attachedView = WorkItem.SmartParts.AddNew<SketcherView>(Constants.SmartPartNames.SketcherView);

			InitializeOpenCascade2D();

			// Initialize the solver
			_solver = new Solver.Solver();
			_solver.RuleSet = new RuleSet();
			_solver.RuleSet.Rules.Add(new PointMatch());

			_solverDrawer = new SolverDrawer();


			InitializeInputs();

			InitializeActions();

			SwitchActionType(ActionType.Action2d_Nothing, null);
		}

		#region InitializeActions
		void InitializeActions()
		{
			Update2DModifier.RegisterAction(ActionType.Action2d_DrawCircle, new DrawCircle());
			Update2DModifier.RegisterAction(ActionType.Action2d_DrawLine, new DrawLine());
			Update2DModifier.RegisterAction(ActionType.Action2d_DrawRectangle, new DrawRectangle());
			Update2DModifier.RegisterAction(ActionType.Action2d_DynamicPanning, new DynamicPanning());
			Update2DModifier.RegisterAction(ActionType.Action2d_DynamicZooming, new DynamicZooming());
			Update2DModifier.RegisterAction(ActionType.Action2d_Nothing, new Nothing());
			Update2DModifier.RegisterAction(ActionType.Action2d_WindowZooming, new WindowZooming());
			Update2DModifier.RegisterAction(ActionType.Action2d_FitAll, new FitAll());
			Update2DModifier.RegisterAction(ActionType.Action2d_DeactivateGrid, new DeactivateGrid());
			Update2DModifier.RegisterAction(ActionType.Action2d_GridLinesHandler, new GridLinesHandler());
			Update2DModifier.RegisterAction(ActionType.Action2d_GridPointsHandler, new GridPointsHandler());
			Update2DModifier.RegisterAction(ActionType.Action2d_CircularGridHandler, new CircularGridHandler());
			Update2DModifier.RegisterAction(ActionType.Action2d_CircularGridPointsHandler, new CircularGridPointsHandler());
			Update2DModifier.RegisterAction(ActionType.Action2d_GlobalPanning, new GlobalPanning());
            Update2DModifier.RegisterAction(ActionType.Action2d_EditShape, new EditAction());
		}
		#endregion

		#region InitializeInputs
		void InitializeInputs()
		{
			// Build the inputs and pipes
			inputFactory = new InputFactory();

			var viewInput = new View2dInput(view2d, viewer2d);
			inputFactory.Register(viewInput);
			mouseInput = new MouseEventsInput();
			inputFactory.Register(mouseInput);
			var mousePipe = new OCCMouseEventsPipe(view2d, viewer2d);
			inputFactory.RegisterPipe(mouseInput.Name, mousePipe);
			inputFactory.Register(mousePipe);

			var solverDrawerPipe = new SolverDrawerPipe(context2d, view2d, _solver, _solverDrawer);
			inputFactory.RegisterPipe(mousePipe.Name, solverDrawerPipe);
			inputFactory.Register(solverDrawerPipe);

            _editDetectionPipe = new EditDetectionPipe(context2d, view2d, _solver);
            inputFactory.RegisterPipe(solverDrawerPipe.Name, _editDetectionPipe);
            inputFactory.Register(_editDetectionPipe);
            _editDetectionPipe.ActivateActionHandler += new ActionActivatedEventHandler(EditDetectionPipe_ActivateActionHandler);

			var docInput = new DocumentInput(WorkItem.Services.Get<ILocalContextService>().CurrentOcafDocument);
			inputFactory.Register(docInput);

			var contextInput = new Context2dInput(context2d);
			inputFactory.Register(contextInput);

			OCTopoDS_Shape topoShape = WorkItem.Services.Get<ILocalContextService>().CurrentSelectedShape;
			workingPlaneInput = new WorkingPlaneInput(GeomUtils.ExtractAxis(topoShape));
			inputFactory.Register(workingPlaneInput);
		}

		#endregion
		
		public bool ContainsSmartPart(object smartPart)
		{
			return (attachedView == smartPart);
		}

		public void ResumeRunning()
		{
			// Set the current 2d context into the local service
			WorkItem.Services.Get<IContextService>().Current2DContext = context2d;

			// Show the 2D View
			WorkItem.Workspaces[Naro.Sketcher.Constants.WorkspaceNames.DrawingAreaWorkspace].Show(attachedView);
			view2d.Update();
			view2d.HasBeenMoved();
			view2d.MustBeResized(OCV2d_TypeOfWindowResizingEffect.V2d_TOWRE_ENLARGE_SPACE);

			// Clear the drawing area
			context2d.EraseAll(true, true);

			// Reactivate the grid
			viewer2d.ActivateGrid(OCAspect_GridType.Aspect_GT_Rectangular, OCAspect_GridDrawMode.Aspect_GDM_Lines);

			// Build the projection of the 3D to 2D
			Project3DModel();

			// Reset the working plane input
			OCTopoDS_Shape topoShape = WorkItem.Services.Get<ILocalContextService>().CurrentSelectedShape;
			workingPlaneInput.AddWorkingPlane(GeomUtils.ExtractAxis(topoShape));
		}

		public void SuspendRunning()
		{
			// Hide the View
			//WorkItem.Workspaces[WorkspaceNames.DrawingAreaWorkspace].Hide(attachedView);
		}

		public void Project3DModel()
		{
			OCTopoDS_Shape topoShape = WorkItem.Services.Get<ILocalContextService>().CurrentSelectedShape;
			if (topoShape == null)
			{
				return;
			}

			// Project the selected 3d object in the 2D plane

			// Make the projector
			bool isPerspective = WorkItem.Services.Get<ILocalContextService>().IsPerspective;
			OCgp_Pnt viewPoint = WorkItem.Services.Get<ILocalContextService>().ViewPointPosition;
			OCgp_Vec highPointVector = WorkItem.Services.Get<ILocalContextService>().HighPointVector;

			OCgp_Ax2 ax2 = GeomUtils.ExtractAxis(topoShape);

			OCgp_Dir direction;
			if (ax2 != null)
			{
				direction = ax2.Direction();
			}
			else
			{
				direction = new OCgp_Dir(0, 1, 0);
			}
			// Use as projection vector the direction of the plane of the selected shape
			OCPrs3d_Projector aPrs3dProjector = new OCPrs3d_Projector(isPerspective, 1, direction.X(), direction.Y(), direction.Z(),
			                                                          viewPoint.X(), viewPoint.Y(), viewPoint.Z(), highPointVector.X(), highPointVector.Y(), highPointVector.Z());

			// Display the 2D projection shape
			OCAIS2D_ProjShape projShape = new OCAIS2D_ProjShape(aPrs3dProjector.Projector(), 3, false, true);
			projShape.Add(topoShape);
			context2d.Display(projShape, true);
		}

		#region OpenCascade initialization

		/// <summary>
		/// Initializes the OpenCascade views and assigns them View handles.
		/// </summary>
		private void InitializeOpenCascade2D()
		{
			// Initialize the Device
			try
			{
				device2d = new OCWNT_GraphicDevice(false, 0);
				Debug.Assert(device2d != null);
			}
			catch (Exception ex)
			{
				Debug.Assert(false, ex.Message);
				throw;		//re-throw exception
			}

			// Create the 2D viewer
			try
			{
				viewer2d = new OCV2d_Viewer(device2d, "Visu2D", "");
				Debug.Assert(viewer2d != null);
				if (viewer2d != null)
				{
					viewer2d.SetCircularGridValues(0, 0, 10, 8, 0);
					viewer2d.SetRectangularGridValues(0, 0, 10, 10, 0);

					//viewer2d.SetGridColor(new OCQuantity_Color(OCQuantity_NameOfColor.Quantity_NOC_LIGHTSLATEGRAY), new OCQuantity_Color(OCQuantity_NameOfColor.Quantity_NOC_WHITE));
					viewer2d.ActivateGrid(OCAspect_GridType.Aspect_GT_Rectangular, OCAspect_GridDrawMode.Aspect_GDM_Lines);
				}
			}
			catch (Exception ex)
			{
				Debug.Assert(false, ex.Message);
				throw;		//re-throw exception
			}

			// Create the 2D interactive context
			try
			{
				context2d = new OCAIS2D_InteractiveContext(this.viewer2d);
				Debug.Assert(context2d != null);
			}
			catch (Exception ex)
			{
				Debug.Assert(false, ex.Message);
				throw;			// re-throw exception
			}

			// Create the 2D View
			OCWNT_Window aWNTWindow = new OCWNT_Window(device2d, attachedView.GetView().Handle, OCQuantity_NameOfColor.Quantity_NOC_MATRAGRAY);
			//int w = 1000, h = 1000;
			//aWNTWindow.Size(w, h);
			if (!aWNTWindow.IsMapped())
			    aWNTWindow.Map();

			OCWNT_WDriver aDriver = new OCWNT_WDriver(aWNTWindow);
			view2d = new OCV2d_View(aDriver, viewer2d, 0, 0, 200);
			// Reset the mapping
			view2d.Reset();
			view2d.Update();
		}

		#endregion

		///
		/// Commands
		/// 
		[CommandHandler(Constants.CommandNames.SketcherFitAll)]
		public void SketcherFitAllHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_FitAll, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherZoomWindow)]
		public void SketcherZoomWindowHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_WindowZooming, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherDynamicZooming)]
		public void SketcherDynamicZoomingHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_DynamicZooming, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherDynamicPanning)]
		public void SketcherDynamicPanningHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_DynamicPanning, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherGlobalPanning)]
		public void GlobalPanningHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_GlobalPanning, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherGridLines)]
		public void SketcherGridLinesHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_GridLinesHandler, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherGridPoints)]
		public void SketcherGridPointsHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_GridPointsHandler, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherCircularGrid)]
		public void SketcherCircularGridHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_CircularGridHandler, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherCircularGridPoints)]
		public void SketcherCircularGridPointsHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_CircularGridPointsHandler, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherEditGrid)]
		public void SketcherEditGridHandler(object sender, EventArgs e)
		{
			// Edit grid code
		}

		[CommandHandler(Constants.CommandNames.SketcherEraseGrid)]
		public void SketcherEraseGridHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_DeactivateGrid, sender);
		}
		
		[CommandHandler(Constants.CommandNames.SketcherDrawRectangle)]
		public void DrawRectangleHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_DrawRectangle, sender);
		}
		
		[CommandHandler(Constants.CommandNames.SketcherDrawLine)]
		public void DrawLineHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_DrawLine, sender);
		}

		[CommandHandler(Constants.CommandNames.SketcherDrawCircle)]
		public void DrawCircleHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_DrawCircle, sender);
		}

		[CommandHandler(Constants.CommandNames.Cursor)]
		public void CursorHandler(object sender, EventArgs e)
		{
			SwitchActionType(ActionType.Action2d_Nothing, sender);
		}

		//
		// Events
		//
		
		/// <summary>
		/// Called by the attached view when it needs repainting
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		[EventSubscription(Constants.EventTopicNames.SketcherRepaintView, ThreadOption.UserInterface)]
		public void SketcherRepaintView(object sender, PaintEventArgs e)
		{
			// Update the view
			view2d.MustBeResized(OCV2d_TypeOfWindowResizingEffect.V2d_TOWRE_ENLARGE_SPACE);
			view2d.Reset();
			view2d.Update();
		}

		[EventSubscription(Constants.EventTopicNames.SketcherMouseDownEvent, ThreadOption.UserInterface)]
		public void MouseDownHandler(object sender, MouseEventArgs e)
		{
			_yMin = e.Y;
			_xMin = e.X;

			if(e.Button != MouseButtons.Left)
			{
				return;
			}

			_xMax = e.X;
			_yMax = e.Y;

			_currentAction.MouseDownHandler(sender, e);
			if (e.Button == MouseButtons.Left)
			{
				mouseInput.MouseDown(e.X, e.Y);
			}
		}

		[EventSubscription(Constants.EventTopicNames.SketcherMouseUpEvent, ThreadOption.UserInterface)]
		public void MouseUpHandler(object sender, MouseEventArgs e)
		{
			if(e.Button != MouseButtons.Left)
			{
				return;
			}

			_currentAction.MouseUpHandler(sender, e);
			if (e.Button == MouseButtons.Left)
			{
				mouseInput.MouseUp(e.X, e.Y);
			}
		}

		[EventSubscription(Constants.EventTopicNames.SketcherMouseMoveEvent, ThreadOption.UserInterface)]
		public void MouseMoveHandler(object sender, MouseEventArgs e)
		{
			// Mouse shortcuts
			switch (e.Button)
			{
				case MouseButtons.Left:
					break;
				case MouseButtons.Right:
					view2d.Pan(e.X - _xMin, _yMin - e.Y);
					break;
				case MouseButtons.Middle:
					view2d.Zoom(_xMin, _yMin, e.X, e.Y, 0.005);
					break;
			}

			_currentAction.MouseMoveHandler(sender, e);
			mouseInput.MouseMove(e.X, e.Y, (e.Button != MouseButtons.None));

			_xMin = e.X;
			_yMin = e.Y;
		}

        /// <summary>
        /// The Controller is notified about key down events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [EventSubscription(Constants.EventTopicNames.KeyDownEvent, ThreadOption.UserInterface)]
        public void KeyDownHandler(object sender, KeyEventArgs e)
        {
            // On Esc cancel the current action and switch to None
            if (e.KeyCode == Keys.Escape)
            {
                SwitchActionType(ActionType.Action2d_Nothing, this);
            }
            else
            {
                _currentAction.KeyDownHandler(sender, e);
            }
        }

        /// <summary>
        /// Called when a pipe wants the controller to change the action.
        /// Ex: the edit detection pipe detects that a shape is selected
        /// and wants to change to edit mode
        /// </summary>
        /// <param name="actionType"></param>
        /// <param name="activate"></param>
        void EditDetectionPipe_ActivateActionHandler(ActionType actionType, bool activate)
        {
            if (activate)
            {
                SwitchActionType(actionType, this);
            }
            else
            {
                // If the pipe wants to deactivate switch back to action none
                SwitchActionType(ActionType.Action2d_Nothing, this);
            }
        }

		public void SwitchActionType(ActionType actionType, object sender)
		{
            // There is no point to change the action with itself
            if (_currentAction == Update2DModifier.CreateModifier(actionType))
            {
                return;
            }

		    // The EditDetectionPipe is enabled only when the action is Action2d_Nothing
            if ((actionType != ActionType.Action2d_Nothing) && (actionType != ActionType.Action2d_EditShape))
            {
                _editDetectionPipe.OnNotification(PipeConstants.DisableDetectionPipe);
            }
            else
            {
                _editDetectionPipe.OnNotification(PipeConstants.EnableDetectionPipe);
            }

		    log.DebugFormat("Switching action to {0}", actionType);
			if (_currentAction != null)
			{
				_currentAction.OnDeactivate();
			}
			_currentAction = Update2DModifier.CreateModifier(actionType);

			_currentAction.Setup(inputFactory);
			_currentAction.OnActivate();
		}
		
		[EventSubscription(Naro.Sketcher.Constants.EventTopicNames.UpdateViewerObjects, ThreadOption.UserInterface)]
		public void OnUpdateViewerObjectsHandler(object sender, EventArgs e)
		{
		}
	}
}
