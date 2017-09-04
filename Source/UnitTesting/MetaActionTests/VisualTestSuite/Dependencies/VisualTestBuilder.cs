#region Usings

using System;
using System.Windows.Forms;
using MetaActionFakesInterface;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.V3d;
using NaroPipes.Actions;

using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;

#endregion

namespace MetaActionTests.VisualTestSuite.Dependencies
{
    internal class VisualTestBuilder
    {
        public OccVisualForm Form { get; private set; }
        private V3dViewer Viewer { get; set; }
        private V3dView View { get; set; }

        public SetupUtils SetupUtils { get; private set; }

        public void BuildForm(int width, int height)
        {
            var form = new OccVisualForm
                           {
                               Width = width,
                               Height = height
                           };

            var multiview = form.multiviewTableLayoutPanel;
            SetupUtils = new SetupUtils {AttachedView = multiview};
            SetupUtils.InitializeModifiersSetup();
            SetupUtils.ResetSetupEnvironment();

            Viewer = SetupUtils.Viewer;
            View = SetupUtils.View;

            Form = form;
            Form.Paint += FormPaint;
            Form.Resize += FormResize;

            DefaultInterpreters.Setup();
            var actionsGraph = new ActionsGraph();
            actionsGraph.Register(new FunctionFactoryInput());
            DefaultFunctions.Setup(actionsGraph);

            InitializeSetupUtils();
        }

        private void InitializeSetupUtils()
        {
            var actionsGraph = SetupUtils.ActionGraph;
            var viewInput = new ViewInput(View, Viewer, Form);
            actionsGraph.RemoveInput(InputNames.View);
            actionsGraph.Register(viewInput);
        }


        private void FormResize(object sender, EventArgs e)
        {
            View.MustBeResized();
        }

        private void FormPaint(object sender, PaintEventArgs e)
        {
            ViewUpdate();
        }

        public void ViewUpdate()
        {
            View.MustBeResized();
            FitAll();
            Form.Update();
        }

        private void FitAll()
        {
            View.FitAll(0.01, false, true);
            View.ZFitAll(1);
        }
    }
}