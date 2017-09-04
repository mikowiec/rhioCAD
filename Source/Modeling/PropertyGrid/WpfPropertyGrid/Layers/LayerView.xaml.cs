#region Usings

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using log4net;
using Naro.Infrastructure.Interface;
using PropertyDescriptorsInterface;
using ShapeFunctionsInterface.Interpreters.Layers;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace WpfPropertyGrid.Layers
{
    /// <summary>
    ///   Interaction logic for LayerView.xaml
    /// </summary>
    public partial class LayerView : ILayerView
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (LayerView));

        private readonly List<LayerVisualDescription> _layers;
        private ViewInfo _viewInfo;

        public LayerView()
        {
            InitializeComponent();
            _layers = new List<LayerVisualDescription>();
        }

        #region ILayerView Members

        public void Refresh()
        {
            BuildLayerList();
            UpdateRemoveBtnEnablement();
            UpdateLayerRadio();
        }

        #endregion

        public void UpdateViewInfo(ViewInfo viewInfo)
        {
            _viewInfo = viewInfo;
            Refresh();
        }

        private void BuildLayerList()
        {
            _layers.Clear();
            _listBox.Items.Clear();
            var interpreter = ExtractLayerContainer();
            var count = interpreter.LayerNames.Count;
            for (var i = 0; i < count; i++)
                AddVisualLayer(i);
        }

        private LayerContainerInterpreter ExtractLayerContainer()
        {
            var document = _viewInfo.Document;
            return document.Root.Set<LayerContainerInterpreter>();
        }

        private void UpdateRemoveBtnEnablement()
        {
            var toRemove = GetItemsToRemove();
            if (toRemove.Count == 0)
            {
                _removeBtn.IsEnabled = false;

                return;
            }
            var isChecked = toRemove[0].RadioBtn.IsChecked ?? false;
            _removeBtn.IsEnabled = !isChecked;
        }

        private void UpdateLayerRadio()
        {
            var container = ExtractLayerContainer();
            Ensure.IsTrue(_layers.Count > container.CurrentLayer, "Current layer should have valid index");

            _layers[container.CurrentLayer].RadioBtn.IsEnabled = true;
        }

        private void AddVisualLayer(int index)
        {
            var layerDesc = new LayerVisualDescription(_viewInfo, index, this);
            layerDesc.AddToListBox();
            _listBox.Items.Insert(0, layerDesc.Item);
            _removeBtn.IsEnabled = true;
            _layers.Add(layerDesc);
            UpdateRemoveBtnEnablement();
        }

        public void UpdateCurrentLayer(int index)
        {
            var container = ExtractLayerContainer();
            BeginUpdate();
            Log.Info("After selecting or changing visibility of Layer: " + container.LayerNames[index]);
            container.CurrentLayer = index;
            EndUpdate();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Add New Layer button");
            var container = ExtractLayerContainer();
            var form = new AddLayerWindow(container, false);
            var result = form.ShowDialog() ?? false;
            if (!result) return;
            BeginUpdate();
            container.AddLayer(form.LayerName, ShapeUtils.FromWpfColor(form.LayerColor));
            EndUpdate();
        }

        private void RemoveButtonClick(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Remove Layer button");
            var toRemove = GetItemsToRemove();
            Ensure.AreEqual(1, toRemove.Count);
            var index = toRemove[0].Index;
            var container = ExtractLayerContainer();
            BeginUpdate();
            container.RemoveLayer(index, _viewInfo.Document);
            EndUpdate();
        }

        private void EndUpdate()
        {
            _viewInfo.EndVisualUpdate("Layer layout changed");
            Refresh();
        }

        private void BeginUpdate()
        {
            _viewInfo.BeginUpdate();
        }

        private void RevertUpdate()
        {
            _viewInfo.Document.Revert();
            Refresh();
        }

        private List<LayerVisualDescription> GetItemsToRemove()
        {
            return _layers.Where(layer => layer.Item.IsSelected).ToList();
        }

        private void ListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateRemoveBtnEnablement();
        }

        private void ListBoxMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Log.Info("After pressing 2 click on a layer");
            var item = _listBox.SelectedItem;
            var result = _layers.FirstOrDefault(layer => layer.Item == item);
            if (result == null)
                return;
            var contaienr = ExtractLayerContainer();
            var form = new AddLayerWindow(contaienr, true);
            BeginUpdate();
            form.UpdateLayerDescription(contaienr, result.Index);
            var dialogResult = form.ShowDialog() ?? false;
            if (!dialogResult)
            {
                RevertUpdate();
                return;
            }
            EndUpdate();
        }


        private void OnShowLayerColorChecked(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing show layer color checkbox");
            BeginUpdate();
            var container = ExtractLayerContainer();
            container.UseLayerColors = _layerColorChecked.IsChecked ?? false;
            EndUpdate();
        }
    }
}