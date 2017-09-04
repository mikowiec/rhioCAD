#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectPixel : NativeInstancePtr
	{

		#region NativeInstancePtr Convert constructor

		public AspectPixel() { } 

		public AspectPixel(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectPixel_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectPixel_Dtor(IntPtr instance);
	}
}
