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
    public class SelectionsTab : GridTabBase
    {
        private ListShapesTabItem _shapesProperty;

        public SelectionsTab()
            : base("Shapes")
        {
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _shapesProperty.SetTabOrder(tabIndex);
        }

        protected override void BuildInterface()
        {
            _shapesProperty = new ListShapesTabItem(144);
            _shapesProperty.OnGetValue += OnGetShapes;
            
            PropertyListGenerator.AddProperty("Shapes", _shapesProperty);
        }

        private List<string> selectedShapes = new List<string>();

        private void OnGetShapes(ref object resultValue)
        {
            selectedShapes.Clear();
            var listShapes = Nodes.Select(node => new NodeBuilder(node)).ToList();
            resultValue = listShapes;
        }
    }
}