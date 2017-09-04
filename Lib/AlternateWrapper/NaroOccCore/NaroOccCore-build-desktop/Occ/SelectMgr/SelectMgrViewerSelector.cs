#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.SelectMgr;
using NaroCppCore.Occ.Bnd;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.SelectBasics;

#endregion

namespace NaroCppCore.Occ.SelectMgr
{
	public class SelectMgrViewerSelector : MMgtTShared
	{
			public void Convert(SelectMgrSelection aSelection)
				{
					SelectMgr_ViewerSelector_ConvertD1B6659F(Instance, aSelection.Instance);
				}
			public void Clear()
				{
					SelectMgr_ViewerSelector_Clear(Instance);
				}
			public void UpdateConversion()
				{
					SelectMgr_ViewerSelector_UpdateConversion(Instance);
				}
			public void SetClipping(double Xc,double Yc,double Height,double Width)
				{
					SelectMgr_ViewerSelector_SetClippingC2777E0C(Instance, Xc, Yc, Height, Width);
				}
			public void SetClipping(BndBox2d aRectangle)
				{
					SelectMgr_ViewerSelector_SetClipping5D98465D(Instance, aRectangle.Instance);
				}
			public void InitSelect(double Xr,double Yr)
				{
					SelectMgr_ViewerSelector_InitSelect9F0E714F(Instance, Xr, Yr);
				}
			public void InitSelect(BndBox2d aRect)
				{
					SelectMgr_ViewerSelector_InitSelect5D98465D(Instance, aRect.Instance);
				}
			public void InitSelect(double Xmin,double Ymin,double Xmax,double Ymax)
				{
					SelectMgr_ViewerSelector_InitSelectC2777E0C(Instance, Xmin, Ymin, Xmax, Ymax);
				}
			public void SortResult()
				{
					SelectMgr_ViewerSelector_SortResult(Instance);
				}
			public void Init()
				{
					SelectMgr_ViewerSelector_Init(Instance);
				}
			public void Next()
				{
					SelectMgr_ViewerSelector_Next(Instance);
				}
			public SelectMgrEntityOwner Picked()
				{
					return new SelectMgrEntityOwner(SelectMgr_ViewerSelector_Picked(Instance));
				}
			public SelectMgrEntityOwner Picked(int aRank)
				{
					return new SelectMgrEntityOwner(SelectMgr_ViewerSelector_PickedE8219145(Instance, aRank));
				}
			public void LastPosition(ref double Xr,ref double Yr)
				{
					SelectMgr_ViewerSelector_LastPosition9F0E714F(Instance, ref Xr, ref Yr);
				}
			public bool Contains(SelectMgrSelectableObject aSelectableObject)
				{
					return SelectMgr_ViewerSelector_ContainsCB355689(Instance, aSelectableObject.Instance);
				}
			public bool IsActive(SelectMgrSelectableObject aSelectableObject,int aMode)
				{
					return SelectMgr_ViewerSelector_IsActiveC6B3194D(Instance, aSelectableObject.Instance, aMode);
				}
			public bool IsInside(SelectMgrSelectableObject aSelectableObject,int aMode)
				{
					return SelectMgr_ViewerSelector_IsInsideC6B3194D(Instance, aSelectableObject.Instance, aMode);
				}
			public SelectMgrStateOfSelection Status(SelectMgrSelection aSelection)
				{
					return (SelectMgrStateOfSelection)SelectMgr_ViewerSelector_StatusD1B6659F(Instance, aSelection.Instance);
				}
			public TCollectionAsciiString Status(SelectMgrSelectableObject aSelectableObject)
				{
					return new TCollectionAsciiString(SelectMgr_ViewerSelector_StatusCB355689(Instance, aSelectableObject.Instance));
				}
			public TCollectionAsciiString Status()
				{
					return new TCollectionAsciiString(SelectMgr_ViewerSelector_Status(Instance));
				}
			public void UpdateSort()
				{
					SelectMgr_ViewerSelector_UpdateSort(Instance);
				}
			public SelectBasicsSensitiveEntity Primitive(int Rank)
				{
					return new SelectBasicsSensitiveEntity(SelectMgr_ViewerSelector_PrimitiveE8219145(Instance, Rank));
				}
		public double Sensitivity{
			set { 
				SelectMgr_ViewerSelector_SetSensitivity(Instance, value);
			}
			get {
				return SelectMgr_ViewerSelector_Sensitivity(Instance);
			}
		}
		public bool More{
			get {
				return SelectMgr_ViewerSelector_More(Instance);
			}
		}
		public SelectMgrEntityOwner OnePicked{
			get {
				return new SelectMgrEntityOwner(SelectMgr_ViewerSelector_OnePicked(Instance));
			}
		}
		public bool PickClosest{
			set { 
				SelectMgr_ViewerSelector_SetPickClosest(Instance, value);
			}
		}
		public int NbPicked{
			get {
				return SelectMgr_ViewerSelector_NbPicked(Instance);
			}
		}
		public bool HasStored{
			get {
				return SelectMgr_ViewerSelector_HasStored(Instance);
			}
		}
		public bool UpdateSortPossible{
			set { 
				SelectMgr_ViewerSelector_SetUpdateSortPossible(Instance, value);
			}
		}
		public bool IsUpdateSortPossible{
			get {
				return SelectMgr_ViewerSelector_IsUpdateSortPossible(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_ConvertD1B6659F(IntPtr instance, IntPtr aSelection);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_UpdateConversion(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_SetClippingC2777E0C(IntPtr instance, double Xc,double Yc,double Height,double Width);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_SetClipping5D98465D(IntPtr instance, IntPtr aRectangle);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_InitSelect9F0E714F(IntPtr instance, double Xr,double Yr);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_InitSelect5D98465D(IntPtr instance, IntPtr aRect);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_InitSelectC2777E0C(IntPtr instance, double Xmin,double Ymin,double Xmax,double Ymax);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_SortResult(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_Init(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_ViewerSelector_Picked(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_ViewerSelector_PickedE8219145(IntPtr instance, int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_LastPosition9F0E714F(IntPtr instance, ref double Xr,ref double Yr);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_ViewerSelector_ContainsCB355689(IntPtr instance, IntPtr aSelectableObject);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_ViewerSelector_IsActiveC6B3194D(IntPtr instance, IntPtr aSelectableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_ViewerSelector_IsInsideC6B3194D(IntPtr instance, IntPtr aSelectableObject,int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern int SelectMgr_ViewerSelector_StatusD1B6659F(IntPtr instance, IntPtr aSelection);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_ViewerSelector_StatusCB355689(IntPtr instance, IntPtr aSelectableObject);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_ViewerSelector_Status(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_UpdateSort(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_ViewerSelector_PrimitiveE8219145(IntPtr instance, int Rank);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_SetSensitivity(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double SelectMgr_ViewerSelector_Sensitivity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_ViewerSelector_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectMgr_ViewerSelector_OnePicked(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_SetPickClosest(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern int SelectMgr_ViewerSelector_NbPicked(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_ViewerSelector_HasStored(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgr_ViewerSelector_SetUpdateSortPossible(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_ViewerSelector_IsUpdateSortPossible(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public SelectMgrViewerSelector() { } 

		public SelectMgrViewerSelector(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ SelectMgrViewerSelector_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgrViewerSelector_Dtor(IntPtr instance);
	}
}
