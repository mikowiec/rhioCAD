#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpElips : NativeInstancePtr
	{
		public gpElips()
 :
			base(gp_Elips_Ctor() )
		{}
		public gpElips(gpAx2 A2,double MajorRadius,double MinorRadius)
 :
			base(gp_Elips_CtorB1A3BD2A(A2.Instance, MajorRadius, MinorRadius) )
		{}
			public void Mirror(gpPnt P)
				{
					gp_Elips_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpElips Mirrored(gpPnt P)
				{
					return new gpElips(gp_Elips_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Elips_Mirror608B963B(Instance, A1.Instance);
				}
			public gpElips Mirrored(gpAx1 A1)
				{
					return new gpElips(gp_Elips_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Elips_Mirror7895386A(Instance, A2.Instance);
				}
			public gpElips Mirrored(gpAx2 A2)
				{
					return new gpElips(gp_Elips_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Elips_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpElips Rotated(gpAx1 A1,double Ang)
				{
					return new gpElips(gp_Elips_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Elips_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpElips Scaled(gpPnt P,double S)
				{
					return new gpElips(gp_Elips_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Elips_Transform72D78650(Instance, T.Instance);
				}
			public gpElips Transformed(gpTrsf T)
				{
					return new gpElips(gp_Elips_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Elips_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpElips Translated(gpVec V)
				{
					return new gpElips(gp_Elips_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Elips_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpElips Translated(gpPnt P1,gpPnt P2)
				{
					return new gpElips(gp_Elips_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public double Area{
			get {
				return gp_Elips_Area(Instance);
			}
		}
		public gpAx1 Axis{
			set { 
				gp_Elips_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Elips_Axis(Instance));
			}
		}
		public gpAx1 Directrix1{
			get {
				return new gpAx1(gp_Elips_Directrix1(Instance));
			}
		}
		public gpAx1 Directrix2{
			get {
				return new gpAx1(gp_Elips_Directrix2(Instance));
			}
		}
		public double Eccentricity{
			get {
				return gp_Elips_Eccentricity(Instance);
			}
		}
		public double Focal{
			get {
				return gp_Elips_Focal(Instance);
			}
		}
		public gpPnt Focus1{
			get {
				return new gpPnt(gp_Elips_Focus1(Instance));
			}
		}
		public gpPnt Focus2{
			get {
				return new gpPnt(gp_Elips_Focus2(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Elips_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Elips_Location(Instance));
			}
		}
		public double MajorRadius{
			set { 
				gp_Elips_SetMajorRadius(Instance, value);
			}
			get {
				return gp_Elips_MajorRadius(Instance);
			}
		}
		public double MinorRadius{
			set { 
				gp_Elips_SetMinorRadius(Instance, value);
			}
			get {
				return gp_Elips_MinorRadius(Instance);
			}
		}
		public double Parameter{
			get {
				return gp_Elips_Parameter(Instance);
			}
		}
		public gpAx2 Position{
			set { 
				gp_Elips_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx2(gp_Elips_Position(Instance));
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(gp_Elips_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(gp_Elips_YAxis(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_CtorB1A3BD2A(IntPtr A2,double MajorRadius,double MinorRadius);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips_Area(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Directrix1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Directrix2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips_Eccentricity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips_Focal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Focus1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Focus2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_SetMajorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips_MajorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_SetMinorRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips_MinorRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Elips_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Elips_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Elips_YAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpElips(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpElips_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpElips_Dtor(IntPtr instance);
	}
}
