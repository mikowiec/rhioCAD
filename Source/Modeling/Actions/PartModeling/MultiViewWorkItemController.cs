#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using BooEvaluator.Boo;
using ErrorReportCommon.Messages;
using NaroCppCore.Occ.Quantity;
using log4net;
using MetaActionsInterface;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Interface.Views;
using Naro.Infrastructure.Interface.Views.Timers;
using Naro.Infrastructure.Library.Capabilities;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroCAD.SolverModule;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.V3d;
using NaroPipes.Actions;
using NaroPipes.Constants;
using NaroSetup;
using NaroSetup.Pages.AutoSave;
using NaroSketchAdapter;
using NaroSketchAdapter.Common;
using OccCode;

using PartModellingLogic;
using PartModellingLogic.Inputs;
using PartModellingLogic.Inputs.Naro.Pipes;
using PartModellingLogic.Modifiers.CommandLine;
using PartModellingLogic.Modifiers.Infrastructure;
using PartModellingUi.Layout;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Interpreters.Layers;
using ShapeFunctionsInterface.Utils;
using SketchActions;
using TreeData.AttributeInterpreter;
using TreeData.Capabilities;
using TreeData.NaroData;
using TreeData.NaroDataViewer;
using WpfPropertyGrid.Layers;
using WpfPropertyGrid.UI;
using TreeData.Utils;

#endregion

namespace Naro.PartModeling
{
    public partial class MultiViewWorkItemController
    {
        private const string InitialScreenUpdateTimer = "InitialScreenUpdateTimer";
        private static readonly ILog Log = LogManager.GetLogger(typeof(MultiViewWorkItemController));

        #region Local Variables

        #region View Variables

        private V3dView _view;
        private IOccContainerMultiView _attachedView;
        private CommandLineView _commandLineView;
        private AISInteractiveContext _context;

        private bool _controlDown;
        private Graphic3dWNTGraphicDevice _device;
        private IHelpView _helpView;
        private ImageBitmapCache _imageCache;
        private bool _shiftDown;
        private ITreeViewControl _treeView;
        private V3dViewer _viewer;
        private PropertyGridView _wpfPropertyView;
        private double _zoomRatio;

        #endregion

        #region Controller Variables

        private ActionsGraph _actionGraph;
        private DefaultShapeConcepts _defaultShapeConcepts;

        private CommandList _metaModifierContainer;
        private MouseEventsInput _mouseInput;

        private Solver _solver;
        private ViewInfo _viewInfo;

        #endregion

        #region Model Variables

        private Node _currentLabel;
        private Document _document;
        private Node _lastLabelAdded;

        #endregion

        #endregion

        private readonly SortedDictionary<string, string> _shapesActionMapping = new SortedDictionary<string, string>();
        private ActionBase _currentAction;
        private AISInteractiveObject _lastHighlightedinteractiveObject;
        private Node _lastSelectedNode;
        private NodeSelectInput _nodeSelectInput;
        private LayerView _wpfLayerView;

        #region RegisterModifiers

        private void RegisterModifiers()
        {
            DefaultModifiers.Setup(_actionGraph.ModifierContainer);
            RegisterSketchActions.Register(_actionGraph.ModifierContainer);
            DefaultMetaModifiers.Setup(_metaModifierContainer);
        }

        #endregion

        public void Run(IOccContainerMultiView sceneWorkspace, ActionsGraph actionsGraph, PartModelingView newView,
                        ViewInfo viewInfo)
        {
            _attachedView = sceneWorkspace;
            _actionGraph = actionsGraph;
            var uiItems =
                _actionGraph[InputNames.UiElementsItem].GetData(NotificationNames.GetValue).Get
                    <UiElementsItem.Items>();
            _treeView = uiItems.TreeView;
            _wpfPropertyView = (PropertyGridView)uiItems.WpfPropertyView;
            _wpfLayerView = (LayerView)uiItems.LayerView;
            _helpView = uiItems.HelpView;
            _commandLineView =
                _actionGraph[InputNames.CommandLineView].GetData(NotificationNames.GetValue).Get
                    <CommandLineView>();
            _metaModifierContainer = new CommandList(_actionGraph);

            _actionGraph.OnSwitchAction += UpdateSwitchAction;

            Application.DoEvents();
            _actionGraph.Register(new FunctionFactoryInput());
            DefaultFunctions.Setup(_actionGraph);
            var defaultConstraintFunctions = new DefaultConstraintFunctions();
            defaultConstraintFunctions.Setup(_actionGraph);

            OccInitialize.Setup(ref _device, ref _viewer, ref _context, out _view, _attachedView);

            InitDocument();

            _solver = new Solver(_document);
            UpdateSolverOptions();
            ViewInfoSetup(viewInfo);
            RegisterModifiers();
            InitializeInputs();
            DefineShapeConcepts();
            SetupChangedShapeEvent();
            ViewInfoPostSetup();
            UserInterfaceSetup();

            SwitchUserAction(ModifierNames.StartUp);
            var optionsSetup = actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            optionsSetup.Register(new AutoSaveOptionsItem());

            var occSection = optionsSetup.UpdateSectionNode(OptionSectionNames.Background);
            var color = occSection.GetColorValue(0);
            _viewer.SetDefaultBackgroundColor((ShapeUtils.GetOccColor(color)));
            //SetGradientBackground();


            ForceStartupViewUpdate();

            OptionsEventMapping(optionsSetup);

            var presenter = newView.GetPresenter();
            presenter.OnMouseMoveHandler += MouseMoveHandler;
            presenter.OnMouseDownHandler += MouseDownHandler;
            presenter.OnMouseUpHandler += MouseUpHandler;
            presenter.OnMouseWheelHandler += MouseWheelHandler;

            presenter.OnResizeEvent += ResizeView;

            ApplicationNotificationUtils.Instance.ExitingApplication += () => SwitchUserAction(ModifierNames.NaroExit);

            _view.SurfaceDetail = V3dTypeOfSurfaceDetail.V3d_TEX_ALL;
            new SketchSolveUpdater(_document);


            SetOriginalGradientBackground();

            ResumeRunning();
        }

        private void OptionsEventMapping(OptionsSetup optionsSetup)
        {
            optionsSetup.UpdatedValue += UpdateSolverOptions;
            optionsSetup.UpdatedValue += UpdateOccOptions;
            optionsSetup.UpdatedValue += UpdateTreeOptions;
            optionsSetup.UpdatedValue += UpdateZoomOptions;

            optionsSetup.Refresh();
        }

        private void DefineShapeConcepts()
        {
            var capabilitiesInput = _actionGraph[InputNames.GlobalCapabilitiesInput];
            var globalCapabilites = capabilitiesInput.GetData(NotificationNames.GetValue).Get
                <CapabilitiesCollection>();
            _defaultShapeConcepts = new DefaultShapeConcepts(globalCapabilites);
        }

        private void SetOriginalGradientBackground()
        {
            var backgroundFileName = NaroAppConstantNames.InstallDirectory + @"\background.bmp";
            Ensure.IsTrue(File.Exists(backgroundFileName));
            _view.SetBackgroundImage(backgroundFileName, AspectFillMethod.Aspect_FM_STRETCH, true);
        }

        private void SetNewGradientBackground()
        {
            var backgroundFileName = NaroAppConstantNames.InstallDirectory + @"\background2.bmp";
            Ensure.IsTrue(File.Exists(backgroundFileName));
            _view.SetBackgroundImage(backgroundFileName, AspectFillMethod.Aspect_FM_STRETCH, true);
            _view.MustBeResized();
        }

        private void UpdateZoomOptions()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.Background);
            _zoomRatio = optionsSection.GetDoubleValue(3);
            if (Math.Abs(_zoomRatio) < 0.0001)
                _zoomRatio = 0.1;
        }

        /// <summary>
        ///   This call is to remove initial update control issues
        /// </summary>
        private void ForceStartupViewUpdate()
        {
            TimerTaskManager.Instance.AddTask(InitialScreenUpdateTimer, UpdateScreen);
            TimerTaskManager.Instance.StartTimer(InitialScreenUpdateTimer, 1500);
        }

        private void UpdateScreen(object sender, EventArgs eventArgs)
        {
            _actionGraph.InputContainer[InputNames.View].Send(NotificationNames.RefreshView);
            _view.MustBeResized();
            SetOriginalGradientBackground();
            TimerTaskManager.Instance.StopTask(InitialScreenUpdateTimer);
        }

        private void UpdateSwitchAction()
        {
            // Display also the interactive help);
            _currentAction = _actionGraph.CurrentAction;
            if (_helpView == null) return;
            _helpView.ShowHelp(_currentAction.Name);
        }

        private void InitializeInputs()
        {
            _viewInfo.Context = _context;
            var defaultInputs = new DefaultInputs(_actionGraph);
            defaultInputs.InitializeInputs(_viewInfo,
                                           _attachedView.GetActiveView(),
                                           _solver,
                                           _metaModifierContainer);
            _mouseInput = GetInput<MouseEventsInput>(InputNames.MouseEventsInput);
            GetInput<Mouse3DEventsPipe>(InputNames.Mouse3DEventsPipe);
            _nodeSelectInput = GetInput<NodeSelectInput>(InputNames.NodeSelect);
            GetInput<FacePickerPipe>(InputNames.FacePickerPlane);
            _actionGraph.Register(new CommandParser(_metaModifierContainer));
        }

        private T GetInput<T>(string inputName) where T : InputBase
        {
            return (T)_actionGraph.InputContainer[inputName];
        }

        private void UpdateTreeOptions()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var welcomeSection = optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle);
            var evalBoo = welcomeSection.GetBoolValue(3);
            BooEval.IsInterpreted = evalBoo;
            if (CoreGlobalPreferencesSingleton.Instance.ShowTreeIcons == welcomeSection.GetBoolValue(2)) return;
            SwitchUserAction(ModifierNames.None);
            CoreGlobalPreferencesSingleton.Instance.ShowTreeIcons = welcomeSection.GetBoolValue(2);
            _treeView.ClearCache();
            _treeView.LoadTree(_document.Root);
            _treeView.SelectNode(_lastLabelAdded);
        }


        private void UpdateOccOptions()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var occOptions = optionsSetup.UpdateSectionNode(OptionSectionNames.Background);
            _view.SetBackgroundColor(ShapeUtils.GetOccColor(occOptions.GetColorValue(0)));
            if (occOptions.GetBoolValue(2))
                _view.SetAntialiasingOn();
            else
                _view.SetAntialiasingOff();
            var firstColor = occOptions.GetColorValue(4);
            var secondColor = occOptions.GetColorValue(5);
            GeomUtils.MakeGradient("background2.bmp", 32, 128, firstColor, secondColor);
            //SetNewGradientBackground();
            _viewer.Redraw();
        }

        private void UserInterfaceSetup()
        {
            _attachedView.GetActiveView().Cursor = Cursors.IBeam;

            //_helpView = WorkItem.Services.Get<IContextService>().HelpWindow;
            if (_commandLineView == null)
                throw new ArgumentException("Command line control should exist");
            _commandLineView.OnTextEnter += HandleChangeCommand;
            _commandLineView.OnTextChanged += HandleRealTimeText;

            _imageCache = new ImageBitmapCache();
            _treeView.SetShapesCapabilities(_defaultShapeConcepts.Capabilities);
            _attachedView.ContextManager.ImageBitmapCache = _imageCache;
            // Add a listener to the SelectedLabel event sfrom the ITreeView
            _treeView.SelectedLabel += TreeViewSelectedLabel;

            // Add a listener to the MouseLeave event
            _treeView.MouseLeaveTree += MouseLeaveTree;
        }

        private void HandleRealTimeText(string text)
        {
            if (text.Length == 0)
                return;
            if (text.IndexOfAny(new[]
                                    {
                                        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.',
                                        '-'
                                    }) > -1)
                return;
            _commandLineView.SetHintText(text);
            var parser = (CommandParser)_actionGraph.InputContainer[InputNames.CommandParser];
            parser.UpdateCommandLine(text);
        }

        private void HandleChangeCommand(string text)
        {
            var parser = (CommandParser)_actionGraph.InputContainer[InputNames.CommandParser];
            if (!parser.HasCommand(text))
                return;
            parser.HandleChangeCommand(text);
        }

        private void SetupChangedShapeEvent()
        {
            var noneAction = _actionGraph.ModifierContainer.Get(ModifierNames.None) as None;
            if (noneAction == null)
                throw new Exception("Action None shoud exist");
            noneAction.OnChangedShapeClick +=
                delegate(Node node)
                {
                    var functionName = String.Empty;
                    if (node != null)
                        functionName = FunctionUtils.GetFunctionName(node);
                    _attachedView.ContextManager.BuildShapeContext(functionName);
                    _lastSelectedNode = node;
                };
            _attachedView.ContextManager.OnClick += ContextualOnClick;

            _shapesActionMapping[FunctionNames.Circle] = ModifierNames.DrawCircle;
            _shapesActionMapping[FunctionNames.Rectangle] = ModifierNames.RectangleTwoPoints;
            _shapesActionMapping[FunctionNames.Extrude] = ModifierNames.Extrude;
        }

        private void ContextualOnClick(string shape)
        {
            string metaActionName;
            if (!_shapesActionMapping.TryGetValue(shape, out metaActionName))
            {
                NaroMessage.Show(@"Shape_mapping_not_found " + shape);
                return;
            }
            var activeNode = _lastSelectedNode;
            SwitchUserAction(metaActionName);

            if (activeNode == null) return;
        }

        /// <summary>
        ///   Called when the user selects a label in the object tree view.
        /// </summary>
        /// <param name = "label"></param>
        private void TreeViewSelectedLabel(Node label)
        {
            // Store the current selected level
            _currentLabel = label;

            if (label == null)
                return;
            TreeViewHoverLabel(label);
           
            // Display the shape properties in the property grid, even if it is not a visible element
            _wpfPropertyView.OnSelectNode(label);
            _nodeSelectInput.OnSelect(label);

            _view.Update();
        }


        /// <summary>
        ///   Called when the user moves the mouse over an item from the object tree view.
        /// </summary>
        /// <param name = "label"></param>
        private void TreeViewHoverLabel(Node label)
        {
            var interpreter = label.Get<NamedShapeInterpreter>();
            if (interpreter != null)
            {
                var interactiveObject = interpreter.Interactive;
                if (interactiveObject == null) return;
                var status = _context.DisplayStatus(interactiveObject);
                if (status != AISDisplayStatus.AIS_DS_Displayed) return;
                _context.SetSelected(interactiveObject, true);
                _lastHighlightedinteractiveObject = interactiveObject;
            }
            else
            {
                if (_lastHighlightedinteractiveObject == null) return;
                _context.SetSelected(_lastHighlightedinteractiveObject, true);
                _lastHighlightedinteractiveObject = null;
            }
        }

        /// <summary>
        ///   Called when the mouse leaves the tree.
        /// </summary>
        /// <param name = "label"></param>
        private void MouseLeaveTree(Node label)
        {
            // Set the _currentLabel as the selected label
            TreeViewSelectedLabel(_currentLabel ?? label);
        }

        private void ResumeRunning()
        {
            // Draw a trihedron to show planes
            ShowTrihedron();
            CenterDrawingArea();


            for (var i = 0; i < _attachedView.VisibleViewCount; i++)
            {
                _view.Redraw();
                _view.MustBeResized();
            }

            // Reload the Ocaf tree list
            LoadOcafTreeList();
        }

        private void CenterDrawingArea()
        {
            var activeView = _view;
            activeView.Zoom(0, 0, 1400, 1400);
        }

        private void ShowTrihedron()
        {
            _view.TriedronErase();

            // Build an XYZ axis trihedron and add it to Ocaf
            var coords = gp.XOY;
            coords.Location =new gpPnt(0, 0, 0);
            var axis = new GeomAxis2Placement(coords);
            //var trihedron = new AISTrihedron(axis);
            //trihedron.SetSize(15);
            //var aisDrawer = trihedron.Attributes();
            //var datumAspect = aisDrawer.DatumAspect();
            //var firstAxisAspect = datumAspect.FirstAxisAspect();
            //firstAxisAspect.SetColor(new QuantityColor(QuantityNameOfColor.Quantity_NOC_RED));
            //firstAxisAspect.SetWidth(2);
            //var secondAxisAspect = datumAspect.SecondAxisAspect();
            //secondAxisAspect.SetColor(new QuantityColor(QuantityNameOfColor.Quantity_NOC_GREEN));
            //secondAxisAspect.SetWidth(2);
            //var thirdAxisAspect = datumAspect.ThirdAxisAspect();
            //thirdAxisAspect.SetColor(new QuantityColor(QuantityNameOfColor.Quantity_NOC_BLUE1));
            //thirdAxisAspect.SetWidth(2);
            //trihedron.UnsetSelectionMode();

            //_context.Display(trihedron, false);

            var trihedron = new CustomTrihedron(axis, _context);
            trihedron.SetAxisLength(5);
            trihedron.Show();
        }

        private void LoadOcafTreeList()
        {
            _treeView.LoadTree(_document.Root);
        }

        #region Ocaf initialization

        private void InitDocument()
        {
            AttributeInterpreterFactory.Register<ActionGraphInterpreter>();
            // Create a new document
            _document = new Document();
            // Set the name of the label root
            _document.Root.Set<StringInterpreter>().Value = "New Part";

            _document.Root.Set<LayerContainerInterpreter>();
            _document.Root.Set<NaroVersionFileFormatInterpreter>();

            _document.Root.Set<ActionGraphInterpreter>().ActionsGraph = _actionGraph;
            _document.Root.Set<DocumentContextInterpreter>().Context = _context;
            _document.Root.Set<DocumentContextInterpreter>().Document = _document;

            _document.Changed += OnCommit;
        }

        private void ViewInfoSetup(ViewInfo viewInfo)
        {
            _viewInfo = new ViewInfo(_treeView, _actionGraph)
            {
                Viewer = _viewer,
                View = _view,
                Document = _document,
                RibbonInfoArea = viewInfo.RibbonInfoArea
            };
        }

        private void ViewInfoPostSetup()
        {
            _wpfPropertyView.UpdateViewInfo(_viewInfo);
            _wpfLayerView.UpdateViewInfo(_viewInfo);

            _actionGraph.InputContainer[InputNames.EditingToolsInput].Send(NotificationNames.UpdateViewInfo, _viewInfo);
        }

        private void OnCommit()
        {
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var autoSaveSection = optionsSetup.UpdateSectionNode(OptionSectionNames.AutoSavePageTitle);
            if (autoSaveSection.GetBoolValue(0) == false)
                _document.DumpToXml(NaroAppConstantNames.AutoSaveFileName);
        }

        #endregion

        #region InitializeInputs

        #endregion
    }
}