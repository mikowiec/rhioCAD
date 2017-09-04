#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Prs3d
{
    public class Prs3dCompositeAspect : MMgtTShared
	{

		#region NativeInstancePtr Convert constructor

		public Prs3dCompositeAspect() { } 

		public Prs3dCompositeAspect(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs3dCompositeAspect_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3dCompositeAspect_Dtor(IntPtr instance);
	}
}
