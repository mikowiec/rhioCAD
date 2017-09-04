#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.IntSurf
{
	public class IntSurfPntOn2S : NativeInstancePtr
	{
		public IntSurfPntOn2S()
 :
			base(IntSurf_PntOn2S_Ctor() )
		{}
			public void SetValue(gpPnt Pt)
				{
					IntSurf_PntOn2S_SetValue9EAECD5B(Instance, Pt.Instance);
				}
			public void SetValue(gpPnt Pt,bool OnFirst,double U,double V)
				{
					IntSurf_PntOn2S_SetValue705FE798(Instance, Pt.Instance, OnFirst, U, V);
				}
			public void SetValue(gpPnt Pt,double U1,double V1,double U2,double V2)
				{
					IntSurf_PntOn2S_SetValueD969C62A(Instance, Pt.Instance, U1, V1, U2, V2);
				}
			public void SetValue(bool OnFirst,double U,double V)
				{
					IntSurf_PntOn2S_SetValueDA23FEE7(Instance, OnFirst, U, V);
				}
			public void SetValue(double U1,double V1,double U2,double V2)
				{
					IntSurf_PntOn2S_SetValueC2777E0C(Instance, U1, V1, U2, V2);
				}
			public gpPnt Value()
				{
					return new gpPnt(IntSurf_PntOn2S_Value(Instance));
				}
			public void ParametersOnS1(ref double U1,ref double V1)
				{
					IntSurf_PntOn2S_ParametersOnS19F0E714F(Instance, ref U1, ref V1);
				}
			public void ParametersOnS2(ref double U2,ref double V2)
				{
					IntSurf_PntOn2S_ParametersOnS29F0E714F(Instance, ref U2, ref V2);
				}
			public void Parameters(ref double U1,ref double V1,ref double U2,ref double V2)
				{
					IntSurf_PntOn2S_ParametersC2777E0C(Instance, ref U1, ref V1, ref U2, ref V2);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntSurf_PntOn2S_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void IntSurf_PntOn2S_SetValue9EAECD5B(IntPtr instance, IntPtr Pt);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntSurf_PntOn2S_SetValue705FE798(IntPtr instance, IntPtr Pt,bool OnFirst,double U,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntSurf_PntOn2S_SetValueD969C62A(IntPtr instance, IntPtr Pt,double U1,double V1,double U2,double V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntSurf_PntOn2S_SetValueDA23FEE7(IntPtr instance, bool OnFirst,double U,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntSurf_PntOn2S_SetValueC2777E0C(IntPtr instance, double U1,double V1,double U2,double V2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntSurf_PntOn2S_Value(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntSurf_PntOn2S_ParametersOnS19F0E714F(IntPtr instance, ref double U1,ref double V1);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntSurf_PntOn2S_ParametersOnS29F0E714F(IntPtr instance, ref double U2,ref double V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntSurf_PntOn2S_ParametersC2777E0C(IntPtr instance, ref double U1,ref double V1,ref double U2,ref double V2);

		#region NativeInstancePtr Convert constructor

		public IntSurfPntOn2S(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntSurfPntOn2S_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntSurfPntOn2S_Dtor(IntPtr instance);
	}
}
