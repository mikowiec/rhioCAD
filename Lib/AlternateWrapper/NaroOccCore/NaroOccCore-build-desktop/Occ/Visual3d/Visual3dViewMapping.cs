#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Visual3d;
using NaroCppCore.Occ.Graphic3d;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dViewMapping : NativeInstancePtr
	{
		public Visual3dViewMapping()
 :
			base(Visual3d_ViewMapping_Ctor() )
		{}
		public Visual3dViewMapping(Visual3dTypeOfProjection AType,Graphic3dVertex PRP,double BPD,double FPD,double VPD,double WUmin,double WVmin,double WUmax,double WVmax)
 :
			base(Visual3d_ViewMapping_Ctor65BCDE62((int)AType, PRP.Instance, BPD, FPD, VPD, WUmin, WVmin, WUmax, WVmax) )
		{}
			public void SetWindowLimit(double Umin,double Vmin,double Umax,double Vmax)
				{
					Visual3d_ViewMapping_SetWindowLimitC2777E0C(Instance, Umin, Vmin, Umax, Vmax);
				}
			public void WindowLimit(ref double Umin,ref double Vmin,ref double Umax,ref double Vmax)
				{
					Visual3d_ViewMapping_WindowLimitC2777E0C(Instance, ref Umin, ref Vmin, ref Umax, ref Vmax);
				}
		public double BackPlaneDistance{
			set { 
				Visual3d_ViewMapping_SetBackPlaneDistance(Instance, value);
			}
			get {
				return Visual3d_ViewMapping_BackPlaneDistance(Instance);
			}
		}
		public double FrontPlaneDistance{
			set { 
				Visual3d_ViewMapping_SetFrontPlaneDistance(Instance, value);
			}
			get {
				return Visual3d_ViewMapping_FrontPlaneDistance(Instance);
			}
		}
		public Visual3dTypeOfProjection Projection{
			set { 
				Visual3d_ViewMapping_SetProjection(Instance, (int)value);
			}
			get {
				return (Visual3dTypeOfProjection)Visual3d_ViewMapping_Projection(Instance);
			}
		}
		public Graphic3dVertex ProjectionReferencePoint{
			set { 
				Visual3d_ViewMapping_SetProjectionReferencePoint(Instance, value.Instance);
			}
			get {
				return new Graphic3dVertex(Visual3d_ViewMapping_ProjectionReferencePoint(Instance));
			}
		}
		public double ViewPlaneDistance{
			set { 
				Visual3d_ViewMapping_SetViewPlaneDistance(Instance, value);
			}
			get {
				return Visual3d_ViewMapping_ViewPlaneDistance(Instance);
			}
		}
		public bool IsCustomMatrix{
			get {
				return Visual3d_ViewMapping_IsCustomMatrix(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewMapping_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewMapping_Ctor65BCDE62(int AType,IntPtr PRP,double BPD,double FPD,double VPD,double WUmin,double WVmin,double WUmax,double WVmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewMapping_SetWindowLimitC2777E0C(IntPtr instance, double Umin,double Vmin,double Umax,double Vmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewMapping_WindowLimitC2777E0C(IntPtr instance, ref double Umin,ref double Vmin,ref double Umax,ref double Vmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewMapping_SetBackPlaneDistance(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Visual3d_ViewMapping_BackPlaneDistance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewMapping_SetFrontPlaneDistance(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Visual3d_ViewMapping_FrontPlaneDistance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewMapping_SetProjection(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_ViewMapping_Projection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewMapping_SetProjectionReferencePoint(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewMapping_ProjectionReferencePoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewMapping_SetViewPlaneDistance(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Visual3d_ViewMapping_ViewPlaneDistance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_ViewMapping_IsCustomMatrix(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dViewMapping(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dViewMapping_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dViewMapping_Dtor(IntPtr instance);
	}
}
