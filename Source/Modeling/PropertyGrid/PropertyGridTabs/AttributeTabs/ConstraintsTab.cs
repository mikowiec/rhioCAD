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
    public class ConstraintsTab : GridTabBase
    {
       
        private ListPropertyTabItem _constraintsProperty;
        private AvailableConstraintsTabItem _newConstraintsProperty;
        private ListShapesTabItem _shapesProperty;

        public ConstraintsTab()
            : base("Constraints")
        {
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _shapesProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _constraintsProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _newConstraintsProperty.SetTabOrder(tabIndex);
        }

        protected override void BuildInterface()
        {
            _shapesProperty = new ListShapesTabItem();
            _shapesProperty.OnGetValue += OnGetShapes;
            PropertyListGenerator.AddProperty("Shapes", _shapesProperty);

            _constraintsProperty = new ListPropertyTabItem();
            _constraintsProperty.OnGetValue += OnGetConstraints;
            PropertyListGenerator.AddProperty("Constraints", _constraintsProperty);
            _newConstraintsProperty = new AvailableConstraintsTabItem(120);
            _newConstraintsProperty.OnGetValue += OnGetPossibleConstraints;
            PropertyListGenerator.AddProperty("Add Constraints", _newConstraintsProperty);
        }

        private List<string> existingConstraints = new List<string>();
        private List<string> selectedShapes = new List<string>();
        private void OnGetConstraints(ref object resultValue)
        {
            existingConstraints.Clear();
            var _document = _viewInfo.Document;
            var listConstraints = new List<NodeBuilder>();
            var constraints = (from child in _document.Root.Children where NodeUtils.NodeIsConstraint(child.Key, _document) select child.Value).ToList();
           if(Parent != null && SecondNode != null)
            {
                foreach (var constraint in constraints)
                {
                    if (Document.NodeReferences(constraint, Parent) && Document.NodeReferences(constraint, SecondNode))
                    {
                        listConstraints.Add(new NodeBuilder(constraint));
                        existingConstraints.Add(constraint.Get<FunctionInterpreter>().Name);
                    }
                }
            }
            resultValue = listConstraints;
        }

        private void OnGetShapes(ref object resultValue)
        {
            selectedShapes.Clear();
            var listConstraints = new List<NodeBuilder> {new NodeBuilder(Parent), new NodeBuilder(SecondNode)};

            resultValue = listConstraints;
        }

        private void OnGetPossibleConstraints(ref object resultValue)
        {
            _constraintsProperty.UpdateFieldValue();
            var document = _viewInfo.Document;
            var sketchNode = NodeBuilderUtils.FindSketchNode(Builder.Node);
            var constraintDocumentHelper = new ConstraintDocumentHelper(document, sketchNode);
            var constraintList = constraintDocumentHelper.GetAvailableConstraints(new List<Node> {Parent, SecondNode}, existingConstraints);
          
            var possibleConstraints = constraintList.Select(constraint => new NewConstraintInfo
                                        {
                                            ConstraintName = constraint.Replace("Function", string.Empty), 
                                            ConstraintFunctionName = constraint, SketchNode = sketchNode, SelectedNodes = new List<Node>{Parent, SecondNode}
                                        }).ToList();

            resultValue = possibleConstraints;
        }
    }
}