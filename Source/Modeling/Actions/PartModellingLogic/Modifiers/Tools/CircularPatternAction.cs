#region Usings

using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroPipes.Constants;
using OccCode;
using PartModellingUi.Views.Tools;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using ShapeFunctionsInterface.Interpreters;
using Naro.Infrastructure.Interface.GeomHelpers;
using System.Collections.Generic;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Implements Circular Pattern .
    /// </summary>
    public class CircularPatternAction : Pattern
    {
        private CircularPatternWindow _circularPatternWindow;


        public CircularPatternAction()
            : base(ModifierNames.CircularPattern)
        {
            DependsOn(InputNames.GlobalCapabilitiesInput);
        }

        protected override void OnTreeNodeSelect(Node node)
        {
            OnShapePicked(node);
        }


        protected override void BuildDialog(string dialogTitle)
        {
            if (_circularPatternWindow != null)
                return;
            _builder = new NodeBuilder(_selectedNodes[0]);
            _axis = GeomUtils.ExtractAxis(new NodeBuilder(_selectedNodes[1]).Shape);
            _circularPatternWindow = new CircularPatternWindow(dialogTitle, AxisLength());
            _circularPatternWindow.OnValueChange += PreviewCircularPattern;
            _circularPatternWindow.OnDialogClosed += OnClosed;
            _circularPatternWindow.Show();
            PreviewCircularPattern();
        }

        private double AxisLength()
        {
            try
            {
                var selectedBuilder = new NodeBuilder(_selectedNodes[1]);
                var firstPoint = selectedBuilder[1].TransformedPoint3D;
                var secondPoint = selectedBuilder[3].TransformedPoint3D;
                var distance = firstPoint.Distance(secondPoint);
                return distance;
            }
            catch
            {
                return 10;
            }
        }


        private void PreviewCircularPattern()
        {
            InitSession();
            _circularPatternWindow.RecalculateValues();
            MakeCircularPattern(_circularPatternWindow.Number, _circularPatternWindow.Angle,
                                _circularPatternWindow.Between, _circularPatternWindow.Reverse, true);
            UpdateView();
        }

        private void OnClosed()
        {
            InitSession();
            if (!_circularPatternWindow.Result)
            {
                BackToNeutralModifier();
                return;
            }
            // Add Pattern Code
            MakeCircularPattern(_circularPatternWindow.Number, _circularPatternWindow.Angle,
                                _circularPatternWindow.Between, _circularPatternWindow.Reverse, false);
            
            BackToNeutralModifier();
        }

        protected override void UpdateShapeSelection()
        {
            if (_selectedNodes.Count < 2) return;
            BuildDialog("Circular Pattern");
        }

        private void MakeCircularPattern(int number, double angle, double heigth, int reverse, bool previewMode)
        {
            var sketchNodes = new List<Node>();
            for (var index = 1; index < number; index++)
            {
                var affectedPoints = NodeBuilderUtils.CopyPaste(_selectedNodes[0]);
                
                foreach (var child in affectedPoints)
                {
                    var node = NodeBuilderUtils.FindSketchNode(child);
                    
                    var transformInterpreter = child.Get<TransformationInterpreter>();
                    transformInterpreter.ApplyGeneralCircularPattern(_axis, index * angle, index * heigth * reverse);
                    if (node != null)
                    {
                        sketchNodes.Add(node);
                    }
                    var nb = new NodeBuilder(child);
                    nb.ExecuteFunction();
                }
            }
            if (sketchNodes.Count > 0)
            {
                var document = sketchNodes[0].Root.Get<DocumentContextInterpreter>().Document;
                int shapeIndex = 0;
                foreach (var sketchNode in sketchNodes)
                {
                    if (NodeUtils.SketchHas3DApplied(document, sketchNode, out shapeIndex))
                    {
                        sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, document);
                    }
                }
            }
            if (!previewMode)
            {
                CommitFinal("Apply Circular Pattern");
                UpdateView();
                RebuildTreeView();
        
            }
            
        }

        public override void OnDeactivate()
        {
            if (_circularPatternWindow != null)
            {
                _circularPatternWindow.Close();
                _circularPatternWindow = null;
            }
            base.OnDeactivate();
        }
    }
}