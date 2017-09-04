#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroSketchAdapter.Views;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes2D
{
    /// <summary>
    ///   Description of Point3DTab.
    /// </summary>
    public class Point3DTab : GridTabBase
    {
        private Point3DPropertyTabItem _firstPointProperty;

        public Point3DTab()
            : base(PropertyDescriptorsResources.TabTitlePoint)
        {
        }

        protected override void BuildInterface()
        {
            _firstPointProperty = new Point3DPropertyTabItem();
            _firstPointProperty.OnSetValue += OnSetValue;
            _firstPointProperty.OnGetValue += OnGetValue;
            PropertyListGenerator.AddProperty("First Point", _firstPointProperty);
        }

        private void OnGetValue(ref object resultvalue)
        {
            resultvalue = Builder[1].TransformedPoint3D;
        }

        private void OnSetValue(object data)
        {
            BeginUpdate();
            var intialValue = Builder[1].TransformedPoint3D;
            Builder[1].TransformedPoint3D = (Point3D) data;

            var result = CallSolverForPointChanges(Builder.Node);
            if (result == 1)
            {
                Builder[1].TransformedPoint3D = intialValue;
                CallSolverForPointChanges(Builder.Node);
            }
            EndVisualUpdate("Updated point coordinate");
        }

        private int CallSolverForPointChanges(Node Parent)
        {
            var dependency = TreeUtils.GetFunctionDependency(Parent);
            var sketchNode = Parent.Children[1].Get<ReferenceInterpreter>().Node;
            var constraintMapper =
            new ConstraintDocumentHelper(dependency[0].Node.Root.Get<DocumentContextInterpreter>().Document,
                                 sketchNode);
            constraintMapper.SetMousePosition(Parent.Index);//dependency[0].Reference.Index);
            var error = constraintMapper.ImpactAndSolve(Parent);
            return error;
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _firstPointProperty.SetTabOrder(tabIndex);
        }
    }
}