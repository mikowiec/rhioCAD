#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.PrsMgr;

#endregion

namespace NaroCppCore.Occ.PrsMgr
{
	public class PrsMgrPresentation : MMgtTShared
	{
		public PrsMgrPresentationManager PresentationManager{
			get {
				return new PrsMgrPresentationManager(PrsMgr_Presentation_PresentationManager(Instance));
			}
		}
		public bool UpdateStatus{
			set { 
				PrsMgr_Presentation_SetUpdateStatus(Instance, value);
			}
		}
		public bool MustBeUpdated{
			get {
				return PrsMgr_Presentation_MustBeUpdated(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PrsMgr_Presentation_PresentationManager(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_Presentation_SetUpdateStatus(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PrsMgr_Presentation_MustBeUpdated(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public PrsMgrPresentation() { } 

		public PrsMgrPresentation(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ PrsMgrPresentation_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgrPresentation_Dtor(IntPtr instance);
	}
}
