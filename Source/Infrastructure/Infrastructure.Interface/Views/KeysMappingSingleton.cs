#region Usings

using System.Windows.Input;
using NaroCppCore.Occ.V3d;


#endregion

namespace Naro.Infrastructure.Interface.Views
{
    public sealed class KeysMappingSingleton
    {
        private static readonly KeysMappingSingleton InternalInstance = new KeysMappingSingleton();

        private KeysMappingSingleton()
        {
        }

        public static KeysMappingSingleton Instance
        {
            get { return InternalInstance; }
        }

        public bool IsShiftDown { get; private set; }
        public bool IsControlDown { get; private set; }

        public V3dView CurrentView { get; private set; }
        public int MouseX { get; private set; }
        public int MouseY { get; private set; }
        public bool MouseDown { get; private set; }

        public void UpdateView(V3dView currentView)
        {
            CurrentView = currentView;
        }

        public void UpdateMouse(int mouseX, int mouseY, bool mouseDown)
        {
            MouseX = mouseX;
            MouseY = mouseY;
            MouseDown = mouseDown;
        }

        public void UpdateKeys(KeyEventArgs eventArgs)
        {
            IsControlDown = (eventArgs.KeyboardDevice.Modifiers & ModifierKeys.Control) != 0;
            IsShiftDown = (eventArgs.KeyboardDevice.Modifiers & ModifierKeys.Shift) != 0;
        }
    }
}