#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpCirc : NativeInstancePtr
	{
		public gpCirc()
 :
			base(gp_Circ_Ctor() )
		{}
		public gpCirc(gpAx2 A2,double Radius)
 :
			base(gp_Circ_Ctor673FA07D(A2.Instance, Radius) )
		{}
			public double Distance(gpPnt P)
				{
					return gp_Circ_Distance9EAECD5B(Instance, P.Instance);
				}
			public double SquareDistance(gpPnt P)
				{
					return gp_Circ_SquareDistance9EAECD5B(Instance, P.Instance);
				}
			public bool Contains(gpPnt P,double LinearTolerance)
				{
					return gp_Circ_ContainsF0D1E3E6(Instance, P.Instance, LinearTolerance);
				}
			public void Mirror(gpPnt P)
				{
					gp_Circ_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpCirc Mirrored(gpPnt P)
				{
					return new gpCirc(gp_Circ_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Circ_Mirror608B963B(Instance, A1.Instance);
				}
			public gpCirc Mirrored(gpAx1 A1)
				{
					return new gpCirc(gp_Circ_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Circ_Mirror7895386A(Instance, A2.Instance);
				}
			public gpCirc Mirrored(gpAx2 A2)
				{
					return new gpCirc(gp_Circ_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Circ_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpCirc Rotated(gpAx1 A1,double Ang)
				{
					return new gpCirc(gp_Circ_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Circ_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpCirc Scaled(gpPnt P,double S)
				{
					return new gpCirc(gp_Circ_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Circ_Transform72D78650(Instance, T.Instance);
				}
			public gpCirc Transformed(gpTrsf T)
				{
					return new gpCirc(gp_Circ_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Circ_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpCirc Translated(gpVec V)
				{
					return new gpCirc(gp_Circ_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Circ_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpCirc Translated(gpPnt P1,gpPnt P2)
				{
					return new gpCirc(gp_Circ_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public double Area{
			get {
				return gp_Circ_Area(Instance);
			}
		}
		public gpAx1 Axis{
			set { 
				gp_Circ_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Circ_Axis(Instance));
			}
		}
		public double Length{
			get {
				return gp_Circ_Length(Instance);
			}
		}
		public gpPnt Location{
			set { 
				gp_Circ_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Circ_Location(Instance));
			}
		}
		public gpAx2 Position{
			set { 
				gp_Circ_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx2(gp_Circ_Position(Instance));
			}
		}
		public double Radius{
			set { 
				gp_Circ_SetRadius(Instance, value);
			}
			get {
				return gp_Circ_Radius(Instance);
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(gp_Circ_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(gp_Circ_YAxis(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Ctor673FA07D(IntPtr A2,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ_Distance9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ_SquareDistance9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Circ_ContainsF0D1E3E6(IntPtr instance, IntPtr P,double LinearTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ_Area(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ_SetRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ_Radius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ_YAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpCirc(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpCirc_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpCirc_Dtor(IntPtr instance);
	}
}
