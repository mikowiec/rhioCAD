#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TColgp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomBezierCurve : GeomBoundedCurve
	{
		public GeomBezierCurve(TColgpArray1OfPnt CurvePoles)
 :
			base(Geom_BezierCurve_CtorFABD0F95(CurvePoles.Instance) )
		{}
			public void Increase(int Degree)
				{
					Geom_BezierCurve_IncreaseE8219145(Instance, Degree);
				}
			public void InsertPoleAfter(int Index,gpPnt P)
				{
					Geom_BezierCurve_InsertPoleAfter7B5D1E58(Instance, Index, P.Instance);
				}
			public void InsertPoleAfter(int Index,gpPnt P,double Weight)
				{
					Geom_BezierCurve_InsertPoleAfter7C5189B4(Instance, Index, P.Instance, Weight);
				}
			public void InsertPoleBefore(int Index,gpPnt P)
				{
					Geom_BezierCurve_InsertPoleBefore7B5D1E58(Instance, Index, P.Instance);
				}
			public void InsertPoleBefore(int Index,gpPnt P,double Weight)
				{
					Geom_BezierCurve_InsertPoleBefore7C5189B4(Instance, Index, P.Instance, Weight);
				}
			public void RemovePole(int Index)
				{
					Geom_BezierCurve_RemovePoleE8219145(Instance, Index);
				}
			public void Reverse()
				{
					Geom_BezierCurve_Reverse(Instance);
				}
			public double ReversedParameter(double U)
				{
					return Geom_BezierCurve_ReversedParameterD82819F3(Instance, U);
				}
			public void Segment(double U1,double U2)
				{
					Geom_BezierCurve_Segment9F0E714F(Instance, U1, U2);
				}
			public void SetPole(int Index,gpPnt P)
				{
					Geom_BezierCurve_SetPole7B5D1E58(Instance, Index, P.Instance);
				}
			public void SetPole(int Index,gpPnt P,double Weight)
				{
					Geom_BezierCurve_SetPole7C5189B4(Instance, Index, P.Instance, Weight);
				}
			public void SetWeight(int Index,double Weight)
				{
					Geom_BezierCurve_SetWeight69F5FCCD(Instance, Index, Weight);
				}
			public bool IsCN(int N)
				{
					return Geom_BezierCurve_IsCNE8219145(Instance, N);
				}
			public void D0(double U,gpPnt P)
				{
					Geom_BezierCurve_D053A5A2C1(Instance, U, P.Instance);
				}
			public void D1(double U,gpPnt P,gpVec V1)
				{
					Geom_BezierCurve_D11387A81(Instance, U, P.Instance, V1.Instance);
				}
			public void D2(double U,gpPnt P,gpVec V1,gpVec V2)
				{
					Geom_BezierCurve_D227877840(Instance, U, P.Instance, V1.Instance, V2.Instance);
				}
			public void D3(double U,gpPnt P,gpVec V1,gpVec V2,gpVec V3)
				{
					Geom_BezierCurve_D356E36E6F(Instance, U, P.Instance, V1.Instance, V2.Instance, V3.Instance);
				}
			public gpVec DN(double U,int N)
				{
					return new gpVec(Geom_BezierCurve_DN2935ABDE(Instance, U, N));
				}
			public gpPnt Pole(int Index)
				{
					return new gpPnt(Geom_BezierCurve_PoleE8219145(Instance, Index));
				}
			public void Poles(TColgpArray1OfPnt P)
				{
					Geom_BezierCurve_PolesFABD0F95(Instance, P.Instance);
				}
			public double Weight(int Index)
				{
					return Geom_BezierCurve_WeightE8219145(Instance, Index);
				}
			public void Transform(gpTrsf T)
				{
					Geom_BezierCurve_Transform72D78650(Instance, T.Instance);
				}
			public void Resolution(double Tolerance3D,ref double UTolerance)
				{
					Geom_BezierCurve_Resolution9F0E714F(Instance, Tolerance3D, ref UTolerance);
				}
		public bool IsClosed{
			get {
				return Geom_BezierCurve_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return Geom_BezierCurve_IsPeriodic(Instance);
			}
		}
		public bool IsRational{
			get {
				return Geom_BezierCurve_IsRational(Instance);
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)Geom_BezierCurve_Continuity(Instance);
			}
		}
		public int Degree{
			get {
				return Geom_BezierCurve_Degree(Instance);
			}
		}
		public gpPnt StartPoint{
			get {
				return new gpPnt(Geom_BezierCurve_StartPoint(Instance));
			}
		}
		public gpPnt EndPoint{
			get {
				return new gpPnt(Geom_BezierCurve_EndPoint(Instance));
			}
		}
		public double FirstParameter{
			get {
				return Geom_BezierCurve_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			get {
				return Geom_BezierCurve_LastParameter(Instance);
			}
		}
		public int NbPoles{
			get {
				return Geom_BezierCurve_NbPoles(Instance);
			}
		}
		public static int MaxDegree{
			get {
				return Geom_BezierCurve_MaxDegree();
			}
		}
		public GeomGeometry Copy{
			get {
				return new GeomGeometry(Geom_BezierCurve_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_BezierCurve_CtorFABD0F95(IntPtr CurvePoles);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_IncreaseE8219145(IntPtr instance, int Degree);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_InsertPoleAfter7B5D1E58(IntPtr instance, int Index,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_InsertPoleAfter7C5189B4(IntPtr instance, int Index,IntPtr P,double Weight);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_InsertPoleBefore7B5D1E58(IntPtr instance, int Index,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_InsertPoleBefore7C5189B4(IntPtr instance, int Index,IntPtr P,double Weight);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_RemovePoleE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_BezierCurve_ReversedParameterD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_Segment9F0E714F(IntPtr instance, double U1,double U2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_SetPole7B5D1E58(IntPtr instance, int Index,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_SetPole7C5189B4(IntPtr instance, int Index,IntPtr P,double Weight);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_SetWeight69F5FCCD(IntPtr instance, int Index,double Weight);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_BezierCurve_IsCNE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_D053A5A2C1(IntPtr instance, double U,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_D11387A81(IntPtr instance, double U,IntPtr P,IntPtr V1);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_D227877840(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_D356E36E6F(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_BezierCurve_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_BezierCurve_PoleE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_PolesFABD0F95(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_BezierCurve_WeightE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_BezierCurve_Resolution9F0E714F(IntPtr instance, double Tolerance3D,ref double UTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_BezierCurve_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_BezierCurve_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_BezierCurve_IsRational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Geom_BezierCurve_Continuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Geom_BezierCurve_Degree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_BezierCurve_StartPoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_BezierCurve_EndPoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_BezierCurve_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_BezierCurve_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Geom_BezierCurve_NbPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Geom_BezierCurve_MaxDegree();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_BezierCurve_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomBezierCurve() { } 

		public GeomBezierCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomBezierCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomBezierCurve_Dtor(IntPtr instance);
	}
}
