#region Usings

using System.Collections.Generic;
using NaroConstants.Enums;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Tools
{
    public class CutTab : GridTabBase
    {
        private DropDownPropertyTabItem _cutTypeProperty;
        private DoublePropertyTabItem _heightProperty;

        public CutTab()
            : base(PropertyDescriptorsResources.TitleTabCut)
        {
            _cutTypes.Add("Through All");
            _cutTypes.Add("To Depth");
        }

        protected override void BuildInterface()
        {
            _heightProperty = new DoublePropertyTabItem();
            _heightProperty.OnSetValue += SetCutHeight;
            _heightProperty.OnGetValue += GetCutHeight;
            PropertyListGenerator.AddProperty("Depth", _heightProperty);

            _cutTypeProperty = new DropDownPropertyTabItem(_cutTypes);
            _cutTypeProperty.OnSetValue += SetCutType;
            _cutTypeProperty.OnGetValue += GetCutType;
            PropertyListGenerator.AddProperty("Type", _cutTypeProperty);
        }

        private void GetCutType(ref object resultvalue)
        {
            var value = (CutTypes) Builder[2].Integer;
            switch (value)
            {
                case CutTypes.ThroughAll:
                    resultvalue = 0;
                    break;
                case CutTypes.ToDepth:
                    resultvalue = 1;
                    break;
            }
        }

        private void SetCutType(object data)
        {
            BeginUpdate();
            var value = (int) data;
            var setValue = 0;
            switch (value)
            {
                case 0:
                    setValue = (int) CutTypes.ThroughAll;
                    break;
                case 1:
                    setValue = (int) CutTypes.ToDepth;
                    break;
            }
            Builder[2].Integer = setValue;
            EndVisualUpdate("Cut Type changed");
        }

        private void GetCutHeight(ref object resultvalue)
        {
            resultvalue = Builder[1].Real;
        }

        private void SetCutHeight(object data)
        {
            BeginUpdate();
            Builder[1].Real = (double) data;
            EndVisualUpdate("Cut Depth changed");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _heightProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _cutTypeProperty.SetTabOrder(tabIndex);
        }

        #region Data members

        private readonly List<string> _cutTypes = new List<string>();

        #endregion
    }
}