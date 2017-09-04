#region Usings

using ZetaColorEditor.Runtime;

#endregion

namespace PropertyGridTabItems
{
    public class ColorPickerSingleton
    {
        private static readonly ColorPickerSingleton SingletonInstance = new ColorPickerSingleton();

        public ColorEditorForm Form;

        private ColorPickerSingleton()
        {
        }

        public static ColorPickerSingleton Instance
        {
            get
            {
                SingletonInstance.RefreshForm();
                return SingletonInstance;
            }
        }

        public void RefreshForm()
        {
            if (Form == null) Form = new ColorEditorForm();
        }
    }
}