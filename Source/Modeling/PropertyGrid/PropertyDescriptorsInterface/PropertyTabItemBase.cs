#region Usings

using System.Windows.Controls;

#endregion

namespace PropertyDescriptorsInterface
{
    public abstract class PropertyTabItemBase
    {
        #region Delegates

        public delegate void OnDelegateSetup(object data);

        public delegate void OnValueGet(ref object resultValue);

        #endregion

        public OnValueGet OnGetValue;

        public OnDelegateSetup OnSetValue;
        public string Name { get; set; }
        public abstract void FillControlEvents(DockPanel parentControl);
        public abstract void Focus();
    }
}