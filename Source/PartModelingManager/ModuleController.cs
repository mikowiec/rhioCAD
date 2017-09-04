using Extensions.TreeData.AttributeInterpreter;
using System;
using System.Resources;
using System.Windows.Forms;
using log4net;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.EventBroker;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.WinForms;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Interface.Constants;
using Naro.Infrastructure.Interface.Services;
using Naro.PartModelingManager.Resources;
using OCNaroWrappers;
using TreeData.NaroData;
using Naro.PartModeling.Toolstrips;

namespace Naro.PartModelingManager
{
    public class ModuleController : WorkItemController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ModuleController));

        private ControlledWorkItem<Naro.PartModeling.ModuleController> _partModelingWorkItem;
        private ControlledWorkItem<Naro.Sketcher.ModuleController> _sketcherWorkItem;
        private object _currentWorkItem;
        private object _layout;
        private WorkItem _modulePartModelingWorkItem;
        private WorkItem _moduleSketcherWorkItem;

        public override void Run()
        {
            log.Debug("PartModelingManager.ModuleController.Run");

            AddServices();
            ExtendMenu();
            ExtendToolStrip();
            AddViews();
            PrepareOcaf();

            // Create child WorkItems at the current WorkItem for the Sketcher and the PartModeling
            _modulePartModelingWorkItem = WorkItem.WorkItems.AddNew<WorkItem>(ControllerNames.PartModellingController);
            _moduleSketcherWorkItem = WorkItem.WorkItems.AddNew<WorkItem>(ControllerNames.SketcherController);

            // Create a Layout on the MdiManager from the RootWorkItem, both child WorkItems will use it for display
            ResourceManager resources = new ResourceManager(typeof(ModelingManagerResources));
            WindowSmartPartInfo smartPartInfo = new WindowSmartPartInfo();
            smartPartInfo.Title = "New part";
            smartPartInfo.Icon = (System.Drawing.Icon)resources.GetObject("NaroIcon");

            DeckWorkspace deckWorkspace = new DeckWorkspace();
            WorkItem.Items.Add(deckWorkspace);
            //deckWorkspace.Name = WorkspaceNames.DrawingAreaWorkspace;
            WorkItem.RootWorkItem.Workspaces[WorkspaceNames.LayoutWorkspace].Show(deckWorkspace, smartPartInfo);

            WorkItem.RootWorkItem.Workspaces[WorkspaceNames.LayoutWorkspace].SmartPartActivated += new EventHandler<WorkspaceEventArgs>(ModuleController_SmartPartActivated);
            WorkItem.RootWorkItem.Workspaces[WorkspaceNames.LayoutWorkspace].SmartPartClosing += new EventHandler<WorkspaceCancelEventArgs>(ModuleController_SmartPartClosing);

            // Register on the current WorkItem the TreeViewWorkspace and DrawingAreaWorkspace to point to this layout
            _modulePartModelingWorkItem.Workspaces.Add(deckWorkspace, WorkspaceNames.DrawingAreaWorkspace);
            //_modulePartModelingWorkItem.Workspaces.Add(WorkItem.Workspaces[WorkspaceNames.TreeViewWorkspace], WorkspaceNames.TreeViewWorkspace);
            _moduleSketcherWorkItem.Workspaces.Add(deckWorkspace, WorkspaceNames.DrawingAreaWorkspace);
            //_moduleSketcherWorkItem.Workspaces.Add(WorkItem.Workspaces[WorkspaceNames.TreeViewWorkspace], WorkspaceNames.TreeViewWorkspace);

            // Start the two child WorkItems
            _partModelingWorkItem = _modulePartModelingWorkItem.WorkItems.AddNew<ControlledWorkItem<Naro.PartModeling.ModuleController>>("PartModelingController");
            log.Debug("Part modeling Run");
            _partModelingWorkItem.Controller.Run();
            log.Debug("Sketcher Run");
            _sketcherWorkItem = _moduleSketcherWorkItem.WorkItems.AddNew<ControlledWorkItem<Naro.Sketcher.ModuleController>>("SketcherController");
            _sketcherWorkItem.Controller.Run();

            // Start the flow by activating the 3D modeling WorkItem
            _currentWorkItem = _partModelingWorkItem;
            log.Debug("Part modeling ResumeRunning");
            _partModelingWorkItem.Controller.ResumeRunning();

            // Show the StartSketcher Toolstrip
            //IShellExtensionService extensionService = this.WorkItem.Services.Get<IShellExtensionService>();
            //extensionService.BeginUpdateLayout();
            //extensionService.ShowToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.StartSketcher);
            //extensionService.EndUpdateLayout();
        }

        void ModuleController_SmartPartActivated(object sender, WorkspaceEventArgs e)
        {
            log.Debug("PartModelingManager.ModuleController.ModuleController_SmartPartActivated");
            if (WorkItem.Items.ContainsObject(e.SmartPart))
            {
                log.Debug("Module got focus");
                ModuleGotFocus();
                _layout = e.SmartPart;
            }
            else
            {
                log.Debug("Module lost focus");
                ModuleLostFocus();
            }
        }

        void ModuleController_SmartPartClosing(object sender, WorkspaceCancelEventArgs e)
        {
            log.Debug("PartModelingManager.ModuleController.ModuleController_SmartPartClosing");
            if (_partModelingWorkItem.Status != WorkItemStatus.Terminated)
            {
                log.Debug("Part modeling Terminate");
                _partModelingWorkItem.Terminate();
            }
            if (_sketcherWorkItem.Status != WorkItemStatus.Terminated)
            {
                log.Debug("Sketcher Terminate");
                _sketcherWorkItem.Terminate();
            }
        }

        private void ModuleLostFocus()
        {
            log.Debug("PartModelingManager.ModuleController.ModuleLostFocus");
            //IShellExtensionService extensionService = this.WorkItem.Services.Get<IShellExtensionService>();
            //extensionService.HideToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.StartSketcher);
            //extensionService.HideToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.ExitSketcher);
            //extensionService.HideToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.UndoRedo);

            _partModelingWorkItem.Controller.SuspendRunning();
            _sketcherWorkItem.Controller.SuspendRunning();
        }

        private void ModuleGotFocus()
        {
            log.Debug("PartModelingManager.ModuleController.ModuleGotFocus");
            IShellExtensionService extensionService = this.WorkItem.Services.Get<IShellExtensionService>();
			//extensionService.BeginUpdateLayout();
            if (_currentWorkItem == _partModelingWorkItem)
            {
                //extensionService.ShowToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.StartSketcher);
                log.Debug("Part modeling Resume Running");
                _partModelingWorkItem.Controller.ResumeRunning();
            }
            else if (_currentWorkItem == _sketcherWorkItem)
            {
                //extensionService.ShowToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.ExitSketcher);
                log.Debug("Skecther Resume Running");
                _sketcherWorkItem.Controller.ResumeRunning();
            }

            //extensionService.ShowToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.UndoRedo);
            //extensionService.EndUpdateLayout();
        }

        private void AddServices()
        {
            //TODO: add services provided by the Module. See: Add or AddNew method in 
            //		WorkItem.Services collection or see ms-help://MS.VSCC.v90/MS.VSIPCC.v90/ms.practices.2005Nov.cab/CAB/html/03-020-Adding%20Services.htm
            WorkItem.Services.AddNew<LocalContextService, ILocalContextService>();
        }

        private void ExtendMenu()
        {
            //TODO: add menu items here, normally by calling the "Add" method on
            //		on the WorkItem.UIExtensionSites collection. For an example 
            //		See: ms-help://MS.VSCC.v90/MS.VSIPCC.v90/ms.practices.scsf.2008apr/SCSF/html/02-04-340-Showing_UIElements.htm

            // Add the Sketcher command
            UIExtensionSite insertMenuItem = WorkItem.UIExtensionSites[UIExtensionSiteNames.InsertToolStripMenuItem];
            ToolStripMenuItem sketcher = new ToolStripMenuItem("Sketcher");
            insertMenuItem.Add(sketcher);
            WorkItem.Commands[Constants.CommandNames.StartSketcher].AddInvoker(sketcher, "Click");

        }

        private void ExtendToolStrip()
        {
            //TODO: add new items to the ToolStrip in the Shell. See the UIExtensionSites collection in the WorkItem. 
            //		See: ms-help://MS.VSCC.v90/MS.VSIPCC.v90/ms.practices.scsf.2008apr/SCSF/html/02-04-340-Showing_UIElements.htm
            // Build the toolstrips
            ToolstripForm toolstripForm = new ToolstripForm();

            // Register the toolstrips with the system
            IShellExtensionService extensionService = this.WorkItem.Services.Get<IShellExtensionService>();

            extensionService.AddToolstrip(toolstripForm.SelectionToolstrip, true);
            extensionService.AddToolstrip(toolstripForm.ManipulationToolstrip, true);
            extensionService.AddToolstrip(toolstripForm.ModelingToolstrip, true);
            extensionService.AddToolstrip(toolstripForm.DrawingToolstrip, true);

            // Wire commands
            WorkItem.RootWorkItem.Commands[CommandNames.SelectVertices].AddInvoker(toolstripForm.selectVertices, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.SelectEdges].AddInvoker(toolstripForm.selectEdges, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.SelectFaces].AddInvoker(toolstripForm.selectFaces, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.SelectSolid].AddInvoker(toolstripForm.selectSolid, "Click");

            WorkItem.RootWorkItem.Commands[CommandNames.Cursor].AddInvoker(toolstripForm.cursorButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.FitAll].AddInvoker(toolstripForm.fitAllButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.ZoomWindow].AddInvoker(toolstripForm.zoomWindowButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.DynZooming].AddInvoker(toolstripForm.dynamicZoomingButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.DynPanning].AddInvoker(toolstripForm.dynamicPanningButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.GlobalPanning].AddInvoker(toolstripForm.globalPanningButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Front].AddInvoker(toolstripForm.frontButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Top].AddInvoker(toolstripForm.topButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Left].AddInvoker(toolstripForm.leftButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Back].AddInvoker(toolstripForm.backButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Right].AddInvoker(toolstripForm.rightButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Bottom].AddInvoker(toolstripForm.bottomButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Axo].AddInvoker(toolstripForm.axoButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.DynamicRotation].AddInvoker(toolstripForm.dynamicRotationButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Reset].AddInvoker(toolstripForm.resetButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.HiddenOn].AddInvoker(toolstripForm.hiddenOnButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.HiddenOff].AddInvoker(toolstripForm.hiddenOffButton, "Click");

            WorkItem.RootWorkItem.Commands[CommandNames.Extrude].AddInvoker(toolstripForm.extrudeButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Cut].AddInvoker(toolstripForm.cutButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Fillet].AddInvoker(toolstripForm.filletButton, "Click");

            WorkItem.RootWorkItem.Commands[CommandNames.Draw3DLine].AddInvoker(toolstripForm.lineButton, "Click");
            WorkItem.RootWorkItem.Commands[CommandNames.Draw3DRectangle].AddInvoker(toolstripForm.rectangleButton, "Click");
        }

        private void AddViews()
        {
            //TODO: create the Module views, add them to the WorkItem and show them in 
            //		a Workspace. See: ms-help://MS.VSCC.v90/MS.VSIPCC.v90/ms.practices.scsf.2008apr/SCSF/html/03-01-040-How_to_Add_a_View_with_a_Presenter.htm

            // To create and add a view you can customize the following sentence
            // SampleView view = ShowViewInWorkspace<SampleView>(WorkspaceNames.SampleWorkspace);

        }

        private void PrepareOcaf()
        {
            // Create a new document
            OCTCollection_ExtendedString extStr = new OCTCollection_ExtendedString("XmlOcaf");
            Document ocafDocument = new Document();
            ocafDocument.Title = "XmlOcaf";
            ocafDocument.SetUndoLimit(10);

            // Store the document in the LocalContext
            WorkItem.Services.Get<ILocalContextService>().CurrentOcafDocument = ocafDocument;
            // Store the Root Label in the Local Context
            WorkItem.Services.Get<ILocalContextService>().RootLabel = ocafDocument.Root;
        }

        //TODO: Add CommandHandlers and/or Event Subscriptions
        //		See: ms-help://MS.VSCC.v90/MS.VSIPCC.v90/ms.practices.scsf.2008apr/SCSF/html/02-04-350-Registering_Commands.htm
        //		See: ms-help://MS.VSCC.v90/MS.VSIPCC.v90/ms.practices.scsf.2008apr/SCSF/html/02-04-320-Publishing_and_Subscribing_to_Events.htm

        // Launch the Sketcher command
        [CommandHandler(Constants.CommandNames.StartSketcher)]
        public void LaunchSkecther(object sender, EventArgs e)
        {
            // Show the ExitSketcher toolstrip
            //IShellExtensionService extensionService = this.WorkItem.Services.Get<IShellExtensionService>();
            //extensionService.BeginUpdateLayout();
            //extensionService.HideToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.StartSketcher);
            //extensionService.ShowToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.ExitSketcher);
            //extensionService.EndUpdateLayout();
            
            _currentWorkItem = _sketcherWorkItem;
            _partModelingWorkItem.Controller.SuspendRunning();
            _sketcherWorkItem.Controller.ResumeRunning();
        }

        // Exit from the Sketcher command
        [CommandHandler(Constants.CommandNames.ExitSketcher)]
        public void ExitSkecther(object sender, EventArgs e)
        {
            // Show the StartSketcher toolstrip
            //IShellExtensionService extensionService = this.WorkItem.Services.Get<IShellExtensionService>();
            //extensionService.BeginUpdateLayout();
            //extensionService.ShowToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.StartSketcher);
            //extensionService.HideToolstrip(this.WorkItem, Constants.UIExtensionSiteNames.ExitSketcher);
            //extensionService.EndUpdateLayout();

            _currentWorkItem = _partModelingWorkItem;
            _partModelingWorkItem.Controller.ResumeRunning();
            _sketcherWorkItem.Controller.SuspendRunning();
        }

        // Undo command
        [CommandHandler(Constants.CommandNames.Undo)]
        public void UndoHandler(object sender, EventArgs e)
        {
            Document ocafDocument = WorkItem.Services.Get<ILocalContextService>().CurrentOcafDocument;
            if (ocafDocument != null)
            {
                ocafDocument.Undo();
            }
            ocafDocument.Root.Get<DocumentContextInterpreter>().Viewer.Update();

            // TODO: improve the PublicationScope to be the active child WorkItem
            // Inform the child WorkItems that a data modification took place
            WorkItem.EventTopics[EventTopicNames.UpdateViewerObjects].Fire(this, new EventArgs(), null, PublicationScope.Global);
        }

        // Redo command
        [CommandHandler(Constants.CommandNames.Redo)]
        public void RedoHandler(object sender, EventArgs e)
        {
            Document ocafDocument = WorkItem.Services.Get<ILocalContextService>().CurrentOcafDocument;
            if (ocafDocument != null)
            {
                ocafDocument.Redo();
            }
            ocafDocument.Root.Get<DocumentContextInterpreter>().Viewer.Update();

            // Inform the child WorkItems that a data modification took place
            WorkItem.EventTopics[EventTopicNames.UpdateViewerObjects].Fire(this, new EventArgs(), null, PublicationScope.Global);
        }
    }
}
