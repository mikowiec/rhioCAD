#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dLayerItem : MMgtTShared
	{
		public Visual3dLayerItem()
 :
			base(Visual3d_LayerItem_Ctor() )
		{}
			public void ComputeLayerPrs()
				{
					Visual3d_LayerItem_ComputeLayerPrs(Instance);
				}
			public void RedrawLayerPrs()
				{
					Visual3d_LayerItem_RedrawLayerPrs(Instance);
				}
		public bool IsNeedToRecompute{
			get {
				return Visual3d_LayerItem_IsNeedToRecompute(Instance);
			}
		}
		public bool NeedToRecompute{
			set { 
				Visual3d_LayerItem_SetNeedToRecompute(Instance, value);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_LayerItem_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_LayerItem_ComputeLayerPrs(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_LayerItem_RedrawLayerPrs(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_LayerItem_IsNeedToRecompute(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_LayerItem_SetNeedToRecompute(IntPtr instance, bool value);

		#region NativeInstancePtr Convert constructor

		public Visual3dLayerItem(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dLayerItem_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dLayerItem_Dtor(IntPtr instance);
	}
}
