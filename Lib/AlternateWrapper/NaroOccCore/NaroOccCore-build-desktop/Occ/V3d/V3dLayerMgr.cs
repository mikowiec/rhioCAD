#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Visual3d;
using NaroCppCore.Occ.V3d;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dLayerMgr : MMgtTShared
	{
		public V3dLayerMgr(V3dView aView)
 :
			base(V3d_LayerMgr_Ctor36A6FAB7(aView.Instance) )
		{}
			public void ColorScaleDisplay()
				{
					V3d_LayerMgr_ColorScaleDisplay(Instance);
				}
			public void ColorScaleErase()
				{
					V3d_LayerMgr_ColorScaleErase(Instance);
				}
			public void Compute()
				{
					V3d_LayerMgr_Compute(Instance);
				}
			public void Resized()
				{
					V3d_LayerMgr_Resized(Instance);
				}
		public Visual3dLayer Overlay{
			get {
				return new Visual3dLayer(V3d_LayerMgr_Overlay(Instance));
			}
		}
		public V3dView View{
			get {
				return new V3dView(V3d_LayerMgr_View(Instance));
			}
		}
		public bool ColorScaleIsDisplayed{
			get {
				return V3d_LayerMgr_ColorScaleIsDisplayed(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_LayerMgr_Ctor36A6FAB7(IntPtr aView);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_LayerMgr_ColorScaleDisplay(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_LayerMgr_ColorScaleErase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_LayerMgr_Compute(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_LayerMgr_Resized(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_LayerMgr_Overlay(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_LayerMgr_View(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_LayerMgr_ColorScaleIsDisplayed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public V3dLayerMgr() { } 

		public V3dLayerMgr(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ V3dLayerMgr_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dLayerMgr_Dtor(IntPtr instance);
	}
}
