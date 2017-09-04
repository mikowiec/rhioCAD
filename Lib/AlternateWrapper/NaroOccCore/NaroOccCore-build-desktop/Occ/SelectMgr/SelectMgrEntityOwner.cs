#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.SelectBasics;
using NaroCppCore.Occ.SelectMgr;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.PrsMgr;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.SelectMgr
{
	public class SelectMgrEntityOwner : SelectBasicsEntityOwner
	{
		public SelectMgrEntityOwner(int aPriority)
 :
			base(SelectMgr_EntityOwner_CtorE8219145(aPriority) )
		{}
		public SelectMgrEntityOwner(SelectMgrSelectableObject aSO,int aPriority)
 :
			base(SelectMgr_EntityOwner_CtorC6B3194D(aSO.Instance, aPriority) )
		{}
			public void Set(SelectMgrSelectableObject aSO)
				{
					SelectMgr_EntityOwner_SetCB355689(Instance, aSO.Instance);
				}
			public void Hilight()
				{
					SelectMgr_EntityOwner_Hilight(Instance);
				}
			public bool IsHilighted(PrsMgrPresentationManager aPM,int aMode)
				{
					return SelectMgr_EntityOwner_IsHilightedC5F895E9(Instance, aPM.Instance, aMode);
				}
			public void Hilight(PrsMgrPresentationManager aPM,int aMode)
				{
					SelectMgr_EntityOwner_HilightC5F895E9(Instance, aPM.Instance, aMode);
				}
			public void HilightWithColor(PrsMgrPresentationManager3d aPM,QuantityNameOfColor aColor,int aMode)
				{
					SelectMgr_EntityOwner_HilightWithColor1D9F4508(Instance, aPM.Instance, (int)aColor, aMode);
				}
			public void Unhilight(PrsMgrPresentationManager aPM,int aMode)
				{
					SelectMgr_EntityOwner_UnhilightC5F895E9(Instance, aPM.Instance, aMode);
				}
			public void Clear(PrsMgrPresentationManager aPM,int aMode)
				{
					SelectMgr_EntityOwner_ClearC5F895E9(Instance, aPM.Instance, aMode);
				}
			public void ResetLocation()
				{
					SelectMgr_EntityOwner_ResetLocation(Instance);
				}
			public void State(int aStatus)
				{
					SelectMgr_EntityOwner_StateE8219145(Instance, aStatus);
				}
			public int State()
				{
					return SelectMgr_EntityOwner_State(Instance);
				}
			public void SetZLayer(PrsMgrPresentationManager thePrsMgr,int theLayerId)
				{
					SelectMgr_EntityOwner_SetZLayerC5F895E9(Instance, thePrsMgr.Instance, theLayerId);
				}
		public bool HasSelectable{
			get {
				return SelectMgr_EntityOwner_HasSelectable(Instance);
			}
		}
		public SelectMgrSelectableObject Selectable{
			get {
				return new SelectMgrSelectableObject(SelectMgr_EntityOwner_Selectable(Instance));
			}
		}
		public bool HasLocation{
			get {
				return SelectMgr_EntityOwner_HasLocation(Instance);
			}
		}
		public TopLocLocation Location{
			set { 
				SelectMgr_EntityOwner_SetLocation(Instance, value.Instance);
			}
			get {
				return new TopLocLocation(SelectMgr_EntityOwner_Location(Instance));
			}
		}
		public bool IsAutoHilight{
			get {
				return SelectMgr_EntityOwner_IsAutoHilight(Instance);
			}
		}
		public bool IsForcedHilight{
			get {
				return SelectMgr_EntityOwner_IsForcedHilight(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_EntityOwner_CtorE8219145(int aPriority);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_EntityOwner_CtorC6B3194D(IntPtr aSO,int aPriority);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_SetCB355689(IntPtr instance, IntPtr aSO);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_Hilight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_EntityOwner_IsHilightedC5F895E9(IntPtr instance, IntPtr aPM,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_HilightC5F895E9(IntPtr instance, IntPtr aPM,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_HilightWithColor1D9F4508(IntPtr instance, IntPtr aPM,int aColor,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_UnhilightC5F895E9(IntPtr instance, IntPtr aPM,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_ClearC5F895E9(IntPtr instance, IntPtr aPM,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_ResetLocation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_StateE8219145(IntPtr instance, int aStatus);
		[DllImport("NaroOccCore.dll")]
		private static extern int SelectMgr_EntityOwner_State(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_SetZLayerC5F895E9(IntPtr instance, IntPtr thePrsMgr,int theLayerId);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_EntityOwner_HasSelectable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_EntityOwner_Selectable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_EntityOwner_HasLocation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_EntityOwner_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_EntityOwner_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_EntityOwner_IsAutoHilight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_EntityOwner_IsForcedHilight(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public SelectMgrEntityOwner() { } 

		public SelectMgrEntityOwner(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ SelectMgrEntityOwner_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgrEntityOwner_Dtor(IntPtr instance);
	}
}
