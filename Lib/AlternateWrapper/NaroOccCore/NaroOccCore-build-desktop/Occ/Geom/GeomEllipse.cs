#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomEllipse : GeomConic
	{
		public GeomEllipse(gpElips E)
 :
			base(Geom_Ellipse_CtorAA0BF3BF(E.Instance) )
		{}
		public GeomEllipse(gpAx2 A2,double MajorRadius,double MinorRadius)
 :
			base(Geom_Ellipse_CtorB1A3BD2A(A2.Instance, MajorRadius, MinorRadius) )
		{}
			public double ReversedParameter(double U)
				{
					return Geom_Ellipse_ReversedParameterD82819F3(Instance, U);
				}
			public void D0(double U,gpPnt P)
				{
					Geom_Ellipse_D053A5A2C1(Instance, U, P.Instance);
				}
			public void D1(double U,gpPnt P,gpVec V1)
				{
					Geom_Ellipse_D11387A81(Instance, U, P.Instance, V1.Instance);
				}
			public void D2(double U,gpPnt P,gpVec V1,gpVec V2)
				{
					Geom_Ellipse_D227877840(Instance, U, P.Instance, V1.Instance, V2.Instance);
				}
			public void D3(double U,gpPnt P,gpVec V1,gpVec V2,gpVec V3)
				{
					Geom_Ellipse_D356E36E6F(Instance, U, P.Instance, V1.Instance, V2.Instance, V3.Instance);
				}
			public gpVec DN(double U,int N)
				{
					return new gpVec(Geom_Ellipse_DN2935ABDE(Instance, U, N));
				}
			public void Transform(gpTrsf T)
				{
					Geom_Ellipse_Transform72D78650(Instance, T.Instance);
				}
		public gpElips Elips{
			set { 
				Geom_Ellipse_SetElips(Instance, value.Instance);
			}
			get {
				return new gpElips(Geom_Ellipse_Elips(Instance));
			}
		}
		public gpAx1 Directrix1{
			get {
				return new gpAx1(Geom_Ellipse_Directrix1(Instance));
			}
		}
		public gpAx1 Directrix2{
			get {
				return new gpAx1(Geom_Ellipse_Directrix2(Instance));
			}
		}
		public double Eccentricity{
			get {
				return Geom_Ellipse_Eccentricity(Instance);
			}
		}
		public double Focal{
			get {
				return Geom_Ellipse_Focal(Instance);
			}
		}
		public gpPnt Focus1{
			get {
				return new gpPnt(Geom_Ellipse_Focus1(Instance));
			}
		}
		public gpPnt Focus2{
			get {
				return new gpPnt(Geom_Ellipse_Focus2(Instance));
			}
		}
		public double MajorRadius{
			set { 
				Geom_Ellipse_SetMajorRadius(Instance, value);
			}
			get {
				return Geom_Ellipse_MajorRadius(Instance);
			}
		}
		public double MinorRadius{
			set { 
				Geom_Ellipse_SetMinorRadius(Instance, value);
			}
			get {
				return Geom_Ellipse_MinorRadius(Instance);
			}
		}
		public double Parameter{
			get {
				return Geom_Ellipse_Parameter(Instance);
			}
		}
		public double FirstParameter{
			get {
				return Geom_Ellipse_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			get {
				return Geom_Ellipse_LastParameter(Instance);
			}
		}
		public bool IsClosed{
			get {
				return Geom_Ellipse_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return Geom_Ellipse_IsPeriodic(Instance);
			}
		}
		public GeomGeometry Copy{
			get {
				return new GeomGeometry(Geom_Ellipse_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Ellipse_CtorAA0BF3BF(IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Ellipse_CtorB1A3BD2A(IntPtr A2,double MajorRadius,double MinorRadius);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Ellipse_ReversedParameterD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Ellipse_D053A5A2C1(IntPtr instance, double U,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Ellipse_D11387A81(IntPtr instance, double U,IntPtr P,IntPtr V1);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Ellipse_D227877840(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Ellipse_D356E36E6F(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Ellipse_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Ellipse_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Ellipse_SetElips(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Ellipse_Elips(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Ellipse_Directrix1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Ellipse_Directrix2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Ellipse_Eccentricity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Ellipse_Focal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Ellipse_Focus1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Ellipse_Focus2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Ellipse_SetMajorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Ellipse_MajorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Ellipse_SetMinorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Ellipse_MinorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Ellipse_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Ellipse_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Ellipse_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Ellipse_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Ellipse_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Ellipse_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomEllipse() { } 

		public GeomEllipse(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomEllipse_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomEllipse_Dtor(IntPtr instance);
	}
}
