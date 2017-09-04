#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroConstants.Names;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using NaroSketchAdapter.Views;
using TreeData.NaroData;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes2D
{
    public class LineTab : GridTabBase
    {
        private DoublePropertyTabItem _lengthProperty;
        private Point3DPropertyTabItem _secondPointProperty;

        public LineTab()
            : base(PropertyDescriptorsResources.TabTitleLine)
        {
        }

        protected override void BuildInterface()
        {
            _secondPointProperty = new Point3DPropertyTabItem();
            _secondPointProperty.OnSetValue += OnSetSecondPointValueHandler;
            _secondPointProperty.OnGetValue += OnGetSecondPointValueHandler;
            PropertyListGenerator.AddProperty("Second Point", _secondPointProperty);

            _lengthProperty = new DoublePropertyTabItem();
         //   _lengthProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent, FunctionNames.LineLengthConstraint));
           // _lengthProperty.OnLockClicked += OnLengthLocked;
            _lengthProperty.OnSetValue += OnSetLengthValueHandler;
            _lengthProperty.OnGetValue += delegate(ref object data) { data = TreeUtils.GetLineLength(Parent); };
            PropertyListGenerator.AddProperty("Length", _lengthProperty);
        }

        private void OnLengthLocked(bool islocked)
        {
            UpdateLineLock();
        }

        private void OnGetSecondPointValueHandler(ref object result)
        {
            result = Builder[1].RefTransformedPoint3D;
        }

        private void OnSetSecondPointValueHandler(object data)
        {
            BeginUpdate();
            var dependency = TreeUtils.GetFunctionDependency(Parent);
            dependency[1].RefTransformedPoint3D = (Point3D) data;
          
            CallSolverForLineChanges(Parent);
            EndVisualUpdate("Updated second point");
        }

        private void CallSolverForLineChanges(Node Parent)
        {
            var dependency = TreeUtils.GetFunctionDependency(Parent);
            var sketchNode = dependency[0].ReferenceBuilder[0].ReferenceBuilder[0].Node;
            var constraintMapper =
            new ConstraintDocumentHelper(dependency[0].Node.Root.Get<DocumentContextInterpreter>().Document,
                                 sketchNode);
            constraintMapper.SetMousePosition(dependency[1].Reference.Index);
            constraintMapper.ImpactAndSolve(Parent);
        }

        private void OnSetLengthValueHandler(object data)
        {
            BeginUpdate();
            TreeUtils.SetLineLength(Parent, (double) data);
            CallSolverForLineChanges(Parent);
            NodeBuilderUtils.UpdateSketchesOnFaces(new NodeBuilder(Parent));
            EndVisualUpdate("Updated length");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _secondPointProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _lengthProperty.SetTabOrder(tabIndex);
        }
    }
}