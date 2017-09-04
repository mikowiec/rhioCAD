#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.WNT;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dWNTGraphicDevice : WNTGraphicDevice
	{
		public Graphic3dWNTGraphicDevice()
 :
			base(Graphic3d_WNTGraphicDevice_Ctor() )
		{}
		public Graphic3dWNTGraphicDevice(string graphicLib)
 :
			base(Graphic3d_WNTGraphicDevice_Ctor9381D4D(graphicLib) )
		{}
		public AspectGraphicDriver GraphicDriver{
			get {
				return new AspectGraphicDriver(Graphic3d_WNTGraphicDevice_GraphicDriver(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_WNTGraphicDevice_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_WNTGraphicDevice_Ctor9381D4D(string graphicLib);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_WNTGraphicDevice_GraphicDriver(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dWNTGraphicDevice(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dWNTGraphicDevice_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dWNTGraphicDevice_Dtor(IntPtr instance);
	}
}
