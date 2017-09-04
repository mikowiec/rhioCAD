#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.IntAna
{
	public class IntAnaIntConicQuad : NativeInstancePtr
	{
		public IntAnaIntConicQuad()
 :
			base(IntAna_IntConicQuad_Ctor() )
		{}
		public IntAnaIntConicQuad(gpLin L,gpPln P,double Tolang)
 :
			base(IntAna_IntConicQuad_Ctor89334BAA(L.Instance, P.Instance, Tolang) )
		{}
		public IntAnaIntConicQuad(gpCirc C,gpPln P,double Tolang,double Tol)
 :
			base(IntAna_IntConicQuad_Ctor8C72EA96(C.Instance, P.Instance, Tolang, Tol) )
		{}
		public IntAnaIntConicQuad(gpElips E,gpPln P,double Tolang,double Tol)
 :
			base(IntAna_IntConicQuad_Ctor9E3F6D56(E.Instance, P.Instance, Tolang, Tol) )
		{}
		public IntAnaIntConicQuad(gpParab Pb,gpPln P,double Tolang)
 :
			base(IntAna_IntConicQuad_CtorFF3C8AFC(Pb.Instance, P.Instance, Tolang) )
		{}
		public IntAnaIntConicQuad(gpHypr H,gpPln P,double Tolang)
 :
			base(IntAna_IntConicQuad_Ctor1B97E413(H.Instance, P.Instance, Tolang) )
		{}
			public void Perform(gpLin L,gpPln P,double Tolang)
				{
					IntAna_IntConicQuad_Perform89334BAA(Instance, L.Instance, P.Instance, Tolang);
				}
			public void Perform(gpCirc C,gpPln P,double Tolang,double Tol)
				{
					IntAna_IntConicQuad_Perform8C72EA96(Instance, C.Instance, P.Instance, Tolang, Tol);
				}
			public void Perform(gpElips E,gpPln P,double Tolang,double Tol)
				{
					IntAna_IntConicQuad_Perform9E3F6D56(Instance, E.Instance, P.Instance, Tolang, Tol);
				}
			public void Perform(gpParab Pb,gpPln P,double Tolang)
				{
					IntAna_IntConicQuad_PerformFF3C8AFC(Instance, Pb.Instance, P.Instance, Tolang);
				}
			public void Perform(gpHypr H,gpPln P,double Tolang)
				{
					IntAna_IntConicQuad_Perform1B97E413(Instance, H.Instance, P.Instance, Tolang);
				}
			public gpPnt Point(int N)
				{
					return new gpPnt(IntAna_IntConicQuad_PointE8219145(Instance, N));
				}
			public double ParamOnConic(int N)
				{
					return IntAna_IntConicQuad_ParamOnConicE8219145(Instance, N);
				}
		public bool IsDone{
			get {
				return IntAna_IntConicQuad_IsDone(Instance);
			}
		}
		public bool IsInQuadric{
			get {
				return IntAna_IntConicQuad_IsInQuadric(Instance);
			}
		}
		public bool IsParallel{
			get {
				return IntAna_IntConicQuad_IsParallel(Instance);
			}
		}
		public int NbPoints{
			get {
				return IntAna_IntConicQuad_NbPoints(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntAna_IntConicQuad_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntAna_IntConicQuad_Ctor89334BAA(IntPtr L,IntPtr P,double Tolang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntAna_IntConicQuad_Ctor8C72EA96(IntPtr C,IntPtr P,double Tolang,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntAna_IntConicQuad_Ctor9E3F6D56(IntPtr E,IntPtr P,double Tolang,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntAna_IntConicQuad_CtorFF3C8AFC(IntPtr Pb,IntPtr P,double Tolang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntAna_IntConicQuad_Ctor1B97E413(IntPtr H,IntPtr P,double Tolang);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_IntConicQuad_Perform89334BAA(IntPtr instance, IntPtr L,IntPtr P,double Tolang);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_IntConicQuad_Perform8C72EA96(IntPtr instance, IntPtr C,IntPtr P,double Tolang,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_IntConicQuad_Perform9E3F6D56(IntPtr instance, IntPtr E,IntPtr P,double Tolang,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_IntConicQuad_PerformFF3C8AFC(IntPtr instance, IntPtr Pb,IntPtr P,double Tolang);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_IntConicQuad_Perform1B97E413(IntPtr instance, IntPtr H,IntPtr P,double Tolang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntAna_IntConicQuad_PointE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern double IntAna_IntConicQuad_ParamOnConicE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntAna_IntConicQuad_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntAna_IntConicQuad_IsInQuadric(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntAna_IntConicQuad_IsParallel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntAna_IntConicQuad_NbPoints(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntAnaIntConicQuad(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntAnaIntConicQuad_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntAnaIntConicQuad_Dtor(IntPtr instance);
	}
}
