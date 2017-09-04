#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dPlane : MMgtTShared
	{
		public V3dPlane(double A,double B,double C,double D)
 :
			base(V3d_Plane_CtorC2777E0C(A, B, C, D) )
		{}
			public void SetPlane(double A,double B,double C,double D)
				{
					V3d_Plane_SetPlaneC2777E0C(Instance, A, B, C, D);
				}
			public void Display(V3dView aView,QuantityColor aColor)
				{
					V3d_Plane_Display8A383826(Instance, aView.Instance, aColor.Instance);
				}
			public void Erase()
				{
					V3d_Plane_Erase(Instance);
				}
			public void Plane(ref double A,ref double B,ref double C,ref double D)
				{
					V3d_Plane_PlaneC2777E0C(Instance, ref A, ref B, ref C, ref D);
				}
		public bool IsDisplayed{
			get {
				return V3d_Plane_IsDisplayed(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Plane_CtorC2777E0C(double A,double B,double C,double D);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Plane_SetPlaneC2777E0C(IntPtr instance, double A,double B,double C,double D);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Plane_Display8A383826(IntPtr instance, IntPtr aView,IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Plane_Erase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Plane_PlaneC2777E0C(IntPtr instance, ref double A,ref double B,ref double C,ref double D);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Plane_IsDisplayed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public V3dPlane() { } 

		public V3dPlane(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ V3dPlane_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dPlane_Dtor(IntPtr instance);
	}
}
