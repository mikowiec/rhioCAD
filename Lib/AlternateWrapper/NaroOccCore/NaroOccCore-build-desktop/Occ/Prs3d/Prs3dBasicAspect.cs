#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Prs3d
{
	public class Prs3dBasicAspect : MMgtTShared
	{

		#region NativeInstancePtr Convert constructor

		public Prs3dBasicAspect() { } 

		public Prs3dBasicAspect(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs3dBasicAspect_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3dBasicAspect_Dtor(IntPtr instance);
	}
}
