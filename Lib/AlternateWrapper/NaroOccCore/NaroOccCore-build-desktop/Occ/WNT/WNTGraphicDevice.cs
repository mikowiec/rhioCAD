#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.WNT
{
	public class WNTGraphicDevice : AspectGraphicDevice
	{
		public WNTGraphicDevice(bool aColorCube,IntPtr aDevContext)
 :
			base(WNT_GraphicDevice_Ctor5C28B6AA(aColorCube, aDevContext) )
		{}
		public WNTGraphicDevice(bool aColorCube,int aDevContext)
 :
			base(WNT_GraphicDevice_CtorD4631C92(aColorCube, aDevContext) )
		{}
			public void DisplaySize(ref int aWidth,ref int aHeight)
				{
					WNT_GraphicDevice_DisplaySize5107F6FE(Instance, ref aWidth, ref aHeight);
				}
			public void DisplaySize(ref double aWidth,ref double aHeight)
				{
					WNT_GraphicDevice_DisplaySize9F0E714F(Instance, ref aWidth, ref aHeight);
				}
		public IntPtr HPalette{
			get {
				return WNT_GraphicDevice_HPalette(Instance);
			}
		}
		public bool IsPaletteDevice{
			get {
				return WNT_GraphicDevice_IsPaletteDevice(Instance);
			}
		}
		public int NumColors{
			get {
				return WNT_GraphicDevice_NumColors(Instance);
			}
		}
		public AspectGraphicDriver GraphicDriver{
			get {
				return new AspectGraphicDriver(WNT_GraphicDevice_GraphicDriver(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr WNT_GraphicDevice_Ctor5C28B6AA(bool aColorCube,IntPtr aDevContext);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr WNT_GraphicDevice_CtorD4631C92(bool aColorCube,int aDevContext);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_GraphicDevice_DisplaySize5107F6FE(IntPtr instance, ref int aWidth,ref int aHeight);
		[DllImport("NaroOccCore.dll")]
		private static extern void WNT_GraphicDevice_DisplaySize9F0E714F(IntPtr instance, ref double aWidth,ref double aHeight);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr WNT_GraphicDevice_HPalette(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool WNT_GraphicDevice_IsPaletteDevice(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int WNT_GraphicDevice_NumColors(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr WNT_GraphicDevice_GraphicDriver(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public WNTGraphicDevice() { } 

		public WNTGraphicDevice(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ WNTGraphicDevice_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void WNTGraphicDevice_Dtor(IntPtr instance);
	}
}
