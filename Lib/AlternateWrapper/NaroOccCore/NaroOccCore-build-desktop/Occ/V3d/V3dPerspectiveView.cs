#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.V3d;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dPerspectiveView : V3dView
	{
		public V3dPerspectiveView(V3dViewer VM)
 :
			base(V3d_PerspectiveView_Ctor79560492(VM.Instance) )
		{}
		public V3dPerspectiveView(V3dViewer VM,V3dOrthographicView V)
 :
			base(V3d_PerspectiveView_Ctor4E6B6F5D(VM.Instance, V.Instance) )
		{}
		public V3dPerspectiveView(V3dViewer VM,V3dPerspectiveView V)
 :
			base(V3d_PerspectiveView_Ctor4B0A5FC8(VM.Instance, V.Instance) )
		{}
			public void SetPerspective(double Angle,double UVRatio,double ZNear,double ZFar)
				{
					V3d_PerspectiveView_SetPerspectiveC2777E0C(Instance, Angle, UVRatio, ZNear, ZFar);
				}
		public V3dPerspectiveView Copy{
			get {
				return new V3dPerspectiveView(V3d_PerspectiveView_Copy(Instance));
			}
		}
		public double Angle{
			set { 
				V3d_PerspectiveView_SetAngle(Instance, value);
			}
			get {
				return V3d_PerspectiveView_Angle(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_PerspectiveView_Ctor79560492(IntPtr VM);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_PerspectiveView_Ctor4E6B6F5D(IntPtr VM,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_PerspectiveView_Ctor4B0A5FC8(IntPtr VM,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PerspectiveView_SetPerspectiveC2777E0C(IntPtr instance, double Angle,double UVRatio,double ZNear,double ZFar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_PerspectiveView_Copy(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_PerspectiveView_SetAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_PerspectiveView_Angle(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public V3dPerspectiveView() { } 

		public V3dPerspectiveView(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ V3dPerspectiveView_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dPerspectiveView_Dtor(IntPtr instance);
	}
}
