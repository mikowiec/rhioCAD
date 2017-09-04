#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroConstants.Names;
using NaroSketchAdapter.Views;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes2D
{
    public class CircleTab : GridTabBase
    {
        private DoublePropertyTabItem _lengthProperty;

        public CircleTab()
            : base(PropertyDescriptorsResources.TabTitleCircle)
        {
        }

        protected override void BuildInterface()
        {
            _lengthProperty = new DoublePropertyTabItem();
            _lengthProperty.OnSetValue += SetValue;
            _lengthProperty.OnGetValue += GetValue;
          //  _lengthProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent, FunctionNames.CircleRangeConstraint));
         //   _lengthProperty.OnLockClicked += OnLengthLocked;
            PropertyListGenerator.AddProperty(PropertyDescriptorsResources.CircleTab_Range, _lengthProperty);
        }

        private void OnLengthLocked(bool islocked)
        {
            UpdateCircleLock();//islocked, FunctionNames.CircleRadiusConstraint, 1);
        }

        private void GetValue(ref object resultvalue)
        {
            resultvalue = Builder[1].Real;
        }

        private void SetValue(object data)
        {
            BeginUpdate();
            //if (Builder.Node.Children.Count == 0)
            //{
            //    return;
            //}
            Builder[1].Real = (double) data;
            CallSolverForLineChanges(Parent);
            NodeBuilderUtils.UpdateSketchesOnFaces(new NodeBuilder(Parent));
            EndVisualUpdate("Set circle radius");
        }

        private void CallSolverForLineChanges(Node Parent)
        {
            var dependency = TreeUtils.GetFunctionDependency(Parent);
            var sketchNode = dependency[0].ReferenceBuilder[0].ReferenceBuilder[0].Node;
            var constraintMapper =
            new ConstraintDocumentHelper(dependency[0].Node.Root.Get<DocumentContextInterpreter>().Document,
                                 sketchNode);
            constraintMapper.SetMousePosition(dependency[0].Reference.Index);
            constraintMapper.ImpactAndSolve(Parent);
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _lengthProperty.SetTabOrder(tabIndex);
        }
    }
}