#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NaroPipes.Constants;
using OccCode;
using PartModellingUi.Views.Tools;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using System.Collections.Generic;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Implements Array Pattern .
    /// </summary>
    public class ArrayPatternAction : Pattern
    {
        private gpAx1 _ColumnAxis;
        private ArrayPatternWindow _arrayPatternWindow;


        public ArrayPatternAction()
            : base(ModifierNames.ArrayPattern)
        {
            DependsOn(InputNames.GlobalCapabilitiesInput);
        }

        protected override void OnTreeNodeSelect(Node node)
        {
            base.OnShapePicked(node);
        }

        protected override void UpdateShapeSelection()
        {
            if (_selectedNodes.Count < 2) return;
            BuildDialog("Array Pattern");
        }


        protected override void BuildDialog(string dialogTitle)
        {
            if (_arrayPatternWindow != null)
                return;
            _builder = new NodeBuilder(_selectedNodes[0]);
            _axis = GeomUtils.ExtractAxis(new NodeBuilder(_selectedNodes[1]).Shape);
            _arrayPatternWindow = new ArrayPatternWindow(dialogTitle);
            _arrayPatternWindow.OnValueChange += PreviewArrayPattern;
            _arrayPatternWindow.OnDialogClosed += OnClosed;
            _arrayPatternWindow.Show();
            var _normalAxis = GetNormalAxis();
            _ColumnAxis = new gpAx1(_axis.Location,_normalAxis.Direction.Crossed(_axis.Direction));
            PreviewArrayPattern();
        }

        private gpAx1 GetNormalAxis()
        {
            var restrictedPlaneInput = Inputs[InputNames.Mouse3DEventsPipe];
            var plane = (gpPln) restrictedPlaneInput.GetData(NotificationNames.GetPlane).Data;
            if (plane == null) return new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
            return plane.Axis;
        }


        private void PreviewArrayPattern()
        {
            InitSession();
            MakeArrayPattern(_arrayPatternWindow.Rows, _arrayPatternWindow.Colomns, _arrayPatternWindow.RowDistance,
                             _arrayPatternWindow.ColomnDistance, _arrayPatternWindow.ReverseRows,
                             _arrayPatternWindow.ReverseColomns, true);
            UpdateView();
        }

        private void OnClosed()
        {
            InitSession();
            if (!_arrayPatternWindow.Result)
            {
                BackToNeutralModifier();
                return;
            }
            // Add Pattern Code
            MakeArrayPattern(_arrayPatternWindow.Rows, _arrayPatternWindow.Colomns, _arrayPatternWindow.RowDistance,
                             _arrayPatternWindow.ColomnDistance, _arrayPatternWindow.ReverseRows,
                             _arrayPatternWindow.ReverseColomns, false);
       
            // Finish the transaction
            Document.Commit("Apply Array Pattern");
          
         
            UpdateView();

            Log.Info("Array Pattern succesfully completed ");

            // Change back to selection mode
            BackToNeutralModifier();
        }

        private void MakeArrayPattern(int rows, int columns, double rowDistance, double colomnsDistance, int reverseRows,
                                      int reverseColomns, bool previewMode)
        {
            var indexColomns = 1;
            Document document = null;
            var sketchNodes = new List<Node>();
            for (var indexRows = 0; indexRows < rows; indexRows++)
            {
                for (; indexColomns < columns; indexColomns++)
                {
                    var affectedPoints =  NodeBuilderUtils.CopyPaste(_selectedNodes[0]);
                    foreach (var child in affectedPoints)
                    {
                        var node = NodeBuilderUtils.FindSketchNode(child);
                        var transformInterpreter = child.Set<TransformationInterpreter>();
                        transformInterpreter.ApplyGeneralArrayPattern(_axis, _ColumnAxis,
                                                                      indexRows * rowDistance * reverseRows,
                                                                      indexColomns * colomnsDistance * reverseColomns);
                        if (node != null)
                        {
                            sketchNodes.Add(node);
                        }
                        var nb = new NodeBuilder(child);
                        nb.ExecuteFunction();
                    }
                }
                indexColomns = 0;
            }
            if (sketchNodes.Count > 0)
            {
                
                document = sketchNodes[0].Root.Get<DocumentContextInterpreter>().Document;
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
                CommitFinal("Apply Array Pattern");
                UpdateView();
                RebuildTreeView();
            }
        }

        public override void OnDeactivate()
        {
            if (_arrayPatternWindow != null)
            {
                _arrayPatternWindow.Close();
                _arrayPatternWindow = null;
            }
            base.OnDeactivate();
        }
    }
}