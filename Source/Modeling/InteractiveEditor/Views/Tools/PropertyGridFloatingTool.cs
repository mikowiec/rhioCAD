#region Usings

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using InteractiveEditor.Constants;
using InteractiveEditor.Views.FloatingTool;
using NaroBasicPipes.Inputs;
using PropertyDescriptorsInterface;
using ShapeFunctionsInterface.Utils;

#endregion

namespace InteractiveEditor.Views.Tools
{
    internal class PropertyGridFloatingTool : FloatingToolGroupButton
    {
        public PropertyGridFloatingTool()
            : base(FloatingToolNames.PropertyGrid)
        {
            LabelTitle = "Properties";
            ToolTipTitle = "Properties";
            const string baseUrl = @"/Resources;component/Resources/";
            IconImage = baseUrl + "preferences-system.png";
        }

        public override bool AcceptEntity(SelectionContainer entity)
        {
            var node = entity.Entities[0].Node;
            var functionName = FunctionUtils.GetFunctionName(node);
            var descriptor = DescriptorsFactory.Instance.GetFunctionTab(functionName);

            return descriptor != null;
        }

        protected override void PopulateExtendedView(StackPanel panel, SelectionContainer entity)
        {
            var node = entity.Entities[0].Node;
            var functionName = FunctionUtils.GetFunctionName(node);
            var descriptor = DescriptorsFactory.Instance.GetFunctionTab(functionName);
            descriptor.RefreshNode(panel, node, ViewInfo, new List<string>());
            ViewInfo.Document.Changed += OnDocumentChange;

            var gradient = new LinearGradientBrush
                               {
                                   StartPoint = new Point(0, 0),
                                   EndPoint = new Point(0, 1),
                                   GradientStops = new GradientStopCollection
                                                       {
                                                           new GradientStop(Colors.White, 0),
                                                           new GradientStop(Colors.DarkGray, 0.3),
                                                           new GradientStop(Colors.LightBlue, 1)
                                                       }
                               };
            panel.Background = gradient;
        }

        private void OnDocumentChange()
        {
            Popup.IsOpen = false;
        }
    }
}