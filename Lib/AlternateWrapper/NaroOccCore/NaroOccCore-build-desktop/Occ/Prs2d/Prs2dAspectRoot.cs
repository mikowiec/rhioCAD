#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Prs2d;

#endregion

namespace NaroCppCore.Occ.Prs2d
{
	public class Prs2dAspectRoot : MMgtTShared
	{
		public Prs2dAspectName GetAspectName{
			get {
				return (Prs2dAspectName)Prs2d_AspectRoot_GetAspectName(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern int Prs2d_AspectRoot_GetAspectName(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Prs2dAspectRoot() { } 

		public Prs2dAspectRoot(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs2dAspectRoot_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs2dAspectRoot_Dtor(IntPtr instance);
	}
}
