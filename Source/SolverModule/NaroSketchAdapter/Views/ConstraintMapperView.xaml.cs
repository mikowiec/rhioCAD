#region Usings

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ConstraintsModule.Views;
using Naro.Infrastructure.Library.Geometry;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter.Views
{
    /// <summary>
    ///   Lógica de interacción para ConstraintMapperView.xaml
    /// </summary>
    public partial class ConstraintMapperView
    {
        #region Delegates

        public delegate void SceneChangedEvent();

        #endregion

        private readonly ConstraintDocumentHelper _constraintDocumentHelper;
        private readonly Document _document;
        public SceneChangedEvent OnSceneChanged;

        private bool _enableUndo;
        private List<Node> _nodeList;
        private int _stepsToUndo;
        private Button _undoButton;

        public ConstraintMapperView(ConstraintDocumentHelper constraintDocumentHelper)
        {
            _constraintDocumentHelper = constraintDocumentHelper;
            _document = _constraintDocumentHelper.Document;
            InitializeComponent();
        }

        private bool EnableUndo
        {
            set
            {
                _enableUndo = value;
                UpdateSelection(_nodeList);
            }
        }

        public void UpdateSelection(List<Node> nodeList)
        {
            _nodeList = nodeList;
            var constraintList = _constraintDocumentHelper.GetPossibleConstraints(nodeList);

            _mainStack.Children.Clear();

            RebuildUi(constraintList);
        }

        private void RebuildUi(IEnumerable<string> constraintList)
        {
            if (_enableUndo)
            {
                var undoStackPanel = new StackPanel
                                         {
                                             Orientation = Orientation.Horizontal
                                         };
                _undoButton = new Button
                                  {
                                      Content = undoStackPanel
                                  };
                undoStackPanel.Children.Add(CreateImage("/Resources;component/Resources/edit-undo.png"));
                undoStackPanel.Children.Add(BuildTextBlock("Undo"));
                _undoButton.Click += UndoClicked;
                AddUi(_undoButton);
            }
            if (_nodeList.Count == 0)
            {
                AddUi(BuildTextBlock("No Sketch Shape is selected"));
                return;
            }
            AddUi(BuildTextBlock("Constraints: "));
            var mapper = _constraintDocumentHelper.ConstraintMapper;
            foreach (var constraint in constraintList)
            {
                var descriptor = mapper.GetConstraintDescription(constraint);
                AddConstraintUi(descriptor);
            }
        }

        private void UndoClicked(object sender, RoutedEventArgs e)
        {
            _stepsToUndo--;
            _document.Undo();
            EnableUndo = _stepsToUndo != 0;
            SceneChanged();
        }

        private void SceneChanged()
        {
            if (OnSceneChanged != null)
                OnSceneChanged();
        }

        private void AddConstraintUi(ConstraintDependencyDescription descriptor)
        {
            var itemStack = new StackPanel
                                {
                                    Orientation = Orientation.Horizontal
                                };
            var appliedConstraints = _constraintDocumentHelper.IsApplied(_nodeList, descriptor.FunctionName);
            var button = new CheckBox
                             {
                                 Content = itemStack,
                                 IsChecked = appliedConstraints,
                                 VerticalAlignment = VerticalAlignment.Center
                             };
            var iconPicture = descriptor.IconPicture;
            var image = CreateImage(iconPicture);
            button.Click += ConstraintApplied;
            button.DataContext = descriptor;
            itemStack.Children.Add(image);
            itemStack.Children.Add(BuildTextBlock(descriptor.Descriptor));
            AddUi(button);
        }

        private static Image CreateImage(string iconPicture)
        {
            return new Image
                       {
                           Source = new BitmapImage(new Uri(iconPicture, UriKind.RelativeOrAbsolute)),
                           Width = 16,
                           Height = 16
                       };
        }

        private void ConstraintApplied(object sender, RoutedEventArgs e)
        {
            var button = (CheckBox) sender;
            var descriptor = (ConstraintDependencyDescription) button.DataContext;
            var isChecked = button.IsChecked ?? false;
            _document.Transact();
            var functionName = descriptor.FunctionName;
            if (isChecked)
            {
                var firstPointIndex = NodeUtils.GetFirstPointIndex(_nodeList[0]);
                _constraintDocumentHelper.SetMousePosition(firstPointIndex);
                var res = _constraintDocumentHelper.ApplyConstraint(_nodeList, functionName);
                if (res.Node == null)
                {
                    _constraintDocumentHelper.Remove(_nodeList, functionName);
                    MessageBox.Show("Could not apply constraint!");
                }
                else
                {
                    foreach (var node in _nodeList)
                    {
                        NodeBuilderUtils.AdddHintsForNode(_document, node, res.Node);
                    }
                }
            }
            else
            {
                var appliedConstraints = _constraintDocumentHelper.CheckAppliedConstraints(_nodeList);
                foreach (var constraint in appliedConstraints)
                {
                      NodeBuilderUtils.DeleteConstraintNode(_document, constraint);
                }
            }
            _stepsToUndo++;
            _document.Commit("Applied/Removed constraint: " + descriptor.Descriptor);
            EnableUndo = true;
            SceneChanged();
        }

        private static TextBlock BuildTextBlock(string text)
        {
            return new TextBlock
                       {
                           Margin = new Thickness(2, 2, 2, 2),
                           Text = text,
                           VerticalAlignment = VerticalAlignment.Center
                       };
        }

        private void AddUi(UIElement shapeButton)
        {
            _mainStack.Children.Add(shapeButton);
        }
    }
}