#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectWindow : MMgtTShared
	{
		public AspectBackground Background{
			get {
				return new AspectBackground(Aspect_Window_Background(Instance));
			}
		}
		public string BackgroundImage{
			get {
				return Aspect_Window_BackgroundImage(Instance);
			}
		}
		public AspectFillMethod BackgroundFillMethod{
			get {
				return (AspectFillMethod)Aspect_Window_BackgroundFillMethod(Instance);
			}
		}
		public IntPtr HBackground{
			get {
				return Aspect_Window_HBackground(Instance);
			}
		}
		public AspectGraphicDevice GraphicDevice{
			get {
				return new AspectGraphicDevice(Aspect_Window_GraphicDevice(Instance));
			}
		}
		public bool IsVirtual{
			get {
				return Aspect_Window_IsVirtual(Instance);
			}
		}
		public bool Virtual{
			set { 
				Aspect_Window_SetVirtual(Instance, value);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_Window_Background(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Aspect_Window_BackgroundImage(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_Window_BackgroundFillMethod(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_Window_HBackground(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_Window_GraphicDevice(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Aspect_Window_IsVirtual(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_Window_SetVirtual(IntPtr instance, bool value);

		#region NativeInstancePtr Convert constructor

		public AspectWindow() { } 

		public AspectWindow(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectWindow_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectWindow_Dtor(IntPtr instance);
	}
}
