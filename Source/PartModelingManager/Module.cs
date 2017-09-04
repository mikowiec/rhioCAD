using System;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.ObjectBuilder;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Interface.Constants;

namespace Naro.PartModelingManager
{
    public class Module : ModuleInit
    {
        private WorkItem _rootWorkItem;

        [InjectionConstructor]
        public Module([ServiceDependency] WorkItem rootWorkItem)
        {
            _rootWorkItem = rootWorkItem;
        }

        public override void Load()
        {
            base.Load();

            // Register the start PartModelingController command in the main menu

            // Fetch the main menu's extension site
            UIExtensionSite newMenuItem = _rootWorkItem.UIExtensionSites[UIExtensionSiteNames.NewToolStripMenuItem];
            ToolStripMenuItem toolStrip = new ToolStripMenuItem("Part");
            toolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newMenuItem.Add(toolStrip);

            // Add the click command handlers
            _rootWorkItem.Commands[Constants.CommandNames.NewPart].AddInvoker(toolStrip, "Click");
        }

        // Starts a new part modeling use case
        [CommandHandler(Constants.CommandNames.NewPart)]
        public void OnNewPart(object sender, EventArgs e)
        {
            WorkItem newPartWorkItem = _rootWorkItem.WorkItems.AddNew<WorkItem>();
            ControlledWorkItem<ModuleController> controlledWorkItem = newPartWorkItem.WorkItems.AddNew<ControlledWorkItem<ModuleController>>();
            controlledWorkItem.Controller.Run();
        }
    }
}
