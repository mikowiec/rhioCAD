#region Usings

using System.Collections.Generic;
using NaroConstants.Names;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Utils;

#endregion

namespace PropertyGridTabs.ShapeTabs.Tools
{
    /// <summary>
    ///   Description of ExtrudeTab.
    /// </summary>
    public class ExtrudeTab : GridTabBase
    {
        private DropDownPropertyTabItem _extrudeTypeProperty;
        private DoublePropertyTabItem _heightProperty;

        public ExtrudeTab()
            : base(PropertyDescriptorsResources.TitleTabExtrude)
        {
            _extrudeTypes.Add("To Depth");
            _extrudeTypes.Add("Mid Plane");
        }

        protected override void BuildInterface()
        {
            _heightProperty = new DoublePropertyTabItem();
            _heightProperty.OnSetValue += SetInternalRadius;
            _heightProperty.OnGetValue += GetInternalRadius;

            PropertyListGenerator.AddProperty("Depth", _heightProperty);

            _extrudeTypeProperty = new DropDownPropertyTabItem(_extrudeTypes);
            _extrudeTypeProperty.OnSetValue += SetExtrudeType;
            _extrudeTypeProperty.OnGetValue += GetExtrudeType;
            PropertyListGenerator.AddProperty("Type", _extrudeTypeProperty);
        }

        private void GetExtrudeType(ref object resultvalue)
        {
            resultvalue = Builder[1].Integer;
        }

        private void SetExtrudeType(object data)
        {
     //       BeginUpdate();
            Builder[1].Integer = (int) data;
          //  EndVisualUpdate("Depth type changed");
        }


        private void GetInternalRadius(ref object resultvalue)
        {
            resultvalue = Builder[2].Real;
        }

        private void SetInternalRadius(object data)
        {
            BeginUpdate();
            Builder[2].Real = (double) data;
            NodeBuilderUtils.UpdateSketchesOnFaces(Builder);

            EndVisualUpdate("Extrude depth changed");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _heightProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _extrudeTypeProperty.SetTabOrder(tabIndex);
        }

        #region Data members

        private readonly List<string> _extrudeTypes = new List<string>();

        #endregion
    }
}