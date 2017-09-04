#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectGraphicDriver : MMgtTShared
	{

		#region NativeInstancePtr Convert constructor

		public AspectGraphicDriver() { } 

		public AspectGraphicDriver(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectGraphicDriver_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectGraphicDriver_Dtor(IntPtr instance);
	}
}
