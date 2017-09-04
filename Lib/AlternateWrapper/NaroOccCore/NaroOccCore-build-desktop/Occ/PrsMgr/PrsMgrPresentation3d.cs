#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.PrsMgr;

#endregion

namespace NaroCppCore.Occ.PrsMgr
{
	public class PrsMgrPresentation3d : PrsMgrPresentation
	{
		public PrsMgrKindOfPrs KindOfPresentation{
			get {
				return (PrsMgrKindOfPrs)PrsMgr_Presentation3d_KindOfPresentation(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern int PrsMgr_Presentation3d_KindOfPresentation(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public PrsMgrPresentation3d() { } 

		public PrsMgrPresentation3d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ PrsMgrPresentation3d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgrPresentation3d_Dtor(IntPtr instance);
	}
}
