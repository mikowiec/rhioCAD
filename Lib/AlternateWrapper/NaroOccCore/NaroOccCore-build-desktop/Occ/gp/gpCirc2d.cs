#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpCirc2d : NativeInstancePtr
	{
		public gpCirc2d()
 :
			base(gp_Circ2d_Ctor() )
		{}
		public gpCirc2d(gpAx2d XAxis,double Radius,bool Sense)
 :
			base(gp_Circ2d_Ctor462C7341(XAxis.Instance, Radius, Sense) )
		{}
		public gpCirc2d(gpAx22d Axis,double Radius)
 :
			base(gp_Circ2d_Ctor443D47DE(Axis.Instance, Radius) )
		{}
			public void Coefficients(ref double A,ref double B,ref double C,ref double D,ref double E,ref double F)
				{
					gp_Circ2d_CoefficientsBC7A5786(Instance, ref A, ref B, ref C, ref D, ref E, ref F);
				}
			public bool Contains(gpPnt2d P,double LinearTolerance)
				{
					return gp_Circ2d_ContainsE3062737(Instance, P.Instance, LinearTolerance);
				}
			public double Distance(gpPnt2d P)
				{
					return gp_Circ2d_Distance6203658C(Instance, P.Instance);
				}
			public double SquareDistance(gpPnt2d P)
				{
					return gp_Circ2d_SquareDistance6203658C(Instance, P.Instance);
				}
			public void Reverse()
				{
					gp_Circ2d_Reverse(Instance);
				}
			public void Mirror(gpPnt2d P)
				{
					gp_Circ2d_Mirror6203658C(Instance, P.Instance);
				}
			public gpCirc2d Mirrored(gpPnt2d P)
				{
					return new gpCirc2d(gp_Circ2d_Mirrored6203658C(Instance, P.Instance));
				}
			public void Mirror(gpAx2d A)
				{
					gp_Circ2d_Mirror90E1386A(Instance, A.Instance);
				}
			public gpCirc2d Mirrored(gpAx2d A)
				{
					return new gpCirc2d(gp_Circ2d_Mirrored90E1386A(Instance, A.Instance));
				}
			public void Rotate(gpPnt2d P,double Ang)
				{
					gp_Circ2d_RotateE3062737(Instance, P.Instance, Ang);
				}
			public gpCirc2d Rotated(gpPnt2d P,double Ang)
				{
					return new gpCirc2d(gp_Circ2d_RotatedE3062737(Instance, P.Instance, Ang));
				}
			public void Scale(gpPnt2d P,double S)
				{
					gp_Circ2d_ScaleE3062737(Instance, P.Instance, S);
				}
			public gpCirc2d Scaled(gpPnt2d P,double S)
				{
					return new gpCirc2d(gp_Circ2d_ScaledE3062737(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf2d T)
				{
					gp_Circ2d_Transform27621DCB(Instance, T.Instance);
				}
			public gpCirc2d Transformed(gpTrsf2d T)
				{
					return new gpCirc2d(gp_Circ2d_Transformed27621DCB(Instance, T.Instance));
				}
			public void Translate(gpVec2d V)
				{
					gp_Circ2d_Translate5E4E66E7(Instance, V.Instance);
				}
			public gpCirc2d Translated(gpVec2d V)
				{
					return new gpCirc2d(gp_Circ2d_Translated5E4E66E7(Instance, V.Instance));
				}
			public void Translate(gpPnt2d P1,gpPnt2d P2)
				{
					gp_Circ2d_Translate5F54ADE3(Instance, P1.Instance, P2.Instance);
				}
			public gpCirc2d Translated(gpPnt2d P1,gpPnt2d P2)
				{
					return new gpCirc2d(gp_Circ2d_Translated5F54ADE3(Instance, P1.Instance, P2.Instance));
				}
		public double Area{
			get {
				return gp_Circ2d_Area(Instance);
			}
		}
		public double Length{
			get {
				return gp_Circ2d_Length(Instance);
			}
		}
		public gpPnt2d Location{
			set { 
				gp_Circ2d_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt2d(gp_Circ2d_Location(Instance));
			}
		}
		public double Radius{
			set { 
				gp_Circ2d_SetRadius(Instance, value);
			}
			get {
				return gp_Circ2d_Radius(Instance);
			}
		}
		public gpAx22d Axis{
			set { 
				gp_Circ2d_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx22d(gp_Circ2d_Axis(Instance));
			}
		}
		public gpAx22d Position{
			get {
				return new gpAx22d(gp_Circ2d_Position(Instance));
			}
		}
		public gpAx2d XAxis{
			set { 
				gp_Circ2d_SetXAxis(Instance, value.Instance);
			}
			get {
				return new gpAx2d(gp_Circ2d_XAxis(Instance));
			}
		}
		public gpAx2d YAxis{
			set { 
				gp_Circ2d_SetYAxis(Instance, value.Instance);
			}
			get {
				return new gpAx2d(gp_Circ2d_YAxis(Instance));
			}
		}
		public gpCirc2d Reversed{
			get {
				return new gpCirc2d(gp_Circ2d_Reversed(Instance));
			}
		}
		public bool IsDirect{
			get {
				return gp_Circ2d_IsDirect(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Ctor462C7341(IntPtr XAxis,double Radius,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Ctor443D47DE(IntPtr Axis,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_CoefficientsBC7A5786(IntPtr instance, ref double A,ref double B,ref double C,ref double D,ref double E,ref double F);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Circ2d_ContainsE3062737(IntPtr instance, IntPtr P,double LinearTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ2d_Distance6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ2d_SquareDistance6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_Mirror6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Mirrored6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_Mirror90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Mirrored90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_RotateE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_RotatedE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_ScaleE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_ScaledE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_Transform27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_Translate5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Translated5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_Translate5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Translated5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ2d_Area(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ2d_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_SetRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Circ2d_Radius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_SetXAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Circ2d_SetYAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_YAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Circ2d_Reversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Circ2d_IsDirect(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpCirc2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpCirc2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpCirc2d_Dtor(IntPtr instance);
	}
}
