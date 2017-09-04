#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Adaptor3d;

#endregion

namespace NaroCppCore.Occ.Extrema
{
	public class ExtremaExtPC : NativeInstancePtr
	{
		public ExtremaExtPC()
 :
			base(Extrema_ExtPC_Ctor() )
		{}
		public ExtremaExtPC(gpPnt P,Adaptor3dCurve C,double Uinf,double Usup,double TolF)
 :
			base(Extrema_ExtPC_CtorCF4A20E8(P.Instance, C.Instance, Uinf, Usup, TolF) )
		{}
		public ExtremaExtPC(gpPnt P,Adaptor3dCurve C,double TolF)
 :
			base(Extrema_ExtPC_CtorB2B0ECF0(P.Instance, C.Instance, TolF) )
		{}
			public void Initialize(Adaptor3dCurve C,double Uinf,double Usup,double TolF)
				{
					Extrema_ExtPC_InitializeFE87C4E9(Instance, C.Instance, Uinf, Usup, TolF);
				}
			public double SquareDistance(int N)
				{
					return Extrema_ExtPC_SquareDistanceE8219145(Instance, N);
				}
			public void TrimmedSquareDistances(ref double dist1,ref double dist2,gpPnt P1,gpPnt P2)
				{
					Extrema_ExtPC_TrimmedSquareDistancesB51F241F(Instance, ref dist1, ref dist2, P1.Instance, P2.Instance);
				}
		public bool IsDone{
			get {
				return Extrema_ExtPC_IsDone(Instance);
			}
		}
		public int NbExt{
			get {
				return Extrema_ExtPC_NbExt(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Extrema_ExtPC_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Extrema_ExtPC_CtorCF4A20E8(IntPtr P,IntPtr C,double Uinf,double Usup,double TolF);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Extrema_ExtPC_CtorB2B0ECF0(IntPtr P,IntPtr C,double TolF);
		[DllImport("NaroOccCore.dll")]
		private static extern void Extrema_ExtPC_InitializeFE87C4E9(IntPtr instance, IntPtr C,double Uinf,double Usup,double TolF);
		[DllImport("NaroOccCore.dll")]
		private static extern double Extrema_ExtPC_SquareDistanceE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Extrema_ExtPC_TrimmedSquareDistancesB51F241F(IntPtr instance, ref double dist1,ref double dist2,IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Extrema_ExtPC_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Extrema_ExtPC_NbExt(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public ExtremaExtPC(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ExtremaExtPC_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ExtremaExtPC_Dtor(IntPtr instance);
	}
}
