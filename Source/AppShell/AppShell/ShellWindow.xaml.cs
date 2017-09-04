#region Usings

using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;

using BooCoreScript;
using ErrorReportCommon.Messages;
using log4net;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Interface.Views;
using Naro.PartModeling;
using NaroAppDocumentCore;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using NaroSetup;
using NaroSetup.Pages.Solver;
using NaroSetup.Pages.Welcome;
using NaroUiBuilder;
using NaroUiBuilder.RibbonMapping;
using PartModellingUi.Layout;
using PluginInterface;
using Control = System.Windows.Controls.Control;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using Point = System.Drawing.Point;

#endregion

namespace AppShell
{
    /// <summary>
    ///   Interaction logic for ShellWindow.xaml
    /// </summary>
    public partial class ShellWindow : Window//IRibbonView
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (ShellWindow));

        private readonly AppDocumentsListInput _documentList;
        private readonly ActionsGraph _mainGraph;
        private readonly ViewInfo _viewInfo;
        private UiBuilder _builder;
        private MultiViewWorkItemController _controller;
        private TipsWindow _tipsWindow;

        public ShellWindow()
        {
            InitializeComponent();

            _documentList = new AppDocumentsListInput();
            _viewInfo = new ViewInfo(treeView, _mainGraph) {RibbonInfoArea = RibbonInfoArea};
            _documentList.RegisterMainGraph(_viewInfo, treeView, newpropertygridView, commandLineView, newLayerView,
                                            helpView, booView);
            _mainGraph = _documentList.ActionsGraph;
            treeView.Setup(_mainGraph);
            BuildPluginUi();
            booView.Setup(_mainGraph);
            dockManager.Loaded += ShellWindowLoaded;

            RibbonView.OnRestoreDefaultLayout += RestoreDefaultLayout;

            ShowTipsIfEnabled();
        }

        private ActionsGraph CurrentActionGraph
        {
            get
            {
                return _mainGraph[InputNames.CurrentDocumentInput].GetData(NotificationNames.GetContainer).Get
                    <ActionsGraph>();
            }
        }

        #region IRibbonView Members

        public Control RibbonControl
        {
            get { return RibbonView.ribbonControl; }
        }

        #endregion

        private void RestoreDefaultLayout()
        {
            TryLoadDockingLayout(NaroAppConstantNames.DefaultDockignLayoutFilename);
        }

        private void RibbonWindowLocationChanged(object sender, EventArgs e)
        {
            WindowsXpMaximizeBug();
        }

        private void RibbonWindowStateChanged(object sender, EventArgs e)
        {
            WindowsXpMaximizeBug();
        }

        private void WindowsXpMaximizeBug()
        {
            if (Environment.OSVersion.Version.Major >= 6) return;
            var source = PresentationSource.FromVisual(this);
            if (source == null) return;
            if (source.CompositionTarget == null) return;
            var todevice = source.CompositionTarget.TransformToDevice;
            var workingarea =
                Screen.GetWorkingArea(new Point(Convert.ToInt32(Left*todevice.M11),
                                                Convert.ToInt32(Top*todevice.M22)));
            var heightdips = workingarea.Height*source.CompositionTarget.TransformFromDevice.M22;
            MaxHeight = heightdips + (SystemParameters.ResizeFrameVerticalBorderWidth*2);
        }

        private void RibbonWindowClosing(object sender, CancelEventArgs e)
        {        	
            //MemMapper.DisplayLeaks();
            var directoryName = Path.GetDirectoryName(NaroAppConstantNames.DockLayoutFilename);
            if (directoryName != null)
            {
                Directory.CreateDirectory(directoryName);
                dockManager.SaveLayout(NaroAppConstantNames.DockLayoutFilename);
            }
            if (_tipsWindow != null)
                _tipsWindow.Close();
            e.Cancel = true;
            ApplicationNotificationUtils.Instance.ExitApplication();
        }

        private void WindowsFormHostRedraw(object sender, EventArgs e)
        {
            WindowsXpMaximizeBug();
            //LaunchCommand(EventTopicNames.Redraw);
        }

        private void LaunchCommand(string actionName)
        {
            CurrentActionGraph.SwitchAction(actionName);
        }

        private void FitAll(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing FitAll button");
            LaunchCommand(ModifierNames.FitAll);
        }

        private void DynamicZoomWindow(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ViewDynamicZooming button");
            LaunchCommand(ModifierNames.ViewDynamicZooming);
        }

        private void DynamicPannning(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ViewDynamicPanning button");
            LaunchCommand(ModifierNames.ViewDynamicPanning);
        }

        private void GlobalPannning(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ViewGlobalPanning button");
            LaunchCommand(ModifierNames.ViewGlobalPanning);
        }

        private void DynamicRotation(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing DynamicRotation button");
            LaunchCommand(ModifierNames.DynamicRotation);
        }

        private void Reset(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Reset button");
            LaunchCommand(ModifierNames.Reset);
        }

        public void SetActionGraph()
        {
            var childActionGraph = _documentList.AddNewChildGraph();
            const string title = "NewFile1.naroxml";
            var newView = new PartModelingView(documentsHost, title);
            _controller = new MultiViewWorkItemController();
            _controller.Run(newView.GetMultiView(), childActionGraph, newView, _viewInfo);

            RibbonView.SetActionGraph(childActionGraph);
            AutoLoadPlugins(childActionGraph);
            _builder.BuildUi();

            GetOptionSetup().UpdatedValue += OnOptionsUpdate;
            OnOptionsUpdate();
        }


        private void ShowTipsIfEnabled()
        {
            var optionsSetup = _mainGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            if (!optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle).GetBoolValue(0)) return;
            _tipsWindow = new TipsWindow(_mainGraph);
            _tipsWindow.Show();
            _tipsWindow.Topmost = true;
            _tipsWindow.Focus();
        }

        private static void AutoLoadPlugins(ActionsGraph childActionGraph)
        {
            var listPluginFiles = PluginUtil.AutoLoadPlugins();
            foreach (var pluginFile in listPluginFiles)
            {
                if (!pluginFile.Value) continue;
                var pluginLoader = new BooPluginLoader(childActionGraph);
                var result = pluginLoader.RegisterPlugin(pluginFile.Key, true);
                if (!result)
                    NaroMessage.Show("Cannot load plugin: " + pluginFile.Key);
            }
        }


        private void BuildPluginUi()
        {
            var ribbonView = RibbonView.ribbonControl;
            _builder =
                _mainGraph.InputContainer[InputNames.UiBuilderInput].GetData(NotificationNames.GetValue).Get<UiBuilder>();
            _builder.Factory.RegisterPath("Ribbon", new RibbonConcretePathFactory(ribbonView));
        }

        private void WindowsFormsHostKeyDown(object sender, KeyEventArgs e)
        {
            _controller.KeyDownHandler(e);
        }

        private void WindowsFormsHostKeyUp(object sender, KeyEventArgs e)
        {
            _controller.KeyUpHandler(e);
        }

        private void ShellWindowLoaded(object sender, EventArgs eventArgs)
        {
            TryLoadDockingLayout(NaroAppConstantNames.DockLayoutFilename);
        }

        private void TryLoadDockingLayout(string layoutFile)
        {
            try
            {
                if (File.Exists(layoutFile))
                    dockManager.RestoreLayout(layoutFile);
            }
            catch
            {
                Log.Info("Exception on restoring layout");
            }
        }

        private void SolverPointClick(object sender, ExecutedRoutedEventArgs e)
        {
            UpdateSolverOptionItem((int) HinterOptionFields.PointMatch, SolverPoint);
        }

        private void UpdateSolverOptionItem(int positionToSet, ToggleButton toggleButton)
        {
            var optionsSetup = GetOptionSetup();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            optionsSetup.Document.Transact();
            optionsSection.SetValue(positionToSet, toggleButton.IsChecked ?? false);
            optionsSetup.Document.Commit("Changed Solver Option");
        }

        private OptionsSetup GetOptionSetup()
        {
            var optionsSetup = CurrentActionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            return optionsSetup;
        }

        private void SolverEdgeClick(object sender, ExecutedRoutedEventArgs e)
        {
            UpdateSolverOptionItem((int) HinterOptionFields.EdgeMatch, SolverEdge);
            UpdateSolverOptionItem((int) HinterOptionFields.EdgeContinuationMatch, SolverEdge);
        }

        private void SolverParallelClick(object sender, ExecutedRoutedEventArgs e)
        {
            UpdateSolverOptionItem((int) HinterOptionFields.ParallelMatch, SolverParallel);
        }

        private void SolverPolarClick(object sender, ExecutedRoutedEventArgs e)
        {
            UpdateSolverOptionItem((int) HinterOptionFields.PolarMatch, SolverPolar);
        }


        private void OnOptionsUpdate()
        {
            var optionsSetup = GetOptionSetup();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);

            SolverPoint.IsChecked = optionsSection.GetBoolValue((int) HinterOptionFields.PointMatch);
            SolverEdge.IsChecked = optionsSection.GetBoolValue((int) HinterOptionFields.EdgeMatch);
            SolverParallel.IsChecked = optionsSection.GetBoolValue((int) HinterOptionFields.ParallelMatch);
            SolverPolar.IsChecked = optionsSection.GetBoolValue((int) HinterOptionFields.PolarMatch);
        }
    }
}