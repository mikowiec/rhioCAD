#region Usings

using System.Windows.Forms;
using Extensions.NotificationTree;
using MetaActionsInterface;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Library.GeomHelpers;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroCAD.SolverModule;
using NaroPipes.Actions;
using NaroSketchAdapter;
using PartModellingLogic.Inputs.Naro.Factories;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingLogic.Inputs.Naro.Pipes;

#endregion

namespace PartModellingLogic.Inputs
{
    public class DefaultInputs
    {
        public DefaultInputs(ActionsGraph actionsGraph)
        {
            ActionGraph = actionsGraph;
        }

        private ActionsGraph ActionGraph { get; set; }

        public void InitializeInputs(ViewInfo viewInfo,
                                     Control control,
                                     Solver solver,
                                     CommandList commandList)
        {
            ActionGraph.Register(new ViewInput(viewInfo.View, viewInfo.Viewer, control));
            ActionGraph.Register(new DocumentInput(viewInfo.Document));
            ActionGraph.Register(new ContextInput(viewInfo.Context));
            ActionGraph.Register(new NodeSelectInput());
            ActionGraph.Register(new FacePickerPipe());
            ActionGraph.Register(new ViewInfoInput(viewInfo));
            ActionGraph.Register(new View3DRectanglePipe(control));
            ActionGraph.Register(new GeometricSolverPipe(solver, new SolverDrawer(viewInfo.Context)));
            ActionGraph.Register(new FacePickerVisualFeedbackPipe(viewInfo.Context));
            ActionGraph.Register(new CoordinateParser());
            ActionGraph.Register(new FastToolbarInput(viewInfo.RibbonInfoArea));
            ActionGraph.Register(new FileOpenDialogInput());
            ActionGraph.Register(new FileSaveDialogInput());
            ActionGraph.Register(new MouseCursorInput(control));
            ActionGraph.Register(new NotificationTreeInput());
            ActionGraph.Register(new SelectionContextInput());
            ActionGraph.Register(new RestrictedPlaneInput());
            ActionGraph.Register(new ClipboardManager());
            ActionGraph.Register(new CommandLinePrePusherInput());
            ActionGraph.Register(new SelectionContainerPipe());
            ActionGraph.Register(new EditingToolsPipe());
            ActionGraph.Register(new MirrorEntireScenePipe());
            ActionGraph.Register(new CommandListInput(commandList));
            ActionGraph.Register(new MouseEventsInput());
            ActionGraph.Register(new Mouse3DEventsPipe());
        }
    }
}