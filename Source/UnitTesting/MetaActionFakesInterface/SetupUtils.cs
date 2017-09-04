#region Usings

using MetaActionFakesInterface.MockInputs;
using MetaActionFakesInterface.Stubs;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.Views;
using Naro.Infrastructure.Library.GeomHelpers;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroCAD.SolverModule;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.V3d;
using NaroPipes.Actions;
using NaroSetup;
using NaroSketchAdapter;
using NaroSketchAdapter.Rules;
using PartModellingLogic;
using PartModellingLogic.Inputs.Naro.Factories;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingLogic.Inputs.Naro.Pipes;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;
using NaroCppCore.Occ.Precision;

#endregion

namespace MetaActionFakesInterface
{
    public class SetupUtils
    {
        #region Members

        private static readonly gpPnt OriginCoordinate = new gpPnt(0, 0, 0);
        public V3dView View;
        private CommandList _metaModifierContainer;

        public Document Document;
        public MouseEventsInput MouseInput;
        public V3dViewer Viewer;
        private Document _animationDocument;

        private CoordinateParser _commandParserPipe;
        private AISInteractiveContext _context;
        private Graphic3dWNTGraphicDevice _device;
        private ModifiersFactory _modifierContainer;
        private DirectCoordinateMouseEventsPipe _mouse3DEventsDPipe;
        private CommandList _commandList;
        public ActionsGraph ActionGraph { get; private set; }
        public IOccContainerMultiView AttachedView { private get; set; }

        #endregion

        #region Test Environment Initialization

        public SetupUtils()
        {
            DefaultInterpreters.Setup();
            AttributeInterpreterFactory.Register<ActionGraphInterpreter>();
          
        }

        public void InitializeModifiersSetup()
        {
            ActionGraph = new ActionsGraph();
            _metaModifierContainer = new CommandList(ActionGraph);
            if (AttachedView == null)
                AttachedView = new MultiViewStub(null);
            InitializeViews();
            InitializeDocument();
            ActionGraph.Register(new FunctionFactoryInput());
            ActionGraph.Register(new OptionsSetupInput());
            ActionGraph.Register(new UiBuilderInputFake());
            DefaultFunctions.Setup(ActionGraph);

            InitializeInputs();
            InitializeActions();
            

            var sketchCreator = new SketchCreator(Document);
            sketchCreator.BuildSketchNode();
        }

        private void InitializeInputs()
        {
            var solver = new Solver(Document) {RuleSet = new RuleSet()};

            var activeViewNo = AttachedView.GetActiveViewNumber();

            MouseInput = new MouseEventsInput();
            _mouse3DEventsDPipe = new DirectCoordinateMouseEventsPipe(View);
            _commandParserPipe = new CoordinateParser();
            _commandList = new CommandList(ActionGraph);

            ActionGraph.Register(_mouse3DEventsDPipe);
            ActionGraph.Register(new ViewInput(View, Viewer, AttachedView.GetActiveView()));
            ActionGraph.Register(MouseInput);
            ActionGraph.Register(new FacePickerMockPipe(_context, View));
            ActionGraph.Register(new DocumentInput(Document));
            ActionGraph.Register(new ContextInput(_context));
            ActionGraph.Register(new CommandLineViewInputStub());
            ActionGraph.Register(new MouseCursorInput(AttachedView.GetActiveView()));
            ActionGraph.Register(new RestrictedPlaneInput());
            ActionGraph.Register(new CommandLinePrePusherInput());
            ActionGraph.Register(new FacePickerVisualFeedbackPipe(_context));
            ActionGraph.Register(new InputBase(InputNames.UiElementsItem));
            ActionGraph.Register(new GeometricSolverPipe(solver, new SolverDrawer(_context)));
            ActionGraph.Register(new NodeSelectInput());
            ActionGraph.Register(_commandParserPipe);
            ActionGraph.Register(new InputBase(InputNames.CommandParser));
            ActionGraph.Register(new DirectSelectionContainerPipe());
            ActionGraph.Register(new InputBase(InputNames.MirrorEntireScenePipe));
            ActionGraph.Register(new CommandListInput(_commandList));
            ActionGraph.Register(new GlobalCapabilitiesInput());
            ActionGraph.Register(new DescriptorsFactoryInput());
            ActionGraph.Register(new FastToolbarMockInput());
        }

        private void InitializeDocument()
        {
            Document = TestUtils.DefaultsSetup(); //new Document();
            Document.Root.Set<StringInterpreter>().Value = "New Part";
            Document.Root.Set<DocumentContextInterpreter>().Context = _context;
            Document.Root.Set<ActionGraphInterpreter>().ActionsGraph = ActionGraph;
            Document.Transact();

            _animationDocument = new Document();
            _animationDocument.Root.Set<StringInterpreter>().Value = "New Part";
            _animationDocument.Root.Set<DocumentContextInterpreter>().Context = _context;
            _animationDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph = ActionGraph;
            _animationDocument.Transact();
        }

        private void InitializeViews()
        {
            OccInitialize.Setup(ref _device, ref Viewer, ref _context, out View, AttachedView);
        }

        private void InitializeActions()
        {
            _modifierContainer = ActionGraph.ModifierContainer;
            DefaultModifiers.Setup(_modifierContainer);
            DefaultMetaModifiers.Setup(_metaModifierContainer);
        }

        #endregion

        #region Helpers

        public void SwitchUserAction(string actionType)
        {
            ActionGraph.SwitchAction(actionType);
        }

        public void SwitchUserMetaAction(string metaActionType)
        {
            SwitchUserAction(metaActionType);
        }

        private void CleanDocumentData()
        {
            InitializeModifiersSetup();
        }

        public void ResetSetupEnvironment()
        {
            //_commandLineAction.OnDeactivate();
            CleanDocumentData();
        }

        #region Interpreter/Dependency helper tests

        /// <summary>
        ///   Check if the Node translation is set to value translation
        /// </summary>
        /// <param name = "node">Node who has a translation to test</param>
        /// <param name = "translation">The translation value that the node should have</param>
        public static bool CheckNodeTranslationAgainst(Node node, Point3D translation)
        {
            var transformation = node.Get<TransformationInterpreter>();
            var translatedOriginPoint = OriginCoordinate.Transformed(transformation.CurrTransform);
            return translatedOriginPoint.IsEqual(translation.GpPnt, Precision.Confusion);
        }

        #endregion

        #endregion
    }
}