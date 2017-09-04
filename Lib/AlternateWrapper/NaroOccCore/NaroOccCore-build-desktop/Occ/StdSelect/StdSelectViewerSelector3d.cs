#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.SelectMgr;
using NaroCppCore.Occ.StdSelect;
using NaroCppCore.Occ.V3d;

#endregion

namespace NaroCppCore.Occ.StdSelect
{
	public class StdSelectViewerSelector3d : SelectMgrViewerSelector
	{
		public StdSelectViewerSelector3d()
 :
			base(StdSelect_ViewerSelector3d_Ctor() )
		{}
			public void Convert(SelectMgrSelection aSelection)
				{
					StdSelect_ViewerSelector3d_ConvertD1B6659F(Instance, aSelection.Instance);
				}
			public void Pick(int XPix,int YPix,V3dView aView)
				{
					StdSelect_ViewerSelector3d_Pick556D776C(Instance, XPix, YPix, aView.Instance);
				}
			public void Pick(int XPMin,int YPMin,int XPMax,int YPMax,V3dView aView)
				{
					StdSelect_ViewerSelector3d_Pick12E48EEC(Instance, XPMin, YPMin, XPMax, YPMax, aView.Instance);
				}
			public void ReactivateProjector()
				{
					StdSelect_ViewerSelector3d_ReactivateProjector(Instance);
				}
			public void DisplayAreas(V3dView aView)
				{
					StdSelect_ViewerSelector3d_DisplayAreas36A6FAB7(Instance, aView.Instance);
				}
			public void ClearAreas(V3dView aView)
				{
					StdSelect_ViewerSelector3d_ClearAreas36A6FAB7(Instance, aView.Instance);
				}
			public void DisplaySensitive(V3dView aView)
				{
					StdSelect_ViewerSelector3d_DisplaySensitive36A6FAB7(Instance, aView.Instance);
				}
			public void ClearSensitive(V3dView aView)
				{
					StdSelect_ViewerSelector3d_ClearSensitive36A6FAB7(Instance, aView.Instance);
				}
			public void DisplaySensitive(SelectMgrSelection aSel,V3dView aView,bool ClearOthers)
				{
					StdSelect_ViewerSelector3d_DisplaySensitiveE07C6821(Instance, aSel.Instance, aView.Instance, ClearOthers);
				}
			public void DisplayAreas(SelectMgrSelection aSel,V3dView aView,bool ClearOthers)
				{
					StdSelect_ViewerSelector3d_DisplayAreasE07C6821(Instance, aSel.Instance, aView.Instance, ClearOthers);
				}
		public StdSelectSensitivityMode SensitivityMode{
			set { 
				StdSelect_ViewerSelector3d_SetSensitivityMode(Instance, (int)value);
			}
			get {
				return (StdSelectSensitivityMode)StdSelect_ViewerSelector3d_SensitivityMode(Instance);
			}
		}
		public int PixelTolerance{
			set { 
				StdSelect_ViewerSelector3d_SetPixelTolerance(Instance, value);
			}
			get {
				return StdSelect_ViewerSelector3d_PixelTolerance(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StdSelect_ViewerSelector3d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_ConvertD1B6659F(IntPtr instance, IntPtr aSelection);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_Pick556D776C(IntPtr instance, int XPix,int YPix,IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_Pick12E48EEC(IntPtr instance, int XPMin,int YPMin,int XPMax,int YPMax,IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_ReactivateProjector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_DisplayAreas36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_ClearAreas36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_DisplaySensitive36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_ClearSensitive36A6FAB7(IntPtr instance, IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_DisplaySensitiveE07C6821(IntPtr instance, IntPtr aSel,IntPtr aView,bool ClearOthers);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_DisplayAreasE07C6821(IntPtr instance, IntPtr aSel,IntPtr aView,bool ClearOthers);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_SetSensitivityMode(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int StdSelect_ViewerSelector3d_SensitivityMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelect_ViewerSelector3d_SetPixelTolerance(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int StdSelect_ViewerSelector3d_PixelTolerance(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public StdSelectViewerSelector3d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StdSelectViewerSelector3d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StdSelectViewerSelector3d_Dtor(IntPtr instance);
	}
}
