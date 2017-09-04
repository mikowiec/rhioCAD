#region Usings

using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using log4net;
using Naro.Infrastructure.Library.Actions;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    public partial class SketchButton : ISketchButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");
        private readonly List<FrameworkElement> _featureElements = new List<FrameworkElement>();
        private readonly List<FrameworkElement> _sketchElements = new List<FrameworkElement>();

        private readonly string enterString = "Enter Sketch Mode";
        private readonly string exitString = "Exit Sketch Mode";

        private bool _isBlocked;

        public SketchButton()
        {
            InitializeComponent();
            setLabelTitleName(enterString);
        }

        #region ISketchButton Members

        public void Block()
        {
            setLabelTitleName(exitString);
          //  DisableFeatureElements();
            //EnableSketchElements();
            _isBlocked = true;
        }

        public void Unblock()
        {
            setLabelTitleName(enterString);
          //  EnableFeatureElements();
            //DisableSketchElements();
            _isBlocked = false;
        }

        #endregion

        private void SketchButtonClick(object sender, ExecutedRoutedEventArgs e)
        {
            if (!_isBlocked)
            {
                Log.Info("After pressing Sketch button: sketch started");
                SwitchUserAction(ModifierNames.StartSketch);
            }
            else
            {
                Log.Info("After pressing Sketch button : sketch stopped");
                SwitchUserAction(ModifierNames.EndSketch);
            }
        }

        private void setLabelTitleName(string name)
        {
            command.LabelTitle = name;
        }

        private void EnableSketchElements()
        {
            foreach (var element in _sketchElements)
                element.IsEnabled = true;
        }

        private void DisableSketchElements()
        {
            foreach (var element in _sketchElements)
                element.IsEnabled = false;
        }

        private void EnableFeatureElements()
        {
            foreach (var element in _featureElements)
                element.IsEnabled = true;
        }

        private void DisableFeatureElements()
        {
            foreach (var element in _featureElements)
                element.IsEnabled = false;
        }

        public void SketchUi(FrameworkElement element)
        {
            _sketchElements.Add(element);
        }

        public void FeatureUi(FrameworkElement element)
        {
            _featureElements.Add(element);
        }
    }
}