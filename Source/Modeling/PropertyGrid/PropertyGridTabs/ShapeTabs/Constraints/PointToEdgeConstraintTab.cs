#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.TopoDS;
using NaroSketchAdapter.Views;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class PointToEdgeConstraintTab : GridTabBase
    {
        public PointToEdgeConstraintTab() : base("Distance Constraint")
        {
        }

        protected override void BuildInterface()
        {
            var lengthProperty = new DoublePropertyTabItem();
            lengthProperty.OnSetValue += SetLength;
            lengthProperty.OnGetValue += GetLength;
            PropertyListGenerator.AddProperty("Distance", lengthProperty);
        }

        private void GetLength(ref object resultvalue)
        {
            if(Builder[0].ReferenceBuilder.FunctionName == FunctionNames.Circle)
            {
                var radius = Builder[0].ReferenceBuilder.Dependency[1].Real;
                resultvalue = radius * 2;
                return;
            }
            var referenceShape = ShapeUtils.ExtractSubShape(Builder[0].ReferenceData);
            var edge = TopoDS.Edge(referenceShape); 
            var curve = new BRepAdaptorCurve(edge);  
            var firstPoint = curve.Value(curve.FirstParameter);
            var lastPoint = curve.Value(curve.LastParameter);
            var length = firstPoint.Distance(lastPoint);
            resultvalue = length;
        }

        private void SetLength(object data)
        {
            if (Builder[0].ReferenceBuilder.FunctionName == FunctionNames.Circle)
            {
                BeginUpdate();
                var nb = new NodeBuilder(Builder[0].ReferenceBuilder.Node);
                nb[1].Real = (double) data/2;
                nb.ExecuteFunction();
                EndVisualUpdate("Updated radius");
            }
            if (Builder[0].ReferenceBuilder.FunctionName != FunctionNames.LineTwoPoints)
                return;
            BeginUpdate();
            TreeUtils.SetLineLength(Builder[0].ReferenceBuilder.Node, (double) data);
            var document = _viewInfo.Document;
            var constraint = NodeBuilderUtils.ShapeHasConstraint(Builder[0].ReferenceBuilder.Node, Constraint2DNames.LineLengthFunction, document);
            if (constraint != -1)
            {
                var nb = new NodeBuilder(document.Root[constraint]);
                nb.Dependency[2].Real = (double) data;
                nb.ExecuteFunction();
            }
            CallSolverForLineChanges(Builder[0].ReferenceBuilder.Node);
            EndVisualUpdate("Updated Length");
        }

        private void CallSolverForLineChanges(Node Parent)
        {
            var dependency = TreeUtils.GetFunctionDependency(Parent);
            var sketchNode = dependency[0].ReferenceBuilder[0].ReferenceBuilder[0].Node;
            var document = dependency[0].Node.Root.Get<DocumentContextInterpreter>().Document;
            var constraintMapper = 
            new ConstraintDocumentHelper(document,sketchNode);
            constraintMapper.SetMousePosition(Parent.Index);
            constraintMapper.ImpactAndSolve(dependency[0].ReferenceBuilder.Node);
            var pnt = dependency[0].RefTransformedPoint3D;
            dependency[0].RefTransformedPoint3D = pnt;
            document.Commit("Dimension constraint updated");
        }
    }
}