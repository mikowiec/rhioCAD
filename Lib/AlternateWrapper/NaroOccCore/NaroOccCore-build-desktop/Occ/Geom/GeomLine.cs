#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.GeomAbs;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomLine : GeomCurve
	{
		public GeomLine(gpAx1 A1)
 :
			base(Geom_Line_Ctor608B963B(A1.Instance) )
		{}
		public GeomLine(gpLin L)
 :
			base(Geom_Line_Ctor9917D291(L.Instance) )
		{}
		public GeomLine(gpPnt P,gpDir V)
 :
			base(Geom_Line_CtorE13B639C(P.Instance, V.Instance) )
		{}
			public void Reverse()
				{
					Geom_Line_Reverse(Instance);
				}
			public double ReversedParameter(double U)
				{
					return Geom_Line_ReversedParameterD82819F3(Instance, U);
				}
			public bool IsCN(int N)
				{
					return Geom_Line_IsCNE8219145(Instance, N);
				}
			public void D0(double U,gpPnt P)
				{
					Geom_Line_D053A5A2C1(Instance, U, P.Instance);
				}
			public void D1(double U,gpPnt P,gpVec V1)
				{
					Geom_Line_D11387A81(Instance, U, P.Instance, V1.Instance);
				}
			public void D2(double U,gpPnt P,gpVec V1,gpVec V2)
				{
					Geom_Line_D227877840(Instance, U, P.Instance, V1.Instance, V2.Instance);
				}
			public void D3(double U,gpPnt P,gpVec V1,gpVec V2,gpVec V3)
				{
					Geom_Line_D356E36E6F(Instance, U, P.Instance, V1.Instance, V2.Instance, V3.Instance);
				}
			public gpVec DN(double U,int N)
				{
					return new gpVec(Geom_Line_DN2935ABDE(Instance, U, N));
				}
			public void Transform(gpTrsf T)
				{
					Geom_Line_Transform72D78650(Instance, T.Instance);
				}
			public double TransformedParameter(double U,gpTrsf T)
				{
					return Geom_Line_TransformedParameter9B95D054(Instance, U, T.Instance);
				}
			public double ParametricTransformation(gpTrsf T)
				{
					return Geom_Line_ParametricTransformation72D78650(Instance, T.Instance);
				}
		public gpDir Direction{
			set { 
				Geom_Line_SetDirection(Instance, value.Instance);
			}
		}
		public gpPnt Location{
			set { 
				Geom_Line_SetLocation(Instance, value.Instance);
			}
		}
		public gpLin Lin{
			set { 
				Geom_Line_SetLin(Instance, value.Instance);
			}
			get {
				return new gpLin(Geom_Line_Lin(Instance));
			}
		}
		public gpAx1 Position{
			set { 
				Geom_Line_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx1(Geom_Line_Position(Instance));
			}
		}
		public double FirstParameter{
			get {
				return Geom_Line_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			get {
				return Geom_Line_LastParameter(Instance);
			}
		}
		public bool IsClosed{
			get {
				return Geom_Line_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return Geom_Line_IsPeriodic(Instance);
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)Geom_Line_Continuity(Instance);
			}
		}
		public GeomGeometry Copy{
			get {
				return new GeomGeometry(Geom_Line_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Line_Ctor608B963B(IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Line_Ctor9917D291(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Line_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Line_ReversedParameterD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Line_IsCNE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_D053A5A2C1(IntPtr instance, double U,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_D11387A81(IntPtr instance, double U,IntPtr P,IntPtr V1);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_D227877840(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_D356E36E6F(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Line_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Line_TransformedParameter9B95D054(IntPtr instance, double U,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Line_ParametricTransformation72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_SetLin(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Line_Lin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Line_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Line_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Line_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Line_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Line_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Line_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Geom_Line_Continuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Line_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomLine() { } 

		public GeomLine(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomLine_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomLine_Dtor(IntPtr instance);
	}
}
