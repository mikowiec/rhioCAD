#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomCircle : GeomConic
	{
		public GeomCircle(gpCirc C)
 :
			base(Geom_Circle_Ctor727811A8(C.Instance) )
		{}
		public GeomCircle(gpAx2 A2,double Radius)
 :
			base(Geom_Circle_Ctor673FA07D(A2.Instance, Radius) )
		{}
			public double ReversedParameter(double U)
				{
					return Geom_Circle_ReversedParameterD82819F3(Instance, U);
				}
			public void D0(double U,gpPnt P)
				{
					Geom_Circle_D053A5A2C1(Instance, U, P.Instance);
				}
			public void D1(double U,gpPnt P,gpVec V1)
				{
					Geom_Circle_D11387A81(Instance, U, P.Instance, V1.Instance);
				}
			public void D2(double U,gpPnt P,gpVec V1,gpVec V2)
				{
					Geom_Circle_D227877840(Instance, U, P.Instance, V1.Instance, V2.Instance);
				}
			public void D3(double U,gpPnt P,gpVec V1,gpVec V2,gpVec V3)
				{
					Geom_Circle_D356E36E6F(Instance, U, P.Instance, V1.Instance, V2.Instance, V3.Instance);
				}
			public gpVec DN(double U,int N)
				{
					return new gpVec(Geom_Circle_DN2935ABDE(Instance, U, N));
				}
			public void Transform(gpTrsf T)
				{
					Geom_Circle_Transform72D78650(Instance, T.Instance);
				}
		public gpCirc Circ{
			set { 
				Geom_Circle_SetCirc(Instance, value.Instance);
			}
			get {
				return new gpCirc(Geom_Circle_Circ(Instance));
			}
		}
		public double Radius{
			set { 
				Geom_Circle_SetRadius(Instance, value);
			}
			get {
				return Geom_Circle_Radius(Instance);
			}
		}
		public double Eccentricity{
			get {
				return Geom_Circle_Eccentricity(Instance);
			}
		}
		public double FirstParameter{
			get {
				return Geom_Circle_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			get {
				return Geom_Circle_LastParameter(Instance);
			}
		}
		public bool IsClosed{
			get {
				return Geom_Circle_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return Geom_Circle_IsPeriodic(Instance);
			}
		}
		public GeomGeometry Copy{
			get {
				return new GeomGeometry(Geom_Circle_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Circle_Ctor727811A8(IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Circle_Ctor673FA07D(IntPtr A2,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Circle_ReversedParameterD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Circle_D053A5A2C1(IntPtr instance, double U,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Circle_D11387A81(IntPtr instance, double U,IntPtr P,IntPtr V1);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Circle_D227877840(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Circle_D356E36E6F(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Circle_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Circle_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Circle_SetCirc(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Circle_Circ(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Circle_SetRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Circle_Radius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Circle_Eccentricity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Circle_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Circle_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Circle_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Circle_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Circle_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomCircle() { } 

		public GeomCircle(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomCircle_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomCircle_Dtor(IntPtr instance);
	}
}
