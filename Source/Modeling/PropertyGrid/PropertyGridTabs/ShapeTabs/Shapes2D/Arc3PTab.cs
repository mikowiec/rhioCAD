#region Usings

using System;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using OccCode;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes2D
{
    public class Arc3PTab : GridTabBase
    {
        private DoublePropertyTabItem _lengthProperty;
        private DoublePropertyTabItem _startAngleProperty;
        private DoublePropertyTabItem _endAngleProperty;
        private DoublePropertyTabItem _internalAngleProperty;
        
        public Arc3PTab()
            : base(PropertyDescriptorsResources.TabTitleArc)
        {
        }

        protected override void BuildInterface()
        {
            _lengthProperty = new DoublePropertyTabItem();
            _lengthProperty.OnGetValue += GetRadiusValue;
            PropertyListGenerator.AddProperty(PropertyDescriptorsResources.CircleTab_Range, _lengthProperty);
        }

        private void GetRadiusValue(ref object resultvalue)
        {
            var a = Builder[0].RefTransformedPoint3D.Distance(Builder[1].RefTransformedPoint3D);
            var b = Builder[1].RefTransformedPoint3D.Distance(Builder[2].RefTransformedPoint3D);
            var c = Builder[0].RefTransformedPoint3D.Distance(Builder[2].RefTransformedPoint3D);
            resultvalue = a * b * c / Math.Sqrt((a + b + c) * (b + c - a) * (c + a - b) * (a + b - c));
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _lengthProperty.SetTabOrder(tabIndex);
        }

    }
}