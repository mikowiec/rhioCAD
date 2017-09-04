#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.PrsMgr;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopLoc;

#endregion

namespace NaroCppCore.Occ.PrsMgr
{
	public class PrsMgrPresentableObject : MMgtTShared
	{
			public void SetToUpdate(int aMode)
				{
					PrsMgr_PresentableObject_SetToUpdateE8219145(Instance, aMode);
				}
			public void SetToUpdate()
				{
					PrsMgr_PresentableObject_SetToUpdate(Instance);
				}
			public void ResetLocation()
				{
					PrsMgr_PresentableObject_ResetLocation(Instance);
				}
			public void UpdateLocation()
				{
					PrsMgr_PresentableObject_UpdateLocation(Instance);
				}
			public void SetZLayer(PrsMgrPresentationManager thePrsMgr,int theLayerId)
				{
					PrsMgr_PresentableObject_SetZLayerC5F895E9(Instance, thePrsMgr.Instance, theLayerId);
				}
			public int GetZLayer(PrsMgrPresentationManager thePrsMgr)
				{
					return PrsMgr_PresentableObject_GetZLayer56269ED1(Instance, thePrsMgr.Instance);
				}
		public PrsMgrTypeOfPresentation3d TypeOfPresentation3d{
			get {
				return (PrsMgrTypeOfPresentation3d)PrsMgr_PresentableObject_TypeOfPresentation3d(Instance);
			}
		}
		public gpPnt GetTransformPersistencePoint{
			get {
				return new gpPnt(PrsMgr_PresentableObject_GetTransformPersistencePoint(Instance));
			}
		}
		public PrsMgrTypeOfPresentation3d TypeOfPresentation{
			set { 
				PrsMgr_PresentableObject_SetTypeOfPresentation(Instance, (int)value);
			}
		}
		public bool HasLocation{
			get {
				return PrsMgr_PresentableObject_HasLocation(Instance);
			}
		}
		public TopLocLocation Location{
			set { 
				PrsMgr_PresentableObject_SetLocation(Instance, value.Instance);
			}
			get {
				return new TopLocLocation(PrsMgr_PresentableObject_Location(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentableObject_SetToUpdateE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentableObject_SetToUpdate(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentableObject_ResetLocation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentableObject_UpdateLocation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentableObject_SetZLayerC5F895E9(IntPtr instance, IntPtr thePrsMgr,int theLayerId);
		[DllImport("NaroOccCore.dll")]
		private static extern int PrsMgr_PresentableObject_GetZLayer56269ED1(IntPtr instance, IntPtr thePrsMgr);
		[DllImport("NaroOccCore.dll")]
		private static extern int PrsMgr_PresentableObject_TypeOfPresentation3d(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PrsMgr_PresentableObject_GetTransformPersistencePoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentableObject_SetTypeOfPresentation(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PrsMgr_PresentableObject_HasLocation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgr_PresentableObject_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PrsMgr_PresentableObject_Location(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public PrsMgrPresentableObject() { } 

		public PrsMgrPresentableObject(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ PrsMgrPresentableObject_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void PrsMgrPresentableObject_Dtor(IntPtr instance);
	}
}
