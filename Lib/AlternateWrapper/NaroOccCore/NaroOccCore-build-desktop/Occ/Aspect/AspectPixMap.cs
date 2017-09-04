#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectPixMap : MMgtTShared
	{
			public void Size(ref int aWidth,ref int anHeight)
				{
					Aspect_PixMap_Size5107F6FE(Instance, ref aWidth, ref anHeight);
				}
		public int Depth{
			get {
				return Aspect_PixMap_Depth(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Aspect_PixMap_Size5107F6FE(IntPtr instance, ref int aWidth,ref int anHeight);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_PixMap_Depth(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectPixMap() { } 

		public AspectPixMap(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectPixMap_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectPixMap_Dtor(IntPtr instance);
	}
}
