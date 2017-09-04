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
    public class ArcTab : GridTabBase
    {
        private DoublePropertyTabItem _lengthProperty;
        private DoublePropertyTabItem _startAngleProperty;
        private DoublePropertyTabItem _endAngleProperty;
        private DoublePropertyTabItem _internalAngleProperty;
        
        public ArcTab()
            : base(PropertyDescriptorsResources.TabTitleArc)
        {
        }

        protected override void BuildInterface()
        {
            _lengthProperty = new DoublePropertyTabItem();
            _lengthProperty.OnGetValue += GetRadiusValue;
            _lengthProperty.OnSetValue += SetRadiusValue;
            PropertyListGenerator.AddProperty(PropertyDescriptorsResources.CircleTab_Range, _lengthProperty);

            _startAngleProperty = new DoublePropertyTabItem();
            _startAngleProperty.OnGetValue += GetStartAngleValue;
            _startAngleProperty.OnSetValue += SetStartAngleValue;

            PropertyListGenerator.AddProperty(PropertyDescriptorsResources.ArcTab_StartAngle, _startAngleProperty);

            _endAngleProperty = new DoublePropertyTabItem();
            _endAngleProperty.OnGetValue += GetEndAngleValue;
            _endAngleProperty.OnSetValue += SetEndAngleValue;

            PropertyListGenerator.AddProperty(PropertyDescriptorsResources.ArcTab_EndAngle, _endAngleProperty);
            _internalAngleProperty = new DoublePropertyTabItem();
            _internalAngleProperty.OnGetValue += GetInternalAngleValue;
            _internalAngleProperty.OnSetValue += SetInternalAngleValue;
            PropertyListGenerator.AddProperty(PropertyDescriptorsResources.ArcTab_InternalAngle, _internalAngleProperty);
        }

        private void GetRadiusValue(ref object resultvalue)
        {
            resultvalue = Builder[0].RefTransformedPoint3D.Distance(Builder[1].RefTransformedPoint3D);
        }

        private void GetStartAngleValue(ref object resultvalue)
        {
            resultvalue = NodeBuilderUtils.GetStartAngle(Builder);
        }

        private void GetEndAngleValue(ref object resultvalue)
        {
            resultvalue = NodeBuilderUtils.GetEndAngle(Builder);
        }

        private void GetInternalAngleValue(ref object resultvalue)
        {
            resultvalue = NodeBuilderUtils.GetInternalAngle(Builder);
        }

        private void SetStartAngleValue(object data)
        {
            if (Builder.Node.Children.Count == 0)
                return;
            BeginUpdate();
            var angle = (double)data;
            Builder[1].RefTransformedPoint3D = NodeBuilderUtils.PositionForAngle(Builder, Builder[0].RefTransformedPoint3D,
                                                                Builder[1].RefTransformedPoint3D, angle);
            Builder.ExecuteFunction();
            NodeBuilderUtils.UpdateSketchesOnFaces(new NodeBuilder(Parent));
            EndVisualUpdate("");
            
        }

        private void SetRadiusValue(object data)
        {
            var radius = (double)data;
            if (Builder.Node.Children.Count == 0)
                return;
            if (radius > 0)
            {
                BeginUpdate();

                Builder[1].RefTransformedPoint3D = NodeBuilderUtils.PointForNewArcRadius(Builder,
                                                                                     Builder[0].RefTransformedPoint3D,
                                                                                     Builder[1].RefTransformedPoint3D,
                                                                                     radius);
                Builder[2].RefTransformedPoint3D = NodeBuilderUtils.PointForNewArcRadius(Builder,
                                                                                     Builder[0].RefTransformedPoint3D,
                                                                                     Builder[2].RefTransformedPoint3D,
                                                                                     radius);

                Builder.ExecuteFunction();
                NodeBuilderUtils.UpdateSketchesOnFaces(new NodeBuilder(Parent));
                EndVisualUpdate("");
            }
        }

        private void SetInternalAngleValue(object data)
        {
            if (Builder.Node.Children.Count == 0)
                return;
            BeginUpdate();
            var angle = (double)data;

            Builder[2].RefTransformedPoint3D = NodeBuilderUtils.SetInternalAngle(Builder, angle);
            EndVisualUpdate("");
        }

        private void SetEndAngleValue(object data)
        {
            if (Builder.Node.Children.Count == 0)
                return;
            BeginUpdate();
            var angle = (double)data;
          
            Builder[2].RefTransformedPoint3D = NodeBuilderUtils.PositionForAngle(Builder, Builder[0].RefTransformedPoint3D,
                                                                Builder[2].RefTransformedPoint3D, angle);
            Builder.ExecuteFunction();
            NodeBuilderUtils.UpdateSketchesOnFaces(new NodeBuilder(Parent));
            EndVisualUpdate("");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _lengthProperty.SetTabOrder(tabIndex);
        }

        
    }
}