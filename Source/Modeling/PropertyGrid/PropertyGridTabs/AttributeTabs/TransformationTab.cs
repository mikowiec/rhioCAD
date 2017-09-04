#region Usings

using System.Collections.Generic;
using System.Linq;
using ErrorReportCommon.Messages;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using OccCode;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PropertyGridTabs.AttributeTabs
{
    public class TransformationTab : GridTabBase
    {
        private Point3DPropertyTabItem _pivotProperty;
        private Point3DPropertyTabItem _rotateProperty;
        private DoublePropertyTabItem _scaleProperty;
        private Point3DPropertyTabItem _translateproperty;

        public TransformationTab()
            : base("Transformation")
        {
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _pivotProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _translateproperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _rotateProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _scaleProperty.SetTabOrder(tabIndex);
        }

        protected override void BuildInterface()
        {
            if (_pivotProperty == null)
            {
                _pivotProperty = new Point3DPropertyTabItem();
                _pivotProperty.OnSetValue += SetPivotValue;
                _pivotProperty.OnGetValue += GetPivotValue;
            }
            PropertyListGenerator.AddProperty("Pivot", _pivotProperty);

            if (_translateproperty == null)
            {
                _translateproperty = new Point3DPropertyTabItem();
                _translateproperty.OnSetValue += SetTranslateValue;
                _translateproperty.OnGetValue += GetTranslateValue;
            }
            PropertyListGenerator.AddProperty("Translate", _translateproperty);

            if (_rotateProperty == null)
            {
                _rotateProperty = new Point3DPropertyTabItem();
                _rotateProperty.OnSetValue += SetRotateValue;
                _rotateProperty.OnGetValue += GetRotateValue;
            }
            PropertyListGenerator.AddProperty("Rotate", _rotateProperty);

            if (_scaleProperty == null)
            {
                _scaleProperty = new DoublePropertyTabItem();
                _scaleProperty.OnSetValue += SetScaleValue;
                _scaleProperty.OnGetValue += GetScaleValue;
            }
            PropertyListGenerator.AddProperty("Scale", _scaleProperty);
        }

        private void GetScaleValue(ref object resultvalue)
        {
            var interpreter = Parent.Set<TransformationInterpreter>();
            resultvalue = interpreter.Scale;
        }

        private void SetScaleValue(object data)
        {
            var value = (double)data;
            if (value < 0.0001)
            {
                NaroMessage.Show("You should input a value greater than zero");
                return;
            }
            BeginUpdate();
            var interpreter = Parent.Set<TransformationInterpreter>();
            interpreter.Scale = value;
            EndVisualUpdate("Scale object");
        }

        private void GetRotateValue(ref object resultvalue)
        {
            var nb = new NodeBuilder(Parent);
            if (nb.FunctionName != FunctionNames.Sketch)
                return;

            var interpreter = Parent.Get<TransformationInterpreter>();
            if (interpreter == null) return;
            var transformations = NodeBuilderUtils.GetTransformations(nb);
            var multiplied = new gpTrsf();
            foreach (var trsf in transformations)
                multiplied = multiplied.Multiplied(trsf);
            var matr = multiplied.VectorialPart;
            // extract rotation from matrix
        }

        private void SetRotateValue(object data)
        {
            BeginUpdate();

            var nodeBuilder = new NodeBuilder(Parent);
            var mouseRotation = TransformationInterpreter.GetRotateTrsf((Point3D)data);
            var sketchNode = NodeBuilderUtils.FindBaseSketchNode(Parent);

            var document = sketchNode.Root.Get<DocumentContextInterpreter>().Document;
            if (!NodeUtils.NodeIsOnSketch(nodeBuilder))
            {
                var list = NodeBuilderUtils.GetAllContained3DNodesIndexes(nodeBuilder.Node).Distinct().ToList();
                var sketchNodes = new List<Node>();
                foreach (var nodeIndex in list)
                {
                    var node = document.Root[nodeIndex.Key];
                    var shapeNodeBuilder = new NodeBuilder(node);
                    if (FunctionNames.GetSolids().Contains(nodeBuilder.FunctionName))
                        continue;

                    var affectedSketchNode = shapeNodeBuilder.Dependency[0].ReferenceBuilder.Node;

                    if (affectedSketchNode != null)
                    {
                        var nb1 = new NodeBuilder(affectedSketchNode);
                        if (nb1.Dependency[2].Reference == null)
                            sketchNodes.Add(affectedSketchNode);
                    }
                }

                document.Transact();
                foreach (var solid in sketchNodes)
                {
                    var nb = new NodeBuilder(solid);
                    var trsfCurrent = nb.Node.Get<TransformationInterpreter>().CurrTransform;
                    trsfCurrent = trsfCurrent.Multiplied(mouseRotation);
                    // we need to invert the transformation to make it positive for the x-axis
                    trsfCurrent = trsfCurrent.Inverted;

                    var transformationInfo = new TransformationInfo
                                                 {
                                                     SketchIndex = solid.Index,
                                                     Transformation = mouseRotation,
                                                     TrsfIndex = TransformationInfo.maxTrsfIndex,
                                                     RefSketchIndex = -2
                                                 };
                    TransformationInfo.maxTrsfIndex++;
                    TransformationInterpreter.Transformations.Add(transformationInfo);
                    nb.Node.Set<TransformationInterpreter>().CurrTransform = trsfCurrent;
                    nb.ExecuteFunction();
                }
                document.Commit("Rotated");
            }
            EndVisualUpdate("Rotate object");
        }

        private void GetTranslateValue(ref object resultvalue)
        {
            var interpreter = Parent.Get<TransformationInterpreter>();
            if (interpreter == null) return;
            resultvalue = interpreter.ShapeOrigin;
        }

        private void SetTranslateValue(object data)
        {
            var nodeBuilder = new NodeBuilder(Parent);
            var _3dShapesFunctions = new List<string>();
            _3dShapesFunctions.AddRange(new[] { FunctionNames.Sphere, FunctionNames.Box, FunctionNames.Cylinder,
            FunctionNames.Torus, FunctionNames.Cone, FunctionNames.Boolean});
            if (_3dShapesFunctions.Contains(nodeBuilder.FunctionName))
            {
                NodeUtils.TranslateSolids(nodeBuilder, (Point3D)data);
                return;
            }
            var sketchNode = NodeBuilderUtils.FindBaseSketchNode(Parent);

            var document = sketchNode.Root.Get<DocumentContextInterpreter>().Document;
            var newPoint = (Point3D)data;
          
            document.Transact();
            if (NodeUtils.NodeIsOnSketch(nodeBuilder))
            {
                NodeUtils.TranslateSketchNode(nodeBuilder, newPoint, sketchNode); 
            }
            else
            {
                NodeUtils.Translate3DNode(nodeBuilder, document, newPoint);
            }
            document.Commit("Translated");
            EndVisualUpdate("Translate object");
        }

        private void GetPivotValue(ref object resultvalue)
        {
            var interpreter = Parent.Get<TransformationInterpreter>();
            if (interpreter != null)
                resultvalue = new Point3D(interpreter.Pivot);
            else
                resultvalue = Builder[0].Name == InterpreterNames.Point3D
                                  ? Builder[0].TransformedPoint3D
                                  : new Point3D();
        }

        private void SetPivotValue(object data)
        {
            BeginUpdate();
            var interpreter = Parent.Set<TransformationInterpreter>();
            interpreter.Pivot = ((Point3D)data).GpPnt;
            //_translateDescriptor.Coordinate = _pivotDescriptor.Coordinate;
            EndVisualUpdate("Change pivot of the shape.");
        }
    }
}