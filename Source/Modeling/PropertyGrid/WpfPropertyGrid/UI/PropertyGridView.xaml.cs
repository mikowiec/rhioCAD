#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Documents;
using Naro.Infrastructure.Interface;
using NaroConstants.Names;
using PropertyDescriptorsInterface;
using PropertyGridTabs.AttributeTabs;
using PropertyGridTabs.ShapeTabs.Constraints;
using PropertyGridTabs.ShapeTabs.Shapes2D;
using PropertyGridTabs.ShapeTabs.Shapes3D;
using PropertyGridTabs.ShapeTabs.Tools;
using Resources.Modeling;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace WpfPropertyGrid.UI
{
    public partial class PropertyGridView : IPropertyGridView
    {
        private readonly List<GridTabBase> _addedTabs = new List<GridTabBase>();
        private readonly List<string> _filteringTokens = new List<string>();
        private int _gvTabIndex;
        private Node _selectedNode;
        private ViewInfo _viewInfo;

        public PropertyGridView()
        {
            InitializeComponent();
            Setup();
        }

        #region IPropertyGridView Members

        public void OnSelectNode(Node shapeNode)
        {
            _selectedNode = shapeNode;

            RefreshGrid();
        }

        public void OnSelectNodes(Node node1, Node node2)
        {
            //_selectedNode = shapeNode;

          //  RefreshGrid();
            if (_selectedNode == null) return;
            ClearGridSections();
            _gvTabIndex = 0;
            FillConstraintsDescriptor(node1, node2, _gvTabIndex);
        }

        public void OnSelectNodes(List<SceneSelectedEntity> nodes)
        {
            //_selectedNode = shapeNode;

            //  RefreshGrid();
            ClearGridSections();
            if (_selectedNode == null) return;
            if (nodes.Count < 3)
                return;
            //ClearGridSections();
            _gvTabIndex = 0;
            FillShapesDescriptor(nodes, _gvTabIndex);
        }

        public void RefreshGrid()
        {
            if (_selectedNode == null) return;
            ClearGridSections();
            _gvTabIndex = 0;
            FillSpecificShapeDescriptor(_selectedNode, _gvTabIndex);
            FillGenericShapeDescriptor(_selectedNode, _gvTabIndex);
        }

        #endregion

        public void UpdateViewInfo(ViewInfo viewInfo)
        {
            _viewInfo = viewInfo;
        }

        private static void Setup()
        {
            //Shapes 2D
            RegisterFunctionTab(FunctionNames.LineTwoPoints, new LineTab());
            RegisterFunctionTab(FunctionNames.Circle, new CircleTab());
            RegisterFunctionTab(FunctionNames.Arc, new ArcTab());
            RegisterFunctionTab(FunctionNames.Arc3P, new Arc3PTab());
            RegisterFunctionTab(FunctionNames.Ellipse, new EllipseTab());
            RegisterFunctionTab(FunctionNames.ThreePointsRectangle,
                                new ParalellogramTab(PropertyDescriptorsResources.TabTitleRectangle));
            RegisterFunctionTab(FunctionNames.Paralleogram,
                                new ParalellogramTab(PropertyDescriptorsResources.TabTitleParallogram));
            RegisterFunctionTab(FunctionNames.HorizontalLine, new HorizontalLineTab());
            RegisterFunctionTab(FunctionNames.VerticalLine, new VerticalLineTab());
            RegisterFunctionTab(FunctionNames.Point, new Point3DTab());

            //Shapes 3D
            RegisterFunctionTab(FunctionNames.Box, new BoxTab());
            RegisterFunctionTab(FunctionNames.Cone, new ConeTab());
            RegisterFunctionTab(FunctionNames.Cylinder, new CylinderTab());
            RegisterFunctionTab(FunctionNames.Sphere, new SphereTab());
            RegisterFunctionTab(FunctionNames.Torus, new TorusTab());

            //Tools
            RegisterFunctionTab(FunctionNames.Cut, new CutTab());
            RegisterFunctionTab(FunctionNames.Extrude, new ExtrudeTab());
            RegisterFunctionTab(FunctionNames.Fillet, new FilletTab());
            RegisterFunctionTab(FunctionNames.Fillet2D, new Fillet2DTab());
            RegisterFunctionTab(FunctionNames.Offset, new OffsetTab());
            RegisterFunctionTab(FunctionNames.Offset3D, new OffsetTab());
            RegisterFunctionTab(FunctionNames.Revolve, new RevolveTab());

            //Constriants
          //  RegisterFunctionTab(FunctionNames.CircleRangeConstraint, new CircleRangeConstraintTab());
            RegisterFunctionTab(FunctionNames.LineLengthConstraint, new LineLengthConstraintTab());
            RegisterFunctionTab(FunctionNames.EllipseMajorRadiusConstraint, new EllipseMajorRadiusConstraintTab());
            RegisterFunctionTab(FunctionNames.EllipseMinorRadiusConstraint, new EllipseMinorRadiusConstraintTab());
            RegisterFunctionTab(FunctionNames.RectangleWidthConstraint, new RectangleWidthConstraintTab());
            RegisterFunctionTab(FunctionNames.RectangleHeightConstraint, new RectangleHeightConstraintTab());
            RegisterFunctionTab(FunctionNames.PointToPointConstraint, new PointToPointConstraintTab());
            RegisterFunctionTab(FunctionNames.Dimension, new PointToEdgeConstraintTab());
            RegisterFunctionTab(FunctionNames.BoxHeightConstraint, new BoxHeightConstraintTab());
            RegisterFunctionTab(FunctionNames.ConeHeightConstraint, new ConeHeightConstraintTab());
            RegisterFunctionTab(FunctionNames.ConeMajorRadiusConstraint, new ConeMajorRadiusConstraintTab());
            RegisterFunctionTab(FunctionNames.ConeMinorRadiusConstraint, new ConeMinorRadiusConstraintTab());
            RegisterFunctionTab(FunctionNames.CylinderHeightConstraint, new CylinderHeightConstraintTab());
            RegisterFunctionTab(FunctionNames.CylinderRadiusConstraint, new CylinderRadiusConstraintTab());
            RegisterFunctionTab(FunctionNames.SphereRadiusConstraint, new SphereRadiusConstraintTab());
            RegisterFunctionTab(FunctionNames.TorusMajorRangeConstraint, new TorusMajorRadiusConstraintTab());
            RegisterFunctionTab(FunctionNames.TorusMinorRangeConstraint, new TorusMinorRadiusConstraintTab());
            RegisterFunctionTab(FunctionNames.EdgeDistanceConstraint, new EdgeDistanceConstraintTab());

            RegisterInterpreterTab<FunctionInterpreter>(new ShapeTab());
            RegisterInterpreterTab<TransformationInterpreter>(new TransformationTab());

            RegisterSelectionTabs();

            RegisterConstraintsTab(FunctionNames.LineTwoPoints, FunctionNames.LineTwoPoints, new ConstraintsTab());
            RegisterConstraintsTab(FunctionNames.LineTwoPoints, FunctionNames.Circle, new ConstraintsTab());
            RegisterConstraintsTab(FunctionNames.Point, FunctionNames.Point, new ConstraintsTab());
            RegisterConstraintsTab(FunctionNames.LineTwoPoints, FunctionNames.Point, new ConstraintsTab());
            RegisterConstraintsTab(FunctionNames.Circle, FunctionNames.Circle, new ConstraintsTab());
            RegisterConstraintsTab(FunctionNames.Circle, FunctionNames.Arc, new ConstraintsTab());
            RegisterConstraintsTab(FunctionNames.Arc, FunctionNames.Arc, new ConstraintsTab());
        }

        private static void RegisterSelectionTabs()
        {
            var availableShapes = new List<string> { FunctionNames.LineTwoPoints, FunctionNames.Circle, FunctionNames.Point, FunctionNames.Ellipse, FunctionNames.Arc,
                                 FunctionNames.Arc3P};
            var selections = new List<String>();
            for(int i=0;i<availableShapes.Count;i++)
                for(int j=0;j<availableShapes.Count;j++)
                    for(int k=0;k<availableShapes.Count;k++)
                    {
                        selections = new List<string>{availableShapes[i], availableShapes[j], availableShapes[k]};
                        RegisterSelectionsTab(selections, new SelectionsTab());
                    }
          }

        private void ClearGridSections()
        {
            stackAllSections.Children.Clear();
            _addedTabs.Clear();
        }

        private void FillGenericShapeDescriptor(Node shapeNode, int tabIndex)
        {
            foreach (var a in
                DescriptorsFactory.Instance.RegisteredTabs.Where(a => shapeNode.Interpreters.ContainsKey(a.Key)))
            {
                a.Value.TabChildCount = 0;
                AddControlToExpander(a.Value, shapeNode);
                a.Value.SetTabOrder(tabIndex);
                _gvTabIndex = _gvTabIndex + a.Value.TabChildCount;
            }
        }

        private void FillShapesDescriptor(List<SceneSelectedEntity> nodes, int tabIndex)
        {
            var tab = DescriptorsFactory.Instance.GetSelectionsTab(nodes[0].Node, nodes[1].Node, nodes[2].Node);
            if (tab == null)
                return;
            AddControlToExpander(tab, nodes);
            tab.TabChildCount = 0;
            tab.SetTabOrder(tabIndex);
            _gvTabIndex = _gvTabIndex + tab.TabChildCount;
        }

        private void FillConstraintsDescriptor(Node shapeNode1, Node shapeNode2, int tabIndex)
        {
            var functionName1 = FunctionUtils.GetFunctionName(shapeNode1);
            var functionName2 = FunctionUtils.GetFunctionName(shapeNode2);
            if (string.IsNullOrEmpty(functionName1) || string.IsNullOrEmpty(functionName2))
                return;
            var tab = DescriptorsFactory.Instance.GetConstraintTab(functionName1, functionName2);
            if (tab == null)
                return;
            AddControlToExpander(tab, shapeNode1, shapeNode2);
            tab.TabChildCount = 0;
            tab.SetTabOrder(tabIndex);
            _gvTabIndex = _gvTabIndex + tab.TabChildCount;
        }

        private void FillSpecificShapeDescriptor(Node shapeNode, int tabIndex)
        {
            var functionName = FunctionUtils.GetFunctionName(shapeNode);
            if (string.IsNullOrEmpty(functionName))
                return;
            var tab = DescriptorsFactory.Instance.GetFunctionTab(functionName);
            if (tab == null)
                return;
            AddControlToExpander(tab, shapeNode);
            tab.TabChildCount = 0;
            tab.SetTabOrder(tabIndex);
            _gvTabIndex = _gvTabIndex + tab.TabChildCount;
        }

        private void AddControlToExpander(GridTabBase tab, Node shapeNode)
        {
            _addedTabs.Add(tab);
            tab.SetParentGrid(this);
            tab.RefreshNode(new StackPanel(), shapeNode, _viewInfo, _filteringTokens);
            var expanderTitle = tab.Title;
            var control = tab.Control;
            var expander = new Expander {Header = expanderTitle, Content = control, IsExpanded = true};
            stackAllSections.Children.Add(expander);
        }

        private void AddControlToExpander(GridTabBase tab, Node shapeNode1, Node shapeNode2)
        {
            _addedTabs.Add(tab);
            tab.SetParentGrid(this);
            tab.RefreshNodes(new StackPanel(), shapeNode1, shapeNode2, _viewInfo, _filteringTokens);
            var expanderTitle = tab.Title;
            var control = tab.Control;
            var expander = new Expander { Header = expanderTitle, Content = control, IsExpanded = true };
            stackAllSections.Children.Add(expander);
        }

        private void AddControlToExpander(GridTabBase tab, List<SceneSelectedEntity> shapeNodes)
        {
            _addedTabs.Add(tab);
            tab.SetParentGrid(this);
            tab.RefreshNode(new StackPanel(), shapeNodes, _viewInfo, _filteringTokens);
            var expanderTitle = tab.Title;
            var control = tab.Control;
            var expander = new Expander { Header = expanderTitle, Content = control, IsExpanded = true };
            stackAllSections.Children.Add(expander);
        }

        private static void RegisterInterpreterTab<T>(GridTabBase tab) where T : AttributeInterpreterBase
        {
            DescriptorsFactory.Instance.RegisterInterpreterTab<T>(tab);
        }

        private static void RegisterSelectionsTab(List<String> selectedObjects, GridTabBase tab)
        {
            DescriptorsFactory.Instance.RegisterSelectionsTab(selectedObjects, tab);
        }

        private static void RegisterFunctionTab(string functionName, GridTabBase tab)
        {
            DescriptorsFactory.Instance.RegisterFunctionTab(functionName, tab);
        }

        private static void RegisterConstraintsTab(string functionName1, string functionName2, GridTabBase tab)
        {
            DescriptorsFactory.Instance.RegisterConstraintsTab(functionName1, functionName2, tab);
        }
    }
}