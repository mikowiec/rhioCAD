#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpElips2d : NativeInstancePtr
	{
		public gpElips2d()
 :
			base(gp_Elips2d_Ctor() )
		{}
		public gpElips2d(gpAx2d MajorAxis,double MajorRadius,double MinorRadius,bool Sense)
 :
			base(gp_Elips2d_CtorEB7AC69(MajorAxis.Instance, MajorRadius, MinorRadius, Sense) )
		{}
		public gpElips2d(gpAx22d A,double MajorRadius,double MinorRadius)
 :
			base(gp_Elips2d_Ctor2C61CEDF(A.Instance, MajorRadius, MinorRadius) )
		{}
			public void Coefficients(ref double A,ref double B,ref double C,ref double D,ref double E,ref double F)
				{
					gp_Elips2d_CoefficientsBC7A5786(Instance, ref A, ref B, ref C, ref D, ref E, ref F);
				}
			public void Reverse()
				{
					gp_Elips2d_Reverse(Instance);
				}
			public void Mirror(gpPnt2d P)
				{
					gp_Elips2d_Mirror6203658C(Instance, P.Instance);
				}
			public gpElips2d Mirrored(gpPnt2d P)
				{
					return new gpElips2d(gp_Elips2d_Mirrored6203658C(Instance, P.Instance));
				}
			public void Mirror(gpAx2d A)
				{
					gp_Elips2d_Mirror90E1386A(Instance, A.Instance);
				}
			public gpElips2d Mirrored(gpAx2d A)
				{
					return new gpElips2d(gp_Elips2d_Mirrored90E1386A(Instance, A.Instance));
				}
			public void Rotate(gpPnt2d P,double Ang)
				{
					gp_Elips2d_RotateE3062737(Instance, P.Instance, Ang);
				}
			public gpElips2d Rotated(gpPnt2d P,double Ang)
				{
					return new gpElips2d(gp_Elips2d_RotatedE3062737(Instance, P.Instance, Ang));
				}
			public void Scale(gpPnt2d P,double S)
				{
					gp_Elips2d_ScaleE3062737(Instance, P.Instance, S);
				}
			public gpElips2d Scaled(gpPnt2d P,double S)
				{
					return new gpElips2d(gp_Elips2d_ScaledE3062737(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf2d T)
				{
					gp_Elips2d_Transform27621DCB(Instance, T.Instance);
				}
			public gpElips2d Transformed(gpTrsf2d T)
				{
					return new gpElips2d(gp_Elips2d_Transformed27621DCB(Instance, T.Instance));
				}
			public void Translate(gpVec2d V)
				{
					gp_Elips2d_Translate5E4E66E7(Instance, V.Instance);
				}
			public gpElips2d Translated(gpVec2d V)
				{
					return new gpElips2d(gp_Elips2d_Translated5E4E66E7(Instance, V.Instance));
				}
			public void Translate(gpPnt2d P1,gpPnt2d P2)
				{
					gp_Elips2d_Translate5F54ADE3(Instance, P1.Instance, P2.Instance);
				}
			public gpElips2d Translated(gpPnt2d P1,gpPnt2d P2)
				{
					return new gpElips2d(gp_Elips2d_Translated5F54ADE3(Instance, P1.Instance, P2.Instance));
				}
		public double Area{
			get {
				return gp_Elips2d_Area(Instance);
			}
		}
		public gpAx2d Directrix1{
			get {
				return new gpAx2d(gp_Elips2d_Directrix1(Instance));
			}
		}
		public gpAx2d Directrix2{
			get {
				return new gpAx2d(gp_Elips2d_Directrix2(Instance));
			}
		}
		public double Eccentricity{
			get {
				return gp_Elips2d_Eccentricity(Instance);
			}
		}
		public double Focal{
			get {
				return gp_Elips2d_Focal(Instance);
			}
		}
		public gpPnt2d Focus1{
			get {
				return new gpPnt2d(gp_Elips2d_Focus1(Instance));
			}
		}
		public gpPnt2d Focus2{
			get {
				return new gpPnt2d(gp_Elips2d_Focus2(Instance));
			}
		}
		public gpPnt2d Location{
			set { 
				gp_Elips2d_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt2d(gp_Elips2d_Location(Instance));
			}
		}
		public double MajorRadius{
			set { 
				gp_Elips2d_SetMajorRadius(Instance, value);
			}
			get {
				return gp_Elips2d_MajorRadius(Instance);
			}
		}
		public double MinorRadius{
			set { 
				gp_Elips2d_SetMinorRadius(Instance, value);
			}
			get {
				return gp_Elips2d_MinorRadius(Instance);
			}
		}
		public double Parameter{
			get {
				return gp_Elips2d_Parameter(Instance);
			}
		}
		public gpAx22d Axis{
			set { 
				gp_Elips2d_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx22d(gp_Elips2d_Axis(Instance));
			}
		}
		public gpAx2d XAxis{
			set { 
				gp_Elips2d_SetXAxis(Instance, value.Instance);
			}
			get {
				return new gpAx2d(gp_Elips2d_XAxis(Instance));
			}
		}
		public gpAx2d YAxis{
			set { 
				gp_Elips2d_SetYAxis(Instance, value.Instance);
			}
			get {
				return new gpAx2d(gp_Elips2d_YAxis(Instance));
			}
		}
		public gpElips2d Reversed{
			get {
				return new gpElips2d(gp_Elips2d_Reversed(Instance));
			}
		}
		public bool IsDirect{
			get {
				return gp_Elips2d_IsDirect(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_CtorEB7AC69(IntPtr MajorAxis,double MajorRadius,double MinorRadius,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Ctor2C61CEDF(IntPtr A,double MajorRadius,double MinorRadius);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_CoefficientsBC7A5786(IntPtr instance, ref double A,ref double B,ref double C,ref double D,ref double E,ref double F);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_Mirror6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Mirrored6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_Mirror90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Mirrored90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_RotateE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_RotatedE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_ScaleE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_ScaledE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_Transform27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_Translate5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Translated5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_Translate5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Translated5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips2d_Area(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Directrix1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Directrix2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips2d_Eccentricity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips2d_Focal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Focus1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Focus2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_SetMajorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips2d_MajorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_SetMinorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips2d_MinorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips2d_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_SetXAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips2d_SetYAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_YAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips2d_Reversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Elips2d_IsDirect(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpElips2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpElips2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpElips2d_Dtor(IntPtr instance);
	}
}
