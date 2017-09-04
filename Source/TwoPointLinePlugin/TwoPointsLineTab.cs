#region Usings

using System;
using Naro.Infrastructure.Library.Algo;

using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using NaroCppCore.Occ.Precision;

#endregion

namespace TwoPointLinePlugin
{
    internal class TwoPointsLineTab : GridTabBase
    {
        public TwoPointsLineTab(string title) : base(title)
        {
        }

        protected override void BuildInterface()
        {
            var lengthProperty = new DoublePropertyTabItem();
            lengthProperty.OnSetValue += OnSetLengthValueHandler;
            lengthProperty.OnGetValue += OnGetLengthValueHandler;
            PropertyListGenerator.AddProperty("Length", lengthProperty);
        }

        private void OnGetLengthValueHandler(ref object resultvalue)
        {
            var lineLength = GetLineLength();
            resultvalue = lineLength;
        }

        private double GetLineLength()
        {
            return Builder[0].TransformedPoint3D.Distance(Builder[1].TransformedPoint3D);
        }

        private void OnSetLengthValueHandler(object data)
        {
            var oldLength = GetLineLength();
            var length = (double) data;
            var scale = length/oldLength;
            if (Math.Abs(scale - 1) < Precision.Confusion)
                return;
            var result = TreeUtils.ScaleSegment(Builder[0].TransformedPoint3D, Builder[1].TransformedPoint3D, scale);
            BeginUpdate();
            Builder[1].TransformedPoint3D = result;
            EndVisualUpdate("Updated Length");
        }
    }
}