#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.PrsMgr;
using NaroCppCore.Occ.SelectMgr;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.SelectMgr
{
	public class SelectMgrSelectableObject : PrsMgrPresentableObject
	{
			public void UpdateSelection()
				{
					SelectMgr_SelectableObject_UpdateSelection(Instance);
				}
			public void UpdateSelection(int aMode)
				{
					SelectMgr_SelectableObject_UpdateSelectionE8219145(Instance, aMode);
				}
			public void AddSelection(SelectMgrSelection aSelection,int aMode)
				{
					SelectMgr_SelectableObject_AddSelection7C718F26(Instance, aSelection.Instance, aMode);
				}
			public void ClearSelections(bool update)
				{
					SelectMgr_SelectableObject_ClearSelections461FC46A(Instance, update);
				}
			public SelectMgrSelection Selection(int aMode)
				{
					return new SelectMgrSelection(SelectMgr_SelectableObject_SelectionE8219145(Instance, aMode));
				}
			public bool HasSelection(int aMode)
				{
					return SelectMgr_SelectableObject_HasSelectionE8219145(Instance, aMode);
				}
			public void Init()
				{
					SelectMgr_SelectableObject_Init(Instance);
				}
			public void Next()
				{
					SelectMgr_SelectableObject_Next(Instance);
				}
			public void ResetLocation()
				{
					SelectMgr_SelectableObject_ResetLocation(Instance);
				}
			public void UpdateLocation()
				{
					SelectMgr_SelectableObject_UpdateLocation(Instance);
				}
			public void ClearSelected()
				{
					SelectMgr_SelectableObject_ClearSelected(Instance);
				}
			public void HilightOwnerWithColor(PrsMgrPresentationManager3d thePM,QuantityNameOfColor theColor,SelectMgrEntityOwner theOwner)
				{
					SelectMgr_SelectableObject_HilightOwnerWithColor4EAE9125(Instance, thePM.Instance, (int)theColor, theOwner.Instance);
				}
			public void SetZLayer(PrsMgrPresentationManager thePrsMgr,int theLayerId)
				{
					SelectMgr_SelectableObject_SetZLayerC5F895E9(Instance, thePrsMgr.Instance, theLayerId);
				}
		public int NbPossibleSelection{
			get {
				return SelectMgr_SelectableObject_NbPossibleSelection(Instance);
			}
		}
		public bool More{
			get {
				return SelectMgr_SelectableObject_More(Instance);
			}
		}
		public SelectMgrSelection CurrentSelection{
			get {
				return new SelectMgrSelection(SelectMgr_SelectableObject_CurrentSelection(Instance));
			}
		}
		public bool IsAutoHilight{
			get {
				return SelectMgr_SelectableObject_IsAutoHilight(Instance);
			}
		}
		public bool AutoHilight{
			set { 
				SelectMgr_SelectableObject_SetAutoHilight(Instance, value);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_UpdateSelection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_UpdateSelectionE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_AddSelection7C718F26(IntPtr instance, IntPtr aSelection,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_ClearSelections461FC46A(IntPtr instance, bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_SelectableObject_SelectionE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_SelectableObject_HasSelectionE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_Init(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_ResetLocation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_UpdateLocation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_ClearSelected(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_HilightOwnerWithColor4EAE9125(IntPtr instance, IntPtr thePM,int theColor,IntPtr theOwner);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_SetZLayerC5F895E9(IntPtr instance, IntPtr thePrsMgr,int theLayerId);
		[DllImport("NaroOccCore.dll")]
		private static extern int SelectMgr_SelectableObject_NbPossibleSelection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_SelectableObject_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_SelectableObject_CurrentSelection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_SelectableObject_IsAutoHilight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_SelectableObject_SetAutoHilight(IntPtr instance, bool value);

		#region NativeInstancePtr Convert constructor

		public SelectMgrSelectableObject() { } 

		public SelectMgrSelectableObject(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ SelectMgrSelectableObject_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgrSelectableObject_Dtor(IntPtr instance);
	}
}
