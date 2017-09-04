#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectGraphicDevice : MMgtTShared
	{

		#region NativeInstancePtr Convert constructor

		public AspectGraphicDevice() { } 

		public AspectGraphicDevice(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectGraphicDevice_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectGraphicDevice_Dtor(IntPtr instance);
	}
}
