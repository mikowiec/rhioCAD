#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Media;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroSketchAdapter.Views;
using OccCode;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters.Layers;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using System.Linq;

#endregion

namespace PropertyGridTabs.AttributeTabs
{
    public class ShapeTab : GridTabBase
    {
        private ColorPropertyTabItem _colorProperty;
        private DropDownPropertyTabItem _layerProperty;
        private StringPropertyTabItem _nameProperty;
        private ListPropertyTabItem _constraintsProperty;
        private AvailableConstraintsTabItem _newConstraintsProperty;
        private DoubleSliderPropertyTabItem _transparencyProperty;

        public ShapeTab()
            : base("Shape")
        {
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _nameProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _colorProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _transparencyProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _layerProperty.SetTabOrder(tabIndex);
        }

        protected override void BuildInterface()
        {
            _nameProperty = new StringPropertyTabItem();
            _nameProperty.OnGetValue += OnGetName;
            _nameProperty.OnSetValue += OnSetName;

            PropertyListGenerator.AddProperty("Name", _nameProperty);


            _transparencyProperty = new DoubleSliderPropertyTabItem(0, 1);
            _transparencyProperty.OnGetValue += OnGetTransparency;
            _transparencyProperty.OnSetValue += OnSetTransparency;

            PropertyListGenerator.AddProperty("Transparency", _transparencyProperty);

            _colorProperty = new ColorPropertyTabItem();
            _colorProperty.OnGetValue += OnGetColor;
            _colorProperty.OnSetValue += OnSetColor;

            PropertyListGenerator.AddProperty("Color", _colorProperty);

            var container = Parent.Root.Set<LayerContainerInterpreter>();
            _layerProperty = new DropDownPropertyTabItem(container.LayerNames);
            _layerProperty.OnGetValue += OnLayerIndexChange;
            _layerProperty.OnSetValue += OnSetLayerIndex;

            PropertyListGenerator.AddProperty("Layer", _layerProperty);

            _constraintsProperty = new ListPropertyTabItem();
            _constraintsProperty.OnGetValue += OnGetConstraints;
            PropertyListGenerator.AddProperty("Constraints", _constraintsProperty);
            _newConstraintsProperty = new AvailableConstraintsTabItem(44);
            _newConstraintsProperty.OnGetValue += OnGetPossibleConstraints;
            PropertyListGenerator.AddProperty("Add Constraints", _newConstraintsProperty);
        }

        private List<string> existingConstraints = new List<string>();

        private void OnGetConstraints(ref object resultValue)
        {
            existingConstraints.Clear();
            var _document = _viewInfo.Document;
            var listConstraints = new List<NodeBuilder>();
            var constraints = (from child in _document.Root.Children where NodeUtils.NodeIsConstraint(child.Key, _document) select child.Value).ToList();
            if (Builder.Node == null)
            {
                foreach (var constraint in constraints)
                {
                    listConstraints.Add(new NodeBuilder(constraint));
                    existingConstraints.Add(constraint.Get<FunctionInterpreter>().Name);
                }
            }
            else
            {
                foreach (var constraint in constraints)
                {
                    if (Document.NodeReferences(constraint, Builder.Node) || NodeUtils.LineHasLengthConstraint(Builder.Node, constraint))
                    {
                        listConstraints.Add(new NodeBuilder(constraint));
                        existingConstraints.Add(constraint.Get<FunctionInterpreter>().Name);
                    }
                }
            }
            resultValue = listConstraints;
        }

        private void OnSetLayerIndex(object data)
        {
            BeginUpdate();
            var newIndex = (int) data;
            Parent.Set<LayerVisibilityInterpreter>().TagIndex = newIndex;
            EndVisualUpdate("Updated Layer Index");
        }

        private void OnLayerIndexChange(ref object data)
        {
            data = Parent.Set<LayerVisibilityInterpreter>().TagIndex;
        }

        private void OnGetName(ref object resultValue)
        {
            resultValue = Parent.Get<StringInterpreter>().Value;
        }

        private void OnSetName(object data)
        {
            var value = (string) data;
            if (value == Parent.Get<StringInterpreter>().Value) return;
            BeginUpdate();
            Parent.Set<StringInterpreter>().Value = value;
            EndUpdate("Update name to: " + value);
        }

        private void OnGetTransparency(ref object resultValue)
        {
            var interpreter = Parent.Set<DrawingAttributesInterpreter>();
            resultValue = interpreter.HasTransparency ? interpreter.Transparency : 0.0;
        }

        private void OnSetTransparency(object data)
        {
            BeginUpdate();
            Parent.Set<DrawingAttributesInterpreter>().Transparency = (double) data;
            EndVisualUpdate("Changed transparency");
        }

        private void OnGetColor(ref object resultValue)
        {
            var colorInterpreter = Parent.Set<DrawingAttributesInterpreter>();
            object color = colorInterpreter.HasColorSet
                               ? ConvertFromDrawingColor(colorInterpreter.Color)
                               : Color.FromRgb(255, 255, 10);
            resultValue = color;
        }


        private static Color ConvertFromDrawingColor(System.Drawing.Color color)
        {
            return Color.FromRgb(color.R, color.G, color.B);
        }

        private void OnSetColor(object data)
        {
            BeginUpdate();
            var color = (Color) data;
            Parent.Set<DrawingAttributesInterpreter>().Color = System.Drawing.Color.FromArgb(color.A, color.R, color.G,
                                                                                             color.B);
            EndVisualUpdate("Changed color");
        }

        private void OnGetPossibleConstraints(ref object resultValue)
        {
            _constraintsProperty.UpdateFieldValue();
            var document = _viewInfo.Document;
            var sketchNode = NodeBuilderUtils.FindSketchNode(Builder.Node);
            var constraintDocumentHelper = new ConstraintDocumentHelper(document, sketchNode);
            var constraintList = constraintDocumentHelper.GetAvailableConstraints(new List<Node> {Builder.Node}, existingConstraints);
          
            var possibleConstraints = constraintList.Select(constraint => new NewConstraintInfo()
                                        {
                                            ConstraintName = constraint.Replace("Function", string.Empty), 
                                            ConstraintFunctionName = constraint, SketchNode = sketchNode, SelectedNodes = new List<Node> {Builder.Node}
                                        }).ToList();

            resultValue = possibleConstraints;
        }
    }
}