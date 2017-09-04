#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dClipPlane : MMgtTShared
	{
		public Visual3dClipPlane(double ACoefA,double ACoefB,double ACoefC,double ACoefD)
 :
			base(Visual3d_ClipPlane_CtorC2777E0C(ACoefA, ACoefB, ACoefC, ACoefD) )
		{}
			public void SetPlane(double ACoefA,double ACoefB,double ACoefC,double ACoefD)
				{
					Visual3d_ClipPlane_SetPlaneC2777E0C(Instance, ACoefA, ACoefB, ACoefC, ACoefD);
				}
			public void Plane(ref double ACoefA,ref double ACoefB,ref double ACoefC,ref double ACoefD)
				{
					Visual3d_ClipPlane_PlaneC2777E0C(Instance, ref ACoefA, ref ACoefB, ref ACoefC, ref ACoefD);
				}
		public static int Limit{
			get {
				return Visual3d_ClipPlane_Limit();
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ClipPlane_CtorC2777E0C(double ACoefA,double ACoefB,double ACoefC,double ACoefD);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ClipPlane_SetPlaneC2777E0C(IntPtr instance, double ACoefA,double ACoefB,double ACoefC,double ACoefD);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ClipPlane_PlaneC2777E0C(IntPtr instance, ref double ACoefA,ref double ACoefB,ref double ACoefC,ref double ACoefD);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_ClipPlane_Limit();

		#region NativeInstancePtr Convert constructor

		public Visual3dClipPlane() { } 

		public Visual3dClipPlane(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dClipPlane_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dClipPlane_Dtor(IntPtr instance);
	}
}
